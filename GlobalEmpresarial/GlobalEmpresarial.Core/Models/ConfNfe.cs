using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ConfNfe
{
    public int NrLanc { get; set; }

    public string SerialCertificado { get; set; } = null!;

    public string? EMailContador { get; set; }

    public int CdEmpresa { get; set; }

    public string? Senha { get; set; }

    public string? CaminhoCertificado { get; set; }

    public string? TpCertificado { get; set; }

    public DateOnly? ValidadeCert { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;
}
