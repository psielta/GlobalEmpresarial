using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdKit
{
    public int NrLanc { get; set; }

    public int NrKit { get; set; }

    public int CdProduto { get; set; }

    public decimal Quant { get; set; }

    public int? Sequencia { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual KitProduto NrKitNavigation { get; set; } = null!;
}
