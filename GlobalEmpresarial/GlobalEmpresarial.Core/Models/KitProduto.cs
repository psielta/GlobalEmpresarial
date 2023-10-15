using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class KitProduto
{
    public int NrKit { get; set; }

    public string NmKit { get; set; } = null!;

    public string? Obrigatorio { get; set; }

    public int? IdTipoKit { get; set; }

    public string? SelAutomatico { get; set; }

    public virtual ICollection<ComposicaoKitProduto> ComposicaoKitProdutos { get; set; } = new List<ComposicaoKitProduto>();

    public virtual ICollection<ProdKit> ProdKits { get; set; } = new List<ProdKit>();
}
