using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SpedPlanoConta
{
    public int Id { get; set; }

    public DateOnly? DtAlt { get; set; }

    public string? CodNatCc { get; set; }

    public string? IndCta { get; set; }

    public string? Nivel { get; set; }

    public string? CodCta { get; set; }

    public string? NomeCta { get; set; }

    public string? CodCtaRef { get; set; }

    public string? CnpjEst { get; set; }

    public string? Tipo { get; set; }
}
