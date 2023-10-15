using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdutoTransferencium
{
    public int Nr { get; set; }

    public int NrTransf { get; set; }

    public string Tranferiu { get; set; } = null!;

    public int CdProduto { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValid { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal Quant { get; set; }

    public decimal? QuantRetorno { get; set; }

    public decimal? QuantVendido { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual TransferenciaEstoque NrTransfNavigation { get; set; } = null!;
}
