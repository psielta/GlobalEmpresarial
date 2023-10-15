using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteDuplicatum
{
    public int Codigo { get; set; }

    public string? Numero { get; set; }

    public DateOnly? DtVenc { get; set; }

    public decimal? Valor { get; set; }

    public int NrCte { get; set; }
}
