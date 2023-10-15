using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class LivroCaixa
{
    public int NrLanc { get; set; }

    public DateOnly DtLanc { get; set; }

    public int CdEmpresa { get; set; }

    public string CdHistorico { get; set; } = null!;

    public decimal VlLancamento { get; set; }

    public int? NrCp { get; set; }

    public int? NrCr { get; set; }

    public string? TxtObs { get; set; }

    public int NrConta { get; set; }

    public string CdPlanoCaixa { get; set; } = null!;

    public int? NrValeFunc { get; set; }

    public string? NrCheque { get; set; }

    public string? NrDoc { get; set; }

    public int? NrCentroCusto { get; set; }

    public int? NrSangria { get; set; }

    public int? NrVendaC { get; set; }

    public int? NrFinalEcf { get; set; }

    public int? NrIdComanda { get; set; }

    public int? IdBandeira { get; set; }

    public int? NrVendaBalcao { get; set; }

    public int? NrSaidaEstoque { get; set; }

    public int? IdCliente { get; set; }

    public virtual HistoricoCaixa Cd { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ContaDoCaixa NrContaNavigation { get; set; } = null!;
}
