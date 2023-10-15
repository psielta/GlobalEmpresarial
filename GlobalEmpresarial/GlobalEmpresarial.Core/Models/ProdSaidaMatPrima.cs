using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdSaidaMatPrima
{
    public int Nr { get; set; }

    public int NrSaida { get; set; }

    public int CdProduto { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValid { get; set; }

    public decimal Quant { get; set; }

    public decimal VlUnit { get; set; }

    public decimal VlTotal { get; set; }

    public string Transferiu { get; set; } = null!;
}
