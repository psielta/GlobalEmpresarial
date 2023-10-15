using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ConfIntegradorEcomerce
{
    public int Id { get; set; }

    public string IdTipoIntegrador { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public string Senha { get; set; } = null!;
}
