using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class UnidadeMedidum
{
    public string CdUnidade { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? TpUnidade { get; set; }
}
