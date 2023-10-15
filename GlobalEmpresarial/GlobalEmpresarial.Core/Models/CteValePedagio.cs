using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteValePedagio
{
    public int Codigo { get; set; }

    public string CnpjFornecedora { get; set; } = null!;

    public string? CnpjResponsavel { get; set; }

    public string NrComprovante { get; set; } = null!;

    public decimal Valor { get; set; }

    public int NrCte { get; set; }
}
