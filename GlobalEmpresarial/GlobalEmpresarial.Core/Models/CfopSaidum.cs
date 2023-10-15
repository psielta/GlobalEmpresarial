using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CfopSaidum
{
    public int NrSaida { get; set; }

    public string CdCfop { get; set; } = null!;

    public string Principal { get; set; } = null!;

    public virtual Cfop CdCfopNavigation { get; set; } = null!;
}
