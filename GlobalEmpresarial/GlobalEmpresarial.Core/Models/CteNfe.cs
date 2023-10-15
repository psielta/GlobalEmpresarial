using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteNfe
{
    public int Codigo { get; set; }

    public string Chave { get; set; } = null!;

    public int? Pin { get; set; }

    public DateOnly? DtPrevista { get; set; }

    public string? TpUnidade { get; set; }

    public int NrCte { get; set; }
}
