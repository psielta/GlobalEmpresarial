using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmMedicamento
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdProduto { get; set; }

    public char? ControleEspecial { get; set; }

    public string? Obs { get; set; }

    public string? Tipo { get; set; }

    public decimal? Densidade { get; set; }

    public int? Diluicao { get; set; }

    public decimal? UiMg { get; set; }

    public decimal? FatorCorrecao { get; set; }

    public decimal? DosagemMinima { get; set; }

    public decimal? DosagemMaxima { get; set; }

    public virtual ICollection<FmMedContraindicaco> FmMedContraindicacos { get; set; } = new List<FmMedContraindicaco>();

    public virtual ICollection<FmMedicamentoFfarmaceuticaFk> FmMedicamentoFfarmaceuticaFks { get; set; } = new List<FmMedicamentoFfarmaceuticaFk>();

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
