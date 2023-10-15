using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class BcoBoleto
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string? Abrev { get; set; }

    public virtual ICollection<ConfBoleto> ConfBoletos { get; set; } = new List<ConfBoleto>();
}
