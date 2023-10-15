using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Diverso
{
    public int CdDiv { get; set; }

    public string NmDiv { get; set; } = null!;

    public string CdTipo { get; set; } = null!;

    public string CdChave { get; set; } = null!;

    public string? CdHistorico { get; set; }

    public int? NrConta { get; set; }

    public string? CdPlanoCaixa { get; set; }

    public int? CdPlanoEstoque { get; set; }

    public string? Observacao { get; set; }
}
