using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteDocAnteriorNfe
{
    public int Id { get; set; }

    public int IdDocAnterior { get; set; }

    public string IdChave { get; set; } = null!;

    public virtual CteDocAnterior IdDocAnteriorNavigation { get; set; } = null!;
}
