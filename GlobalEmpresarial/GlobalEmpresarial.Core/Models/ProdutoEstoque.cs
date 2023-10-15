using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdutoEstoque
{
    public int CdProduto { get; set; }

    public string NmProduto { get; set; } = null!;

    public decimal QuantMinima { get; set; }

    public string CdBarra { get; set; } = null!;

    public string? CodMargem { get; set; }

    public string? CodEspecie { get; set; }

    public string LancLivro { get; set; } = null!;

    public decimal? PorcVendedor { get; set; }

    public string? CdClassFiscal { get; set; }

    public int CdTribt { get; set; }

    public decimal? PesoBruto { get; set; }

    public decimal? PesoLiquido { get; set; }

    public decimal QtUnitario { get; set; }

    public int CdGrupo { get; set; }

    public int CdRef { get; set; }

    public decimal? QtTotal { get; set; }

    public int? CdSeq { get; set; }

    public string? Suspenso { get; set; }

    public int? CdPlanoEst { get; set; }

    public string? CdUni { get; set; }

    public decimal? PorcSaida { get; set; }

    public DateOnly? DtSuspenso { get; set; }

    public TimeOnly? HrSuspenso { get; set; }

    public DateOnly? DtAtivacao { get; set; }

    public TimeOnly? HrAtivacao { get; set; }

    public DateOnly? DtAtivoLivro { get; set; }

    public DateOnly? DtSuspLivro { get; set; }

    public TimeOnly? HrAtivoLivro { get; set; }

    public TimeOnly? HrSuspLivro { get; set; }

    public string? Ativo { get; set; }

    public string? DescRef { get; set; }

    public int? CdTribtFe { get; set; }

    public decimal? Mva { get; set; }

    public decimal? Mvaajustado { get; set; }

    public string? Foto { get; set; }

    public string? CstDentro1 { get; set; }

    public string? CstDentro2 { get; set; }

    public string? CstFora1 { get; set; }

    public string? CstFora2 { get; set; }

    public string? CstIpi { get; set; }

    public string? CstPis { get; set; }

    public string? CfoDentro { get; set; }

    public string? CfoFora { get; set; }

    public decimal? PorcSubst { get; set; }

    public decimal? PorcIpi { get; set; }

    public decimal? IcmsDentro { get; set; }

    public decimal? IcmsFora { get; set; }

    public string? ExTipi { get; set; }

    public string? CdGenero { get; set; }

    public string? TpItem { get; set; }

    public string? LetraCurvaabc { get; set; }

    public decimal? PorcVendaAPrazo { get; set; }

    public decimal? PorcVendaCd { get; set; }

    public decimal? PorcVendaCc { get; set; }

    public decimal? QtdeMax { get; set; }

    public string? Corredor { get; set; }

    public string? Prateleira { get; set; }

    public string? TxtObs { get; set; }

    public string? CdInterno { get; set; }

    public string? StEcf { get; set; }

    public string? CdCsosn { get; set; }

    public string? CodigoBalanca { get; set; }

    public string? Iat { get; set; }

    public string? Ippt { get; set; }

    public string? TipoItemSped { get; set; }

    public decimal? TaxaPis { get; set; }

    public decimal? TaxaIssqn { get; set; }

    public decimal? TaxaCofins { get; set; }

    public string? TotalizadorParcial { get; set; }

    public decimal? VlAVista { get; set; }

    public decimal? VlPrazo { get; set; }

    public decimal? VlCc { get; set; }

    public decimal? VlDeb { get; set; }

    public string? EcfIcmSt { get; set; }

    public short? TpCdBalanca { get; set; }

    public string? CstCofins { get; set; }

    public string? Balanca { get; set; }

    public short? QtDiasVenc { get; set; }

    public decimal? VlTabelaGov { get; set; }

    public decimal? PorcAliqInterna { get; set; }

    public decimal? VlComanda { get; set; }

    public string? ClasseTerapeutica { get; set; }

    public string? RegMs { get; set; }

    public string? CodigoDcb { get; set; }

    public string? DescricaoProduto { get; set; }

    public int? CdAnp { get; set; }

    public decimal? VlMedia { get; set; }

    public decimal? VlPequena { get; set; }

    public string? Transferiu { get; set; }

    public string? Cest { get; set; }

    public decimal? VlCusto { get; set; }

    public decimal? VlAtacado { get; set; }

    public int? IdMarca { get; set; }

    public string? Local { get; set; }

    public string? BandejaGaveta { get; set; }

    public decimal? EntMva { get; set; }

    public decimal? EntPorcSt { get; set; }

    public decimal? EntReducaoBc { get; set; }

    public decimal? EntBcSt { get; set; }

    public decimal? EntIcmsSt { get; set; }

    public decimal? IcmsSubsAliq { get; set; }

    public decimal? IcmsSubsReducao { get; set; }

    public decimal? IcmsSubsReducaoAliq { get; set; }

    public decimal? LucroPor { get; set; }

    public decimal? OperacionalPor { get; set; }

    public decimal? Frete { get; set; }

    public string? NomeImagem { get; set; }

    public string? ControlaEstoque { get; set; }

    public decimal? VlCustoVariavel { get; set; }

    public string? Principal { get; set; }

    public string? Embalagem { get; set; }

    public string? Capacidade { get; set; }

    public virtual ICollection<CabCotacaoPreco> CabCotacaoPrecos { get; set; } = new List<CabCotacaoPreco>();

    public virtual GrupoEstoque CdGrupoNavigation { get; set; } = null!;

    public virtual ReferenciaEstoque CdRefNavigation { get; set; } = null!;

    public virtual ICollection<ComandaDetalhe> ComandaDetalhes { get; set; } = new List<ComandaDetalhe>();

    public virtual ICollection<ComandaTipoImpressora> ComandaTipoImpressoras { get; set; } = new List<ComandaTipoImpressora>();

    public virtual ICollection<ComposicaoKitProduto> ComposicaoKitProdutos { get; set; } = new List<ComposicaoKitProduto>();

    public virtual ICollection<ComposicaoProduto> ComposicaoProdutoIdProdutoNavigations { get; set; } = new List<ComposicaoProduto>();

    public virtual ICollection<ComposicaoProduto> ComposicaoProdutoIdProdutoPrincipalNavigations { get; set; } = new List<ComposicaoProduto>();

    public virtual ICollection<ContagemPrMobile> ContagemPrMobiles { get; set; } = new List<ContagemPrMobile>();

    public virtual ICollection<DadosVendConsumidor> DadosVendConsumidors { get; set; } = new List<DadosVendConsumidor>();

    public virtual ICollection<DavDetalhe> DavDetalhes { get; set; } = new List<DavDetalhe>();

    public virtual ICollection<DetalheVendaFarmPopular> DetalheVendaFarmPopulars { get; set; } = new List<DetalheVendaFarmPopular>();

    public virtual ICollection<EmprestimoPeca> EmprestimoPecas { get; set; } = new List<EmprestimoPeca>();

    public virtual ICollection<FmComponente> FmComponentes { get; set; } = new List<FmComponente>();

    public virtual ICollection<FmEmbalagem> FmEmbalagems { get; set; } = new List<FmEmbalagem>();

    public virtual ICollection<FmFormaFarmaceutica> FmFormaFarmaceuticas { get; set; } = new List<FmFormaFarmaceutica>();

    public virtual ICollection<FmMedicamento> FmMedicamentos { get; set; } = new List<FmMedicamento>();

    public virtual ICollection<FmOmBaixa> FmOmBaixas { get; set; } = new List<FmOmBaixa>();

    public virtual ICollection<InformacaoTecnicaProduto> InformacaoTecnicaProdutos { get; set; } = new List<InformacaoTecnicaProduto>();

    public virtual ICollection<ItensOrcamento> ItensOrcamentos { get; set; } = new List<ItensOrcamento>();

    public virtual ICollection<ItensVendaControlado> ItensVendaControlados { get; set; } = new List<ItensVendaControlado>();

    public virtual ICollection<ModeloVeicProduto> ModeloVeicProdutos { get; set; } = new List<ModeloVeicProduto>();

    public virtual ICollection<ObsComandaProduto> ObsComandaProdutos { get; set; } = new List<ObsComandaProduto>();

    public virtual ICollection<ObsItemComandum> ObsItemComanda { get; set; } = new List<ObsItemComandum>();

    public virtual ICollection<PerdaMedControlado> PerdaMedControlados { get; set; } = new List<PerdaMedControlado>();

    public virtual ProdAdcAcai? ProdAdcAcai { get; set; }

    public virtual ICollection<ProdEntrMatAcabado> ProdEntrMatAcabados { get; set; } = new List<ProdEntrMatAcabado>();

    public virtual ICollection<ProdKit> ProdKits { get; set; } = new List<ProdKit>();

    public virtual ICollection<ProdutoEntradum> ProdutoEntrada { get; set; } = new List<ProdutoEntradum>();

    public virtual ICollection<ProdutoSaidum> ProdutoSaida { get; set; } = new List<ProdutoSaidum>();

    public virtual ICollection<ProdutoTransferencium> ProdutoTransferencia { get; set; } = new List<ProdutoTransferencium>();

    public virtual ICollection<SaldoEstoque> SaldoEstoques { get; set; } = new List<SaldoEstoque>();

    public virtual ICollection<SubItensCompProduto> SubItensCompProdutos { get; set; } = new List<SubItensCompProduto>();

    public virtual ICollection<TbDescVProd> TbDescVProds { get; set; } = new List<TbDescVProd>();

    public virtual ICollection<TbcontaEstoque> TbcontaEstoques { get; set; } = new List<TbcontaEstoque>();

    public virtual ICollection<VrDevolucao> VrDevolucaos { get; set; } = new List<VrDevolucao>();

    public virtual ICollection<ProdutoEstoque> CdProduto1s { get; set; } = new List<ProdutoEstoque>();

    public virtual ICollection<ProdutoEstoque> CdProduto2s { get; set; } = new List<ProdutoEstoque>();
}
