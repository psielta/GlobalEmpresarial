using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CfopXCfopEntradum
{
    public string CdCfopS { get; set; } = null!;

    public string CdCfopE { get; set; } = null!;

    public string? CfopDentro { get; set; }

    public string? CfopFora { get; set; }

    public string? Csosn { get; set; }
}
