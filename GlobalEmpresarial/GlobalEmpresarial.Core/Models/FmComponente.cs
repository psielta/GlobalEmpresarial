using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmComponente
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdProduto { get; set; }

    public string? UnidadePeso { get; set; }

    public string? UnidadeVolume { get; set; }

    public decimal? Densidade { get; set; }

    public decimal? Diluicao { get; set; }

    public decimal? PesoMolarBase { get; set; }

    public decimal? PesoMolarSal { get; set; }

    public decimal? FatorCorrecao { get; set; }

    public decimal? DosagemMaxima { get; set; }

    public decimal? DosagemMinima { get; set; }

    public decimal? UiMg { get; set; }

    public string? Excluido { get; set; }

    public virtual ICollection<FmFormaTamDosComponenteFk> FmFormaTamDosComponenteFks { get; set; } = new List<FmFormaTamDosComponenteFk>();

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
