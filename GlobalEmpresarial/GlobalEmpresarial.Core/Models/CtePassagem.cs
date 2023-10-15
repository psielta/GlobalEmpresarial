using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CtePassagem
{
    public int Codigo { get; set; }

    public string NrPassagem { get; set; } = null!;

    public int NrCte { get; set; }
}
