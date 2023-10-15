using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmEmbalagem
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public string? Descricao { get; set; }

    public int? IdEmbAuxiliar { get; set; }

    public int? IdEmbAuxiliar2 { get; set; }

    public int? IdEmbAuxiliar3 { get; set; }

    public virtual ICollection<FmEmbalagemRelacao> FmEmbalagemRelacaos { get; set; } = new List<FmEmbalagemRelacao>();

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
