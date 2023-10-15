using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VProdutosFornecedorEntradum
{
    public int? CdForn { get; set; }

    public string? NmForn { get; set; }

    public int? CdProduto { get; set; }

    public string? NmProduto { get; set; }

    public decimal? Quant { get; set; }

    public string? Tipo { get; set; }

    public DateOnly? Data { get; set; }

    public int? CdEmpresa { get; set; }

    public int? CdGrupoEstoque { get; set; }
}
