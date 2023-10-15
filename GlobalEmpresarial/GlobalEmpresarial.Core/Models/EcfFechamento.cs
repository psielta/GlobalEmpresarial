using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfFechamento
{
    public int Id { get; set; }

    public int IdEcfMovimento { get; set; }

    public string? TipoPagamento { get; set; }

    public decimal? Valor { get; set; }

    public string? Sincronizado { get; set; }

    public string? Integrador { get; set; }
}
