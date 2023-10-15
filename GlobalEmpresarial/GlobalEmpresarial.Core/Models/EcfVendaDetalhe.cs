using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfVendaDetalhe
{
    public int Id { get; set; }

    public int? IdEcfProduto { get; set; }

    public int IdEcfVendaCabecalho { get; set; }

    public string SerieEcf { get; set; } = null!;

    public string? Gtin { get; set; }

    public int? Ccf { get; set; }

    public int? Coo { get; set; }

    public int Cfop { get; set; }

    public int? Item { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? ValorTotal { get; set; }

    public decimal? TotalItem { get; set; }

    public decimal? BaseIcms { get; set; }

    public decimal? TaxaIcms { get; set; }

    public decimal? Icms { get; set; }

    public decimal? TaxaDesconto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? TaxaIssqn { get; set; }

    public decimal? Issqn { get; set; }

    public decimal? TaxaPis { get; set; }

    public decimal? Pis { get; set; }

    public decimal? TaxaCofins { get; set; }

    public decimal? Cofins { get; set; }

    public decimal? TaxaAcrescimo { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? AcrescimoRateio { get; set; }

    public decimal? DescontoRateio { get; set; }

    public string? TotalizadorParcial { get; set; }

    public string? EcfIcmsSt { get; set; }

    public string? Cst { get; set; }

    public string? Cancelado { get; set; }

    public string? MovimentaEstoque { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public string? Cancelaitem { get; set; }

    public int? Cooo { get; set; }

    public decimal? IcmsIsento { get; set; }

    public decimal? IcmsNaoTributado { get; set; }

    public decimal? IcmsSubstituicao { get; set; }

    public decimal? VlAproxImposto { get; set; }

    public decimal? PorcIbpt { get; set; }

    public string? Mfd { get; set; }

    public string? Modelo { get; set; }

    public char? Baixou { get; set; }

    public int? CdPlano { get; set; }
}
