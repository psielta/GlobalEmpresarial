using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CabCotacaoPreco
{
    public int NrLanc { get; set; }

    public DateOnly Data { get; set; }

    public int CdProduto { get; set; }

    public string Nome { get; set; } = null!;

    public string? TxtObs { get; set; }

    public decimal Quant { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual ICollection<ItensCotacaoPreco> ItensCotacaoPrecos { get; set; } = new List<ItensCotacaoPreco>();
}
