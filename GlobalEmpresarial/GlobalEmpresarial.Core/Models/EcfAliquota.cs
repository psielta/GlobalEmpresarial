using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfAliquota
{
    public int Id { get; set; }

    public string? TotalizadorParcial { get; set; }

    public string? EcfIcmsSt { get; set; }

    public string? PafPSt { get; set; }

    public string? Integrador { get; set; }
}
