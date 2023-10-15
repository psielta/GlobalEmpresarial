using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmItemOm
{
    public int Id { get; set; }

    public int? IdOm { get; set; }

    public int? IdMedicamento { get; set; }

    public int? IdFormaFarm { get; set; }

    public int? IdTamanho { get; set; }

    public int? IdEmbalagem { get; set; }

    public string? QtdeLib { get; set; }

    public string? Posologia { get; set; }

    public string? Dosagem { get; set; }

    public string? Lote { get; set; }

    public DateOnly? DtValidade { get; set; }

    public string? TamanhoLote { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Peso { get; set; }

    public string? Potencia { get; set; }

    public string? Porcenteagem { get; set; }

    public string? Concentracao { get; set; }

    public decimal? Valor { get; set; }

    public string? UnDosagem { get; set; }

    public string? UnConcentracao { get; set; }

    public string? TipoMed { get; set; }
}
