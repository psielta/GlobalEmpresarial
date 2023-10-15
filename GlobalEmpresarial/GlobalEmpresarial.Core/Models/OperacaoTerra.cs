using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class OperacaoTerra
{
    public int NrLanc { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<ApontamentoMaquina> ApontamentoMaquinas { get; set; } = new List<ApontamentoMaquina>();
}
