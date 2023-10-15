using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PagtosParciaisCr
{
    public int Id { get; set; }

    public int? NrConta { get; set; }

    public DateOnly? DtPagto { get; set; }

    public decimal? ValorPago { get; set; }

    public decimal? ValorRestante { get; set; }
}
