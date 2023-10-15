using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SericoGlobal
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public decimal? Valor { get; set; }
}
