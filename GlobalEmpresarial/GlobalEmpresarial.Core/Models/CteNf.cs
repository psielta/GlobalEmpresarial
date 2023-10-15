using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteNf
{
    public int Codigo { get; set; }

    public string Serie { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public DateOnly DtEmissao { get; set; }

    public string Cfop { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public string? NrRomaneioNf { get; set; }

    public string? NrPedidoNf { get; set; }

    public DateOnly? DtPrevista { get; set; }

    public decimal BcIcms { get; set; }

    public decimal VlIcms { get; set; }

    public decimal BcIcmsSt { get; set; }

    public decimal VlIcmsSt { get; set; }

    public decimal? Peso { get; set; }

    public int? Pin { get; set; }

    public decimal VlProd { get; set; }

    public decimal VlNota { get; set; }

    public string TpUnidade { get; set; } = null!;

    public int NrCte { get; set; }
}
