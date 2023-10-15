using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ContasAPagar
{
    public int NrLancamento { get; set; }

    public DateOnly DtLancamento { get; set; }

    public DateOnly DtVencimento { get; set; }

    public DateOnly? DtPagou { get; set; }

    public int CdFornecedor { get; set; }

    public int? NrEntrada { get; set; }

    public string? NrDuplicata { get; set; }

    public decimal VlCp { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlTotal { get; set; }

    public decimal? VlAcrescimo { get; set; }

    public decimal? VlPagoFinal { get; set; }

    public string Pagou { get; set; } = null!;

    public string? TxtObs { get; set; }

    public string? TpFormaPagt { get; set; }

    public int CdEmpresa { get; set; }

    public string? NrCheque { get; set; }

    public int? NrConta { get; set; }

    public string? PagoA { get; set; }

    public decimal? VlCheque { get; set; }

    public string? NrNf { get; set; }

    public string CdPlanoCaixa { get; set; } = null!;

    public string CdHistoricoCaixa { get; set; } = null!;

    public int? NrFormaPagt { get; set; }

    public decimal? VlDinheiro { get; set; }

    public string? IdLancPrinc { get; set; }

    public int? NrEntradaOutraDesp { get; set; }

    public virtual HistoricoCaixa Cd { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual Fornecedor CdFornecedorNavigation { get; set; } = null!;
}
