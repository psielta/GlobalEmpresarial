using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

/// <summary>
/// Sub itens da tabela composicao produto
/// </summary>
public partial class SubItensCompProduto
{
    public int Id { get; set; }

    public int IdComposicao { get; set; }

    public int IdProduto { get; set; }

    public decimal Quantidade { get; set; }

    public virtual ComposicaoProduto IdComposicaoNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
