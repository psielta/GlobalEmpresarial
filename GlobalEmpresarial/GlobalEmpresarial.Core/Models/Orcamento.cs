using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Orcamento
{
    public int Nr { get; set; }

    public DateOnly? Data { get; set; }

    public DateOnly? DtValidade { get; set; }

    public int? CdVendedor { get; set; }

    public int CdCliente { get; set; }

    public int? CdAutomovel { get; set; }

    public string TpPagt { get; set; } = null!;

    public string? TxtObs { get; set; }

    public int? CdParceiro { get; set; }

    public string? GerouOs { get; set; }

    public string? Status { get; set; }

    public DateOnly? DtGerouOs { get; set; }

    public string? TpOrcamento { get; set; }

    public int? NrOrcamentoAnt { get; set; }

    public string? GerouSaida { get; set; }

    public string? Pagou { get; set; }

    public decimal? ValorDesconto { get; set; }

    public decimal? ValorPago { get; set; }

    public decimal? ValorTotal { get; set; }

    public decimal? VlComissao { get; set; }

    public DateOnly? DtPagParc { get; set; }

    public string? NrInterno { get; set; }

    public short? QtParcela { get; set; }

    public string? JeitoPagamento { get; set; }

    public int? NrFormaPagt { get; set; }

    public decimal? KmAtual { get; set; }

    public string? TpEntrada { get; set; }

    public string? NmSolicitante { get; set; }

    public int? AvalTecnicaResponsavel { get; set; }

    public DateOnly? AvalTecnicaDtIniico { get; set; }

    public DateOnly? AvalTecnicaDtFim { get; set; }

    public string? AvalTecnicaStatus { get; set; }

    public int? AprovOsFunc { get; set; }

    public string? AprovOsNmClienteAvisa { get; set; }

    public DateOnly? AprovOsDtAvisado { get; set; }

    public string? AprovOsStatus { get; set; }

    public int? EntregEqFunc { get; set; }

    public string? EntregEqRecPor { get; set; }

    public DateOnly? EntregEqRecDtEntreg { get; set; }

    public decimal? ValorRestante { get; set; }

    public string? ObsFecham { get; set; }

    public int? IdStatusOs { get; set; }

    public int? IdDepartamento { get; set; }

    public int? IdConvenio { get; set; }

    public int? IdMedico { get; set; }

    public int? IdPaciente { get; set; }

    public DateOnly? DtCirugia { get; set; }

    public string? TpCirugia { get; set; }

    public string? MarcaEquip { get; set; }

    public int? IdComoAchou { get; set; }

    public int? IdEnderecoEntrega { get; set; }

    public string? TxtObsAdicional { get; set; }

    public string? AtivaAlerta { get; set; }

    public DateOnly? DataAlerta { get; set; }

    public string? SituacaoAlerta { get; set; }

    public string? Devolucao { get; set; }

    public virtual ICollection<ItensOrcamento> ItensOrcamentos { get; set; } = new List<ItensOrcamento>();

    public virtual ICollection<OsDevolucao> OsDevolucaos { get; set; } = new List<OsDevolucao>();

    public virtual ICollection<ServOrcamento> ServOrcamentos { get; set; } = new List<ServOrcamento>();
}
