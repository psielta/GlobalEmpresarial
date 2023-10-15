using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Cbo
{
    public int Id { get; set; }

    public string Codigo { get; set; } = null!;

    public string Descricao { get; set; } = null!;
}
