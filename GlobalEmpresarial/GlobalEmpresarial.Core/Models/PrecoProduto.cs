using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PrecoProduto
{
    public int Id { get; set; }

    public int? IdTabela { get; set; }

    public int? IdProduto { get; set; }

    public decimal? Preco { get; set; }

    public virtual TabelaPreco? IdTabelaNavigation { get; set; }
}
