using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ApontamentoMaquina
{
    public int NrLanc { get; set; }

    public DateOnly DtLanc { get; set; }

    public int CdFrota { get; set; }

    public int CdFunc { get; set; }

    public int CdCliente { get; set; }

    public string? Local { get; set; }

    public int CdOperacao { get; set; }

    public TimeOnly HrInicial { get; set; }

    public TimeOnly HrFinal { get; set; }

    public decimal HorInicial { get; set; }

    public decimal HorFinal { get; set; }

    public string? TxtObs { get; set; }

    public string Autorizado { get; set; } = null!;

    public string? Fechou { get; set; }

    public int? NrFechamento { get; set; }

    public int CdEmpresa { get; set; }

    public TimeOnly? HrDescanso { get; set; }

    public string? TxtAutorizado { get; set; }

    public string? TpPagamento { get; set; }

    public string? TxtOperacao { get; set; }

    public string? GerouNf { get; set; }

    public string? NrInterno { get; set; }

    public int? NrRecibo { get; set; }

    public string? Recebeu { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual OperacaoTerra CdOperacaoNavigation { get; set; } = null!;
}
