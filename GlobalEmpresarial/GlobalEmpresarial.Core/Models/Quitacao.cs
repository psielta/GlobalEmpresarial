using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Quitacao
{
    public int Id { get; set; }

    public string? Codclie { get; set; }

    public DateOnly? Compra { get; set; }

    public DateOnly? Vencimento { get; set; }

    public decimal? Valor { get; set; }

    public string? Quitado { get; set; }

    public decimal? Valorq { get; set; }

    public string? Operador { get; set; }

    public decimal? Dataq { get; set; }

    public string? Integrador { get; set; }
}
