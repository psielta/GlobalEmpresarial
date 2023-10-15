using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComposicaoProduto
{
    public int Id { get; set; }

    public int IdProdutoPrincipal { get; set; }

    public int IdProduto { get; set; }

    public decimal Quantidade { get; set; }

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoPrincipalNavigation { get; set; } = null!;

    public virtual ICollection<SubItensCompProduto> SubItensCompProdutos { get; set; } = new List<SubItensCompProduto>();
}
