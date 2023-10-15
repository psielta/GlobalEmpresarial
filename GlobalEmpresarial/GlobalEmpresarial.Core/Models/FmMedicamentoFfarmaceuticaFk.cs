using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmMedicamentoFfarmaceuticaFk
{
    public int Id { get; set; }

    public int IdMedicamento { get; set; }

    public int IdFormaFarmaceutica { get; set; }

    public DateOnly? DataValidade { get; set; }

    public string? Observacao { get; set; }

    public string? Ph { get; set; }

    public int? DiasValidade { get; set; }

    public virtual FmFormaFarmaceutica IdFormaFarmaceuticaNavigation { get; set; } = null!;

    public virtual FmMedicamento IdMedicamentoNavigation { get; set; } = null!;
}
