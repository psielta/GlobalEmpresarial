using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ControleUsuario
{
    public int NrControle { get; set; }

    public DateTime? DtHr { get; set; }

    public string TpAcao { get; set; } = null!;

    public string NmUsuario { get; set; } = null!;

    public string? TxtAcao { get; set; }

    public string? Tabela { get; set; }

    public virtual Usuario NmUsuarioNavigation { get; set; } = null!;
}
