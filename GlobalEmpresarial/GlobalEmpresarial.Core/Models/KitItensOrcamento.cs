using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class KitItensOrcamento
{
    public int Id { get; set; }

    public int IdItemOs { get; set; }

    public int IdKit { get; set; }

    public int IdProdKit { get; set; }

    public decimal Valor { get; set; }

    public decimal Qtde { get; set; }

    public int IdProdutoPai { get; set; }

    public string? Somado { get; set; }

    public string? IdSerieKitOrc { get; set; }

    public string? NmProduto { get; set; }

    public int? CdProduto { get; set; }

    public string? NmKit { get; set; }

    public int? Sequencia { get; set; }

    public virtual ItensOrcamento IdItemOsNavigation { get; set; } = null!;
}
