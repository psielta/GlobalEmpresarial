using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ContagemPrMobile
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public decimal Quant { get; set; }

    public string Conferido { get; set; } = null!;

    public int IdCab { get; set; }

    public virtual CabContagemEstMobile IdCabNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
