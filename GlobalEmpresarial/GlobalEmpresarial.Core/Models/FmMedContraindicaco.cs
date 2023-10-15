using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmMedContraindicaco
{
    public int Id { get; set; }

    public int IdMedicamento { get; set; }

    public int? IdEspecie { get; set; }

    public int? IdRaca { get; set; }

    public virtual FmEspecie? IdEspecieNavigation { get; set; }

    public virtual FmMedicamento IdMedicamentoNavigation { get; set; } = null!;
}
