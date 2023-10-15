using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdAdcAcai
{
    public int IdProduto { get; set; }

    public int IdTpAdc { get; set; }

    public decimal Valor { get; set; }

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;

    public virtual TpAdcAcai IdTpAdcNavigation { get; set; } = null!;
}
