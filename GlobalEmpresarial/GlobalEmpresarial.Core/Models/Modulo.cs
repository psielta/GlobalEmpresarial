using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Modulo
{
    public string CdModulo { get; set; } = null!;

    public string NmModulo { get; set; } = null!;

    public virtual ICollection<MenuSistema> MenuSistemas { get; set; } = new List<MenuSistema>();
}
