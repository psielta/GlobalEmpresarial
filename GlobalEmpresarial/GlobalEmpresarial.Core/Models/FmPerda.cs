using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmPerda
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public int? Idproduto { get; set; }

    public decimal? Quant { get; set; }

    public string? Lote { get; set; }

    public string? Motivo { get; set; }
}
