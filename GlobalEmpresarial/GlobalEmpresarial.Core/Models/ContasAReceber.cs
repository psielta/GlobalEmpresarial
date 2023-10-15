using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ContasAReceber
{
    public int NrConta { get; set; }

    public DateOnly? DataLanc { get; set; }

    public DateOnly DtVencimento { get; set; }

    public int CdEmpresa { get; set; }

    public int CdCliente { get; set; }

    public string? NrDuplicata { get; set; }

    public decimal VlConta { get; set; }

    public decimal VlAcrescimo { get; set; }

    public decimal? VlDesconto { get; set; }

    public decimal VlTotal { get; set; }

    public decimal? VlPago { get; set; }

    public decimal? VlJuros { get; set; }

    public DateOnly? DtPagamento { get; set; }

    public int? NrUsuario { get; set; }

    public string Recebeu { get; set; } = null!;

    public int Quantidade { get; set; }

    public int QtParcela { get; set; }

    public string? TxtObs { get; set; }

    public int? NrContaCaixa { get; set; }

    public string? CdHistoricoCaixa { get; set; }

    public string? CdPlanoCaixa { get; set; }

    public int? NrSaida { get; set; }

    public string? NrBoleto { get; set; }

    public string? TxtBoleto { get; set; }

    public int? CdProjeto { get; set; }

    public string? Base { get; set; }

    public decimal? VlIss { get; set; }

    public decimal? VlIrrf { get; set; }

    public int? NrOs { get; set; }

    public int? NrFormaPagt { get; set; }

    public string? Imprimiu { get; set; }

    public decimal? VlBruto { get; set; }

    public string? Status { get; set; }

    public int? NrContaRenegociado { get; set; }

    public string? Alteradodtvenc { get; set; }

    public int? IdAluno { get; set; }

    public string? Cancelado { get; set; }

    public int? IdGrupo { get; set; }

    public int? IdBandeira { get; set; }

    public string? Vinculado { get; set; }

    public int? IdLancPrincipal { get; set; }

    public virtual HistoricoCaixa? Cd { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;
}
