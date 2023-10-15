using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ControleCheque
{
    public int NrLanc { get; set; }

    public DateOnly DtLancamento { get; set; }

    public DateOnly DtPrazoCheque { get; set; }

    public string NrCheque { get; set; } = null!;

    public string? CdAgencia { get; set; }

    public string? CdBanco { get; set; }

    public string ChequeDe { get; set; } = null!;

    public int? CdCliente { get; set; }

    public decimal VlCheque { get; set; }

    public string Baixou { get; set; } = null!;

    public DateOnly? DtBaixa { get; set; }

    public string? TpBaixa { get; set; }

    public string? TxtObs { get; set; }

    public int? NrCp { get; set; }

    public int? NrCr { get; set; }

    public int CdEmpresa { get; set; }

    public string? BandaMagnetica { get; set; }

    public int? CdConta { get; set; }

    public string? CdHistorico { get; set; }

    public string? CdPlanoCaixa { get; set; }

    public string? Passoupara { get; set; }

    public int? CdForn { get; set; }

    public string? NrContaCheque { get; set; }

    public decimal? PorcJuros { get; set; }

    public int? QtdeDias { get; set; }

    public decimal? ValorLiquido { get; set; }

    public virtual HistoricoCaixa? Cd { get; set; }

    public virtual ContaDoCaixa? CdContaNavigation { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;
}
