using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmFormaFarmaceutica
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int IdProduto { get; set; }

    public int? DiasValidade { get; set; }

    public decimal? Peso { get; set; }

    public string? QtdeOm { get; set; }

    public string? Uso { get; set; }

    public virtual ICollection<FmEmbalagemRelacao> FmEmbalagemRelacaos { get; set; } = new List<FmEmbalagemRelacao>();

    public virtual ICollection<FmMedicamentoFfarmaceuticaFk> FmMedicamentoFfarmaceuticaFks { get; set; } = new List<FmMedicamentoFfarmaceuticaFk>();

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
