using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ItensVendaControlado
{
    public int Nr { get; set; }

    public int NrCab { get; set; }

    public int CdProduto { get; set; }

    public DateOnly? DtValidade { get; set; }

    public string Lote { get; set; } = null!;

    public decimal Quant { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlTotal { get; set; }

    public string Unidade { get; set; } = null!;

    public string UsoProlongado { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual CabVendaControlado NrCabNavigation { get; set; } = null!;
}
