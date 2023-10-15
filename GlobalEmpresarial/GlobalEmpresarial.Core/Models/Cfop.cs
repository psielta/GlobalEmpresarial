using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Cfop
{
    public string CdCfop { get; set; } = null!;

    public string? Descricao { get; set; }

    public string? TipoCfop { get; set; }

    public string? DescNfe { get; set; }

    public virtual ICollection<CfopContaSpeed> CfopContaSpeeds { get; set; } = new List<CfopContaSpeed>();

    public virtual ICollection<CfopSaidum> CfopSaida { get; set; } = new List<CfopSaidum>();

    public virtual ICollection<IcmsCsosn> Csosns { get; set; } = new List<IcmsCsosn>();

    public virtual ICollection<Cst> Csts { get; set; } = new List<Cst>();
}
