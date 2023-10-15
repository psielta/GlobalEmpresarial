using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Sintegra60a
{
    public int Id { get; set; }

    public int IdSintegra60m { get; set; }

    public string? SituacaoTributaria { get; set; }

    public decimal? Valor { get; set; }

    public string NumeroSerieEcf { get; set; } = null!;
}
