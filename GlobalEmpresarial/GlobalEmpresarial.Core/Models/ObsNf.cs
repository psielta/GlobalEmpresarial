using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ObsNf
{
    public int NrLanc { get; set; }

    public string NmObs { get; set; } = null!;

    public string? TxtObs { get; set; }
}
