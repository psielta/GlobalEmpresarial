using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CadTpAvalfisica
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<AvaliacaoFisica> AvaliacaoFisicas { get; set; } = new List<AvaliacaoFisica>();
}
