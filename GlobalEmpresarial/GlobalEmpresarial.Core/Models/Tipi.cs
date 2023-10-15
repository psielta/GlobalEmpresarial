using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Tipi
{
    public string Ncm { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public string? Aliquota { get; set; }

    public int? IdCf { get; set; }
}
