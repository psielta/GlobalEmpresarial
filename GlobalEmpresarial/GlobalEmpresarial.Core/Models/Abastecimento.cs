using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Abastecimento
{
    public int Id { get; set; }

    public int IdBico { get; set; }

    public DateOnly? DataAbastecimento { get; set; }

    public TimeOnly? HoraAbastatecimento { get; set; }

    public decimal? Volume { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? ValorTotal { get; set; }

    public decimal? EncerranteInicial { get; set; }

    public decimal? EncerranteFinal { get; set; }

    public decimal? IdAutomacao { get; set; }

    public int? Status { get; set; }

    public int? IdMovimento { get; set; }

    public int? IdIdentified { get; set; }

    public string? SelecaoAbastecimento { get; set; }

    public string? StringAbastecimento { get; set; }

    public TimeOnly? HoraEcf { get; set; }

    public DateOnly? DataEcf { get; set; }

    public int? Coo { get; set; }

    public string? EcfSerie { get; set; }

    public int? Crz { get; set; }

    public int? HashIncremento { get; set; }

    public int? NBico { get; set; }

    public int? NTanque { get; set; }

    public int? NBomba { get; set; }

    public int? NotaNf { get; set; }

    public string? Integrador { get; set; }
}
