ALTER TABLE public.tabela_preco
  ADD PRIMARY KEY (id);
DROP VIEW public.v_produtos_fornecedor_saida;
DROP VIEW public.v_produtos_fornecedor_orcamento;
DROP VIEW public.v_produtos_fornecedor_entrada;
CREATE VIEW public.v_produtos_fornecedor_orcamento (
    cd_forn,
    nm_forn,
    cd_produto,
    nm_produto,
    quant,
    tipo,
    data,
    empresa,
    cd_plano)
AS
SELECT f.cd_forn, f.nm_forn, p.cd_produto, p.nm_produto,
    COALESCE(sum(ito.quant), 0::numeric) AS quant, 'OS' AS tipo, o.data,
    '1' AS empresa, ito.cd_plano
FROM fornecedor f, produto_estoque p,
    produtos_forn pf
   JOIN (itens_orcamento ito
   JOIN orcamento o ON o.nr = ito.nr_or) ON ito.cd_produto = pf.cd_produto
WHERE f.cd_forn = pf.cd_forn AND p.cd_produto = pf.cd_produto
GROUP BY f.cd_forn, f.nm_forn, p.cd_produto, p.nm_produto, o.data, ito.cd_plano;

CREATE VIEW public.v_produtos_fornecedor_saida (
    cd_forn,
    nm_forn,
    cd_produto,
    nm_produto,
    quant,
    tipo,
    data,
    empresa,
    cd_plano)
AS
SELECT f.cd_forn, f.nm_forn, p.cd_produto, p.nm_produto,
    COALESCE(sum(ps.qt_total), 0::numeric) AS quant, cast('S' as varchar(1)) AS tipo, s.data,
    s.empresa, ps.cd_plano
FROM fornecedor f, saidas s, produto_saida ps, produto_estoque p,
    produtos_forn pf
WHERE ps.nr_saida = s.nr_lanc AND p.cd_produto = ps.cd_produto AND
    pf.cd_produto = p.cd_produto AND f.cd_forn = pf.cd_forn
GROUP BY f.cd_forn, f.nm_forn, p.cd_produto, p.nm_produto, s.data, s.empresa,
    ps.cd_plano;
CREATE VIEW public.v_produtos_fornecedor_entrada (
    cd_forn,
    nm_forn,
    cd_produto,
    nm_produto,
    quant,
    tipo,
    data,
    cd_empresa,
    cd_grupo_estoque)
AS
SELECT f.cd_forn, f.nm_forn, p.cd_produto, p.nm_produto,
    COALESCE(sum(pe.qt_total), 0::numeric) AS quant, cast('E' as varchar(1)) AS tipo, e.data,
    e.cd_empresa, e.cd_grupo_estoque
FROM fornecedor f, produtos_forn pf, entradas e, produto_entrada pe,
    produto_estoque p
WHERE f.cd_forn = e.cd_forn AND pf.cd_forn = e.cd_forn AND pf.cd_produto =
    pe.cd_produto AND pe.nr_entrada = e.nr AND p.cd_produto = pf.cd_produto
GROUP BY f.cd_forn, f.nm_forn, p.cd_produto, p.nm_produto, e.data,
    e.cd_empresa, e.cd_grupo_estoque;