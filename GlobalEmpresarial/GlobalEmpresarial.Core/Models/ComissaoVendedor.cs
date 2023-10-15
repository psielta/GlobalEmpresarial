using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComissaoVendedor
{
    public int NrLanc { get; set; }

    public DateOnly Data { get; set; }

    public int CdVendedor { get; set; }

    public decimal VlComissao { get; set; }

    public string Pagou { get; set; } = null!;

    public int? NrCr { get; set; }

    public int? NrSaida { get; set; }

    public int? NrItemSaida { get; set; }

    public int? NrOr { get; set; }

    public DateOnly? DtPagou { get; set; }

    public virtual Funcionario CdVendedorNavigation { get; set; } = null!;
}
