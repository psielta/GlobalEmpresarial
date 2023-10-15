using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteQtdCarga
{
    public int Codigo { get; set; }

    public string UnMedida { get; set; } = null!;

    public string TpMedida { get; set; } = null!;

    public decimal Qtd { get; set; }

    public int NrCte { get; set; }
}
