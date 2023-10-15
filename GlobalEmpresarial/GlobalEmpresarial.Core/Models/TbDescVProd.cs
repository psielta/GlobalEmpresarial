using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TbDescVProd
{
    public int NrLanc { get; set; }

    public int CdProduto { get; set; }

    public decimal PorcInicial { get; set; }

    public decimal PorcFinal { get; set; }

    public decimal PorcComissao { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
