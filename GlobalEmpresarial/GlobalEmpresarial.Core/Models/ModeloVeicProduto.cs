using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ModeloVeicProduto
{
    public int CdProduto { get; set; }

    public int CdMarca { get; set; }

    public int CdModelo { get; set; }

    public virtual MarcaAutomovel CdMarcaNavigation { get; set; } = null!;

    public virtual ModeloAutomovel CdModeloNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
