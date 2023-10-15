using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ConfEmailNfe
{
    public int NrLanc { get; set; }

    public int CdEmpresa { get; set; }

    public string? EMailCopia { get; set; }

    public string? AssuntoEmail { get; set; }

    public string Smtp { get; set; } = null!;

    public string Porta { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string? ConexaoSegura { get; set; }

    public string? TxtPadrao { get; set; }

    public string? Ssl { get; set; }

    public string? Tsl { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;
}
