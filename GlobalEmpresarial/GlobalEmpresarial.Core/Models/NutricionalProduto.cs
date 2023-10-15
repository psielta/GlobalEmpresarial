using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NutricionalProduto
{
    public int CdProduto { get; set; }

    public int? TpUnidPorcao { get; set; }

    public int? ParteDecimal { get; set; }

    public int? MedCaseira { get; set; }

    public decimal? Valorenergetico { get; set; }

    public decimal? Carboidrato { get; set; }

    public decimal? Proteina { get; set; }

    public decimal? Gorduratotal { get; set; }

    public decimal? Gordurasaturada { get; set; }

    public decimal? Gorduratrans { get; set; }

    public decimal? Fibra { get; set; }

    public decimal? Sodio { get; set; }

    public decimal? Qtde { get; set; }
}
