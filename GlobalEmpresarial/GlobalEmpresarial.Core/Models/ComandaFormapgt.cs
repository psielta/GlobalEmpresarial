using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComandaFormapgt
{
    public int Id { get; set; }

    public int? IdVr { get; set; }

    public string? Forma { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Troco { get; set; }
}
