using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FichaTecnica
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public string? Descricao { get; set; }

    public int? IdProdutoFilho { get; set; }

    public decimal? Quantidade { get; set; }

    public string? Integrador { get; set; }
}
