using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdutosSaidaModelo2
{
    public int Id { get; set; }

    public int? IdProduto { get; set; }

    public int? IdSaidaM2 { get; set; }

    public decimal? Qtd { get; set; }

    public decimal? VlBrutoProduto { get; set; }

    public decimal? BaseCalculoIcms { get; set; }

    public decimal? AliquotaProduto { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? VlIcms { get; set; }
}
