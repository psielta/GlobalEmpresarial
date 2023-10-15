using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteRodMotoristum
{
    public int Codigo { get; set; }

    public string Cpf { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public int NrCte { get; set; }
}
