using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ObsPadraoContasReceber
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? TxtObs { get; set; }
}
