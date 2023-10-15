using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CupomNfe
{
    public int Id { get; set; }

    public int? Idsaida { get; set; }

    public int? IdCliente { get; set; }

    public DateOnly? Data { get; set; }

    public string? Coo { get; set; }

    public decimal? ValorVenda { get; set; }
}
