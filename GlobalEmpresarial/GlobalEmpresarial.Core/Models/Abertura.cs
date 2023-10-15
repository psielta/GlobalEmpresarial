using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Abertura
{
    public int NrLanc { get; set; }

    public DateOnly? DtLanc { get; set; }

    public TimeOnly? Hora { get; set; }

    public int? CdOperador { get; set; }

    public string? NrCaixa { get; set; }

    public decimal? Valor { get; set; }

    public string? TxtObs { get; set; }

    public string? Tipo { get; set; }

    public decimal? VlVendaBruta { get; set; }

    public int? Cro { get; set; }
}
