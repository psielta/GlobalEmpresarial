using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdutosForn
{
    public int CdProduto { get; set; }

    public int CdForn { get; set; }

    public string? IdProdutoExterno { get; set; }

    public string? CdBarra { get; set; }

    public virtual Fornecedor CdFornNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
