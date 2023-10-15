using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class GrupoEstoque
{
    public int CdGrupo { get; set; }

    public string NmGrupo { get; set; } = null!;

    public string? Comanda { get; set; }

    public int? NrOrdem { get; set; }

    public string? Tipo { get; set; }

    public string? Pizza { get; set; }

    public string? Acai { get; set; }

    public virtual ICollection<ProdutoEstoque> ProdutoEstoques { get; set; } = new List<ProdutoEstoque>();
}
