using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComposicaoKitProduto
{
    public int IdProduto { get; set; }

    public int IdKit { get; set; }

    public int? Sequencia { get; set; }

    public virtual KitProduto IdKitNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
