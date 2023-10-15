using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class R07
{
    public int Id { get; set; }

    public int? IdR06 { get; set; }

    public int? Ccf { get; set; }

    public string? MeioPagamento { get; set; }

    public decimal? ValorPagamento { get; set; }

    public string? Estorno { get; set; }

    public decimal? ValorEstorno { get; set; }

    public string? Sincronizado { get; set; }

    public virtual R06? IdR06Navigation { get; set; }
}
