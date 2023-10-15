using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteProdPerigoso
{
    public int Codigo { get; set; }

    public int? ClasseRisco { get; set; }

    public int NrOnu { get; set; }

    public string? GrupoEmbalagem { get; set; }

    public string? PontoFulgor { get; set; }

    public string NmEmbarqueProd { get; set; } = null!;

    public decimal QtdTotalProd { get; set; }

    public string? QtdTipoVolume { get; set; }

    public int NrCte { get; set; }
}
