using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComandaPerda
{
    public int Id { get; set; }

    public int? IdProduto { get; set; }

    public DateOnly? Data { get; set; }

    public decimal? Quant { get; set; }

    public string? Observacao { get; set; }
}
