using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MaterialTerraplenagem
{
    public int NrLanc { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<ItensApontamentoCaminhao> ItensApontamentoCaminhaos { get; set; } = new List<ItensApontamentoCaminhao>();
}
