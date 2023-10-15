using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ReceitasPisCofin
{
    public string Codigo { get; set; } = null!;

    public string? Imposto { get; set; }

    public string? Descricao { get; set; }

    public string? Periodo { get; set; }
}
