using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MenuSistema
{
    public int NrMenu { get; set; }

    public string NmMenu { get; set; } = null!;

    public string NmFormulario { get; set; } = null!;

    public string CdModulo { get; set; } = null!;

    public virtual Modulo CdModuloNavigation { get; set; } = null!;

    public virtual ICollection<MenuUsuario> MenuUsuarios { get; set; } = new List<MenuUsuario>();
}
