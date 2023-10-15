using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SaidaMateriaPrima
{
    public int NrSaida { get; set; }

    public DateOnly? DtSaida { get; set; }

    public int? CdEmpresa { get; set; }

    public TimeOnly? Hora { get; set; }

    public int CdGrupo { get; set; }

    public string Transferiu { get; set; } = null!;

    public virtual Empresa? CdEmpresaNavigation { get; set; }
}
