using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class R03
{
    public int Id { get; set; }

    public int IdR02 { get; set; }

    public string? SerieEcf { get; set; }

    public string? TotalizadorParcial { get; set; }

    public decimal? ValorAcumulado { get; set; }

    public int? Crz { get; set; }

    public string? Sincronizado { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public string? Modelo { get; set; }

    public string? Mfd { get; set; }

    public virtual R02 IdR02Navigation { get; set; } = null!;
}
