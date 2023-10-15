using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteOb
{
    public int Codigo { get; set; }

    public string TpObs { get; set; } = null!;

    public string Identificador { get; set; } = null!;

    public string Obs { get; set; } = null!;

    public int NrCte { get; set; }
}
