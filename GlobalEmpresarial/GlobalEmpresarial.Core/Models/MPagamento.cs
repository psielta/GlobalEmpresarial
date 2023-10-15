using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MPagamento
{
    public DateOnly? DataAcumulado { get; set; }

    public string? Descricao { get; set; }

    public decimal? Total { get; set; }

    public string? Tipodoc { get; set; }

    public string? Integrador { get; set; }

    public string? Hash { get; set; }

    public int? HashIncremento { get; set; }

    public int Id { get; set; }
}
