using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VendaMobileDetalhe
{
    public int Id { get; set; }

    public int IdCabecalho { get; set; }

    public int IdProduto { get; set; }

    public decimal Qtde { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlTotal { get; set; }

    public string? TxtObsProduto { get; set; }

    public int IdCabMobile { get; set; }

    public string? TipoValor { get; set; }

    public virtual VendaMobileCab IdCabecalhoNavigation { get; set; } = null!;
}
