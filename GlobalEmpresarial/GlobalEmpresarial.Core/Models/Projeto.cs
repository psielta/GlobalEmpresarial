using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Projeto
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();
}
