using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class WebServNfe
{
    public int NrLanc { get; set; }

    public string Uf { get; set; } = null!;

    public string TpAmbiente { get; set; } = null!;

    public string? ProxHost { get; set; }

    public string? ProxPorta { get; set; }

    public string? ProxUser { get; set; }

    public string? ProxSenha { get; set; }
}
