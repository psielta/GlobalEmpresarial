using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FechamentoTerra
{
    public int NrFechamento { get; set; }

    public DateOnly DtFechamento { get; set; }

    public string TotalHrs { get; set; } = null!;

    public decimal TotalHorimetro { get; set; }

    public decimal TotalKm { get; set; }

    public decimal VlUnitHrs { get; set; }

    public decimal VlUnitHor { get; set; }

    public decimal VlUnitKm { get; set; }

    public decimal VlTotalHrs { get; set; }

    public decimal VlTotalHor { get; set; }

    public decimal VlTotalKm { get; set; }

    public string TotalHrMaq { get; set; } = null!;

    public decimal VlUnitHrMaq { get; set; }

    public decimal VlTotalHrMaq { get; set; }

    public decimal TotalKmMaq { get; set; }

    public decimal VlUnitKmMaq { get; set; }

    public decimal VlTotalKmMaq { get; set; }

    public int CdCliente { get; set; }

    public int? QtDeslocamentoVeic { get; set; }

    public int? QtDeslocamentoMaq { get; set; }

    public int? QtViageMaq { get; set; }

    public int? QtViageVeic { get; set; }

    public int? QtDiariaMaq { get; set; }

    public int? QtDiariaVeic { get; set; }

    public decimal? ValorDescMaq { get; set; }

    public decimal? ValorDescVeic { get; set; }

    public decimal? ValorViageVeic { get; set; }

    public decimal? ValorViageMaq { get; set; }

    public decimal? ValorDiariaMaq { get; set; }

    public decimal? ValorDiariaVeic { get; set; }

    public int? NrRecibo { get; set; }

    public decimal? VlPedagioVei { get; set; }

    public decimal? VlPedagioMaq { get; set; }

    public decimal? VlDesconto { get; set; }

    public decimal? VlFreteMaq { get; set; }

    public decimal? VlFreteVeic { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;
}
