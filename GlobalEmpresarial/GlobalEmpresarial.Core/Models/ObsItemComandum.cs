using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ObsItemComandum
{
    public int NrLanc { get; set; }

    public int NrComanda { get; set; }

    public int CdProduto { get; set; }

    public int? CdObs { get; set; }

    public string? TxtObs { get; set; }

    public int? NrItemComanda { get; set; }

    public decimal? VlAcrescimo { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual ComandaCabecalho NrComandaNavigation { get; set; } = null!;
}
