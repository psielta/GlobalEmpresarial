using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DadosEcf
{
    public string NrEcf { get; set; } = null!;

    public string? Crz { get; set; }

    public string? NrSerieEcf { get; set; }

    public int? IdFrente { get; set; }

    public string? CdFrente { get; set; }
}
