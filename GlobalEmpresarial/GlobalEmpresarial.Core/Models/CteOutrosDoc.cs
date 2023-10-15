using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteOutrosDoc
{
    public int Codigo { get; set; }

    public string TpDocumento { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? Numero { get; set; }

    public DateOnly DtEmissao { get; set; }

    public DateOnly? DtPrevista { get; set; }

    public decimal? VlDocumento { get; set; }

    public string? TpUnidade { get; set; }

    public int NrCte { get; set; }
}
