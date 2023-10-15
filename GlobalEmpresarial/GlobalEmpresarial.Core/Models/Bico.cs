using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Bico
{
    public int Id { get; set; }

    public int IdTanque { get; set; }

    public int IdBomba { get; set; }

    public int? NumeroBico { get; set; }

    public int? IdTanqueConjugado1 { get; set; }

    public int? IdTanqueConjugado2 { get; set; }

    public string? NumeroLogico { get; set; }

    public decimal? PrecoBico { get; set; }

    public decimal? EncerranteInicial { get; set; }

    public decimal? EncerranteFinal { get; set; }

    public decimal? VolumeVendas { get; set; }

    public string? Integrador { get; set; }
}
