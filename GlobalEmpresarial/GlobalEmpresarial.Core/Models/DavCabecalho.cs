using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DavCabecalho
{
    public int Id { get; set; }

    public int? IdPessoa { get; set; }

    public int? IdEmpresa { get; set; }

    public int? Ccf { get; set; }

    public int? Coo { get; set; }

    public string? NomeDestinatario { get; set; }

    public string? CpfCnpjDestinatario { get; set; }

    public DateOnly? DataEmissao { get; set; }

    public string? HoraEmissao { get; set; }

    public string? Situacao { get; set; }

    public decimal? TaxaAcrescimo { get; set; }

    public decimal? Acrescimo { get; set; }

    public decimal? TaxaDesconto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Subtotal { get; set; }

    public decimal? Valor { get; set; }

    public string? Impresso { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public string? NumeroDav { get; set; }

    public string? NumeroEcf { get; set; }

    public string? Hash { get; set; }

    public string? Ndv { get; set; }

    public string? Decricao { get; set; }

    public string? CodigoManipulado { get; set; }

    public string? EcfPrint { get; set; }

    public string? CooDavEcf { get; set; }

    public string? Integrador { get; set; }

    public virtual ICollection<DavDetalhe> DavDetalhes { get; set; } = new List<DavDetalhe>();
}
