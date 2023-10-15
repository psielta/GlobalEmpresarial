using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SangriaCaixa
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Hora { get; set; }

    public int IdUsuario { get; set; }

    public int IdAberturaCaixa { get; set; }

    public int IdCaixa { get; set; }

    public decimal Valor { get; set; }

    public string? Tipo { get; set; }
}
