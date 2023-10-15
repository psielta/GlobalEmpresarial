using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Cst
{
    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Cfop> Cfops { get; set; } = new List<Cfop>();
}
