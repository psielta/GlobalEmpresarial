using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Cest
{
    public string NrCest { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<CestNcm> CestNcms { get; set; } = new List<CestNcm>();
}
