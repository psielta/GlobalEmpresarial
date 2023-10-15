using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfVendaCabecalho
{
    public int Id { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEcfFuncionario { get; set; }

    public int IdEcfMovimento { get; set; }

    public int? IdEcfDav { get; set; }

    public int? IdEcfPreVendaCabecalho { get; set; }

    public string SerieEcf { get; set; } = null!;

    public int Cfop { get; set; }

    public int? Coo { get; set; }

    public int? Ccf { get; set; }

    public DateOnly? DataVenda { get; set; }

    public string? HoraVenda { get; set; }

    public decimal? ValorVenda { get; set; }

    public decimal? TaxaDesconto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? TaxaAcrescimo { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? ValorFinal { get; set; }

    public decimal? ValorRecebido { get; set; }

    public decimal? Troco { get; set; }

    public decimal? ValorCancelado { get; set; }

    public decimal? TotalProdutos { get; set; }

    public decimal? TotalDocumento { get; set; }

    public decimal? BaseIcms { get; set; }

    public decimal? Icms { get; set; }

    public decimal? IcmsOutras { get; set; }

    public decimal? Issqn { get; set; }

    public decimal? Pis { get; set; }

    public decimal? Cofins { get; set; }

    public decimal? AcrescimoItens { get; set; }

    public decimal? DescontoItens { get; set; }

    public string? StatusVenda { get; set; }

    public string? NomeCliente { get; set; }

    public string? CpfCnpjCliente { get; set; }

    public string? CupomCancelado { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public decimal? IcmsIsento { get; set; }

    public decimal? IcmsNaoTributado { get; set; }

    public decimal? IcmsSubstituicao { get; set; }

    public string? Baixou { get; set; }

    public string? Mfd { get; set; }

    public string? Modelo { get; set; }

    public string? NotaManual { get; set; }

    public string? TpDescto { get; set; }

    public string? TpAcres { get; set; }
}
