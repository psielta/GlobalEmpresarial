﻿using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VProdutosFornecedorSaidum
{
    public int? CdForn { get; set; }

    public string? NmForn { get; set; }

    public int? CdProduto { get; set; }

    public string? NmProduto { get; set; }

    public decimal? Quant { get; set; }

    public string? Tipo { get; set; }

    public DateOnly? Data { get; set; }

    public int? Empresa { get; set; }

    public int? CdPlano { get; set; }
}
