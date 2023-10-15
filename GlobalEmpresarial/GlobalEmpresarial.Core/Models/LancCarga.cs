using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class LancCarga
{
    public int NrCarga { get; set; }

    public DateOnly DtInicial { get; set; }

    public DateOnly DtFinal { get; set; }

    public string Fechou { get; set; } = null!;

    public int? CdVendedor { get; set; }

    public DateOnly? DtSaidaCarga { get; set; }
}
