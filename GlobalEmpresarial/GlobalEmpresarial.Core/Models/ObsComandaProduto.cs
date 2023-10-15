using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ObsComandaProduto
{
    public int NrLanc { get; set; }

    public int CdProduto { get; set; }

    public string NmObs { get; set; } = null!;

    public string? TxtObs { get; set; }

    public decimal? VlAcrescimo { get; set; }

    public int? IdImp { get; set; }

    public string? Cor { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
