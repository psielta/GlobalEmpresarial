using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CestNcm
{
    public string NrCest { get; set; } = null!;

    public string NrNcm { get; set; } = null!;

    public virtual Cest NrCestNavigation { get; set; } = null!;
}
