using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfSuprimento
{
    public int Id { get; set; }

    public int IdEcfMovimento { get; set; }

    public DateOnly? DataSuprimento { get; set; }

    public decimal? Valor { get; set; }

    public string? Sincronizado { get; set; }

    public string? Integrador { get; set; }
}
