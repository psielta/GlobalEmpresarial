using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TpAdcAcai
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int QtdAdcGratis { get; set; }

    public string? Cor { get; set; }

    public virtual ICollection<ProdAdcAcai> ProdAdcAcais { get; set; } = new List<ProdAdcAcai>();
}
