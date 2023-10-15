using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmItemForma
{
    public int Id { get; set; }

    public int? IdComponente { get; set; }

    public int? IdForma { get; set; }

    public decimal? VolumeMinimo { get; set; }

    public decimal? PesoMinimo { get; set; }

    public decimal? VolumeMaximo { get; set; }

    public decimal? PesoMaximo { get; set; }

    public decimal? UiMaximo { get; set; }

    public decimal? UiMinimo { get; set; }

    public string? Concentracao { get; set; }

    public decimal? PesoTotal { get; set; }
}
