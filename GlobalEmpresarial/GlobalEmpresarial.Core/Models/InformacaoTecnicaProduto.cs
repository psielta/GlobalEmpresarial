using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class InformacaoTecnicaProduto
{
    public int IdProduto { get; set; }

    public int IdInfTecnica { get; set; }

    public string Texto { get; set; } = null!;

    public virtual TipoInformacaoTecProd IdInfTecnicaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
