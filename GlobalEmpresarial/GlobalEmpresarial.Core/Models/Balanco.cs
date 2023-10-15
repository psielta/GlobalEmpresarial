using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Balanco
{
    public int Idbalanco { get; set; }

    public DateOnly? Data { get; set; }

    public string? Gerado { get; set; }

    public virtual ICollection<ItensBalanco> ItensBalancos { get; set; } = new List<ItensBalanco>();
}
