using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class OsDevolucao
{
    public int Id { get; set; }

    public int IdOs { get; set; }

    public DateOnly? Data { get; set; }

    public int IdUsuario { get; set; }

    public int IdItem { get; set; }

    public int IdProduto { get; set; }

    public string NmProduto { get; set; } = null!;

    public decimal Qtde { get; set; }

    public decimal QtdeRetorno { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal VlDesconto { get; set; }

    public decimal VlTotal { get; set; }

    public string CdBarra { get; set; } = null!;

    public string CdUni { get; set; } = null!;

    public string CdClassFiscal { get; set; } = null!;

    public string Status { get; set; } = null!;

    public virtual Orcamento IdOsNavigation { get; set; } = null!;
}
