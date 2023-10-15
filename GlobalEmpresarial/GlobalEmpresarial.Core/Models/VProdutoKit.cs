using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VProdutoKit
{
    public int? NrKit { get; set; }

    public string? NmKit { get; set; }

    public int? CdProduto { get; set; }

    public string? NmProduto { get; set; }

    public decimal? VlAVista { get; set; }

    public decimal? Quant { get; set; }

    public int? IdKitProduto { get; set; }

    public int? IdProdutoPai { get; set; }

    public string? Obrigatorio { get; set; }

    public int? IdTipoKit { get; set; }

    public int? SeqComp { get; set; }

    public int? SeqKit { get; set; }

    public string? SelAutomatico { get; set; }
}
