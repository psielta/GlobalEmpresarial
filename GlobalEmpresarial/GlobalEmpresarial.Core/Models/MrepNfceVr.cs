using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MrepNfceVr
{
    public int Usr { get; set; }

    public string? VlItem { get; set; }

    public string? Desc { get; set; }

    public string? CancItem { get; set; }

    public string? CancVenda { get; set; }

    public virtual Usuario UsrNavigation { get; set; } = null!;
}
