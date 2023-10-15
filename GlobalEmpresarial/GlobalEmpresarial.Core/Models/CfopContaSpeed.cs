using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CfopContaSpeed
{
    public int Id { get; set; }

    public int IdEmpresa { get; set; }

    public string IdCfop { get; set; } = null!;

    public string ContaAnaSpedInv { get; set; } = null!;

    public virtual Cfop IdCfopNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
