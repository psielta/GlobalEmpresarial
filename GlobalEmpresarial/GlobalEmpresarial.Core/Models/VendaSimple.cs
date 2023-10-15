using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VendaSimple
{
    public int NrLanc { get; set; }

    public DateOnly? DtLanc { get; set; }

    public TimeOnly? HoraLanc { get; set; }

    public int CdCliente { get; set; }

    public int CdProduto { get; set; }

    public int CdPlano { get; set; }

    public int CdEmpresa { get; set; }

    public decimal Quant { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValidade { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlTotal { get; set; }

    public string GerouSaida { get; set; } = null!;

    public int? CdVendedor { get; set; }

    public string? FormaPagt { get; set; }

    public int? NrSaida { get; set; }

    public int? NrAberturaCaixa { get; set; }

    public string? NmUsuario { get; set; }

    public int? CdParceiro { get; set; }

    public decimal? VlComissao { get; set; }

    public DateOnly? DtPagParc { get; set; }

    public string? Pagou { get; set; }

    public decimal? VlDesconto { get; set; }

    public decimal? VlDescontoItem { get; set; }

    public int? IdTipoVenda { get; set; }

    public string? Sequencia { get; set; }

    public string? Observacao { get; set; }

    public int? IdBandeira { get; set; }

    public string? MaisFormapgt { get; set; }

    public int? Caixa { get; set; }

    public decimal? TotalPago { get; set; }

    public decimal? Troco { get; set; }

    public decimal? VlCusto { get; set; }

    public decimal? VlDescontoClassificacao { get; set; }
}
