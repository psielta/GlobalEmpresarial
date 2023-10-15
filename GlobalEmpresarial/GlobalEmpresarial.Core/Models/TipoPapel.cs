using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TipoPapel
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public double? Altura { get; set; }

    public double? Largura { get; set; }
}
