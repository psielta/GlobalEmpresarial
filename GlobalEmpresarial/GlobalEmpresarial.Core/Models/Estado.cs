using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Estado
{
    public string Codigo { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Abrev { get; set; }
}
