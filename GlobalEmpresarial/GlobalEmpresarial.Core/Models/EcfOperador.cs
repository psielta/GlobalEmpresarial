using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfOperador
{
    public int Id { get; set; }

    public int? IdEcfFuncionario { get; set; }

    public string? Login { get; set; }

    public string? Senha { get; set; }

    public string? Integrador { get; set; }
}
