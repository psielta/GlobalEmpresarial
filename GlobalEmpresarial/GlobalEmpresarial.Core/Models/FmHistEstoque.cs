using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmHistEstoque
{
    public int Id { get; set; }

    public int? IdProduto { get; set; }

    public DateOnly? DataMov { get; set; }

    public decimal? EstoqueInicial { get; set; }

    public string? Tipo { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? EstoqueFinal { get; set; }

    public string? Observacao { get; set; }
}
