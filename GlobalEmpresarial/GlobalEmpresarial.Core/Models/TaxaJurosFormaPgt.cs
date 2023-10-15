using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TaxaJurosFormaPgt
{
    public int Id { get; set; }

    public string IdFormaPgt { get; set; } = null!;

    public decimal? Taxa { get; set; }
}
