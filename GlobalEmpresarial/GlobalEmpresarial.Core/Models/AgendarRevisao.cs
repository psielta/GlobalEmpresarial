using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class AgendarRevisao
{
    public int Nr { get; set; }

    public DateOnly? Data { get; set; }

    public DateOnly DtRetornar { get; set; }

    public DateOnly? DtRetorno { get; set; }

    public int NrAutomovel { get; set; }

    public string? TxtObs { get; set; }

    public int CdCliente { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Automovel NrAutomovelNavigation { get; set; } = null!;
}
