using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MenuUsuario
{
    public string NmUsuario { get; set; } = null!;

    public int NrMenu { get; set; }

    public string Incluir { get; set; } = null!;

    public string Alterar { get; set; } = null!;

    public string Excluir { get; set; } = null!;

    public virtual Usuario NmUsuarioNavigation { get; set; } = null!;

    public virtual MenuSistema NrMenuNavigation { get; set; } = null!;
}
