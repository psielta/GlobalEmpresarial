using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Tanque
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public string? NumeroTanque { get; set; }

    public decimal? Estoque { get; set; }

    public decimal? CapacidadeTanque { get; set; }

    public decimal? CapacidadeLastro { get; set; }

    public string? Fabricante { get; set; }

    public string? Modelo { get; set; }

    public DateOnly? DataFabricacao { get; set; }

    public int? VidaUtil { get; set; }

    public string? Obs { get; set; }

    public char? Integrador { get; set; }
}
