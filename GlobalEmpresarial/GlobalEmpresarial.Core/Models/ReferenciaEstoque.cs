using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ReferenciaEstoque
{
    public int CdRef { get; set; }

    public string NmRef { get; set; } = null!;

    public string? Color { get; set; }

    public string? Controlado { get; set; }

    public virtual ICollection<ProdutoEstoque> ProdutoEstoques { get; set; } = new List<ProdutoEstoque>();
}
