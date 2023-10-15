using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmIncompatibilidade
{
    public int Id { get; set; }

    public int? Idmedicamento { get; set; }

    public int? Incompativel { get; set; }

    public string? Observacao { get; set; }
}
