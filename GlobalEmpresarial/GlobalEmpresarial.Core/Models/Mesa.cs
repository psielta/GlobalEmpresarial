using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Mesa
{
    public int NrLanc { get; set; }

    public int NumeroMesa { get; set; }

    public string? Status { get; set; }

    public string? Ativa { get; set; }

    public string? NomeMesa { get; set; }
}
