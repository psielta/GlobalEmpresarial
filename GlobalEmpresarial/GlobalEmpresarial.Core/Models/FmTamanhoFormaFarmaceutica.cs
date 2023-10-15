using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmTamanhoFormaFarmaceutica
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal? Peso { get; set; }

    public int? DosagemMin { get; set; }

    public int? DosagemMax { get; set; }

    public string? Excluido { get; set; }

    public virtual ICollection<FmEmbalagemRelacao> FmEmbalagemRelacaos { get; set; } = new List<FmEmbalagemRelacao>();

    public virtual ICollection<FmFormaTamanhoFk> FmFormaTamanhoFks { get; set; } = new List<FmFormaTamanhoFk>();
}
