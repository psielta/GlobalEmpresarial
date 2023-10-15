using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmMedOm
{
    public int Id { get; set; }

    public int? IdOm { get; set; }

    public int? IdMed { get; set; }

    public string? Dosagem { get; set; }

    public string? Potencia { get; set; }

    public string? Porcentagem { get; set; }

    public string? Concentracao { get; set; }

    public string? UnDosagem { get; set; }

    public string? UnConcentracao { get; set; }
}
