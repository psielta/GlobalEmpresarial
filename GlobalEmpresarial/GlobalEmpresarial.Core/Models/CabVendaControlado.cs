using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CabVendaControlado
{
    public int NrLanc { get; set; }

    public DateOnly? DtLanc { get; set; }

    public TimeOnly? HrLanc { get; set; }

    public int CdEmpresa { get; set; }

    public int CdCliente { get; set; }

    public string? NrNotificacao { get; set; }

    public DateOnly? DtPrescricao { get; set; }

    public string UsoMedicamento { get; set; } = null!;

    public int CdMedico { get; set; }

    public string UfMedico { get; set; } = null!;

    public string? Cid { get; set; }

    public string CdConselho { get; set; } = null!;

    public string? Status { get; set; }

    public int TpReceita { get; set; }

    public string? NmComprador { get; set; }

    public string? TpDocComprador { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<ItensVendaControlado> ItensVendaControlados { get; set; } = new List<ItensVendaControlado>();
}
