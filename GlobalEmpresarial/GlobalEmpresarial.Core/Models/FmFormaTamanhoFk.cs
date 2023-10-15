using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmFormaTamanhoFk
{
    public int Id { get; set; }

    public int IdMedicamentoForma { get; set; }

    public int IdTamanho { get; set; }

    public decimal? DosagemMin { get; set; }

    public decimal? DosagemMax { get; set; }

    public decimal? Peso { get; set; }

    public virtual ICollection<FmFormaTamDosComponenteFk> FmFormaTamDosComponenteFks { get; set; } = new List<FmFormaTamDosComponenteFk>();

    public virtual FmTamanhoFormaFarmaceutica IdTamanhoNavigation { get; set; } = null!;
}
