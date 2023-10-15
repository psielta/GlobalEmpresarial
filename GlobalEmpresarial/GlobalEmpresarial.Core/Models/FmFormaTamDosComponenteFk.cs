using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmFormaTamDosComponenteFk
{
    public int Id { get; set; }

    public int? IdComponente { get; set; }

    public int? IdFormaTamanho { get; set; }

    public decimal? VolumeMinimo { get; set; }

    public decimal? PesoMinimo { get; set; }

    public decimal? VolumeMaximo { get; set; }

    public decimal? PesoMaximo { get; set; }

    public decimal? UiMaximo { get; set; }

    public decimal? UiMinimo { get; set; }

    public string? Concentracao { get; set; }

    public decimal? PesoTotal { get; set; }

    public virtual FmComponente? IdComponenteNavigation { get; set; }

    public virtual FmFormaTamanhoFk? IdFormaTamanhoNavigation { get; set; }
}
