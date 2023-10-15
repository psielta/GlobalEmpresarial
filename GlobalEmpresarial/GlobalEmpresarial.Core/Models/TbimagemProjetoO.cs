using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TbimagemProjetoO
{
    public int Id { get; set; }

    public string IdSerieKitOrc { get; set; } = null!;

    public string? FotoProjeto { get; set; }
}
