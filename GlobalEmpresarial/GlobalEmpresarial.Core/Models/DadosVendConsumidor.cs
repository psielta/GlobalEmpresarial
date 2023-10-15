using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DadosVendConsumidor
{
    public int NrLanc { get; set; }

    public int NrCab { get; set; }

    public int CdProduto { get; set; }

    public decimal Quant { get; set; }

    public decimal VlUnit { get; set; }

    public decimal VlTotal { get; set; }

    public DateOnly? DtValidade { get; set; }

    public string? Lote { get; set; }

    public string? Cancelada { get; set; }

    public decimal? VlAproxImposto { get; set; }

    public decimal? PorcIbpt { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual VendaConsumidorCab NrCabNavigation { get; set; } = null!;
}
