using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdEntrMatAcabado
{
    public int Nr { get; set; }

    public int NrSaida { get; set; }

    public int CdProduto { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValid { get; set; }

    public decimal Quant { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlTotal { get; set; }

    public int CdForn { get; set; }

    public string Transferiu { get; set; } = null!;

    public int CdGrupoEntrada { get; set; }

    public virtual PlanoEstoque CdGrupoEntradaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
