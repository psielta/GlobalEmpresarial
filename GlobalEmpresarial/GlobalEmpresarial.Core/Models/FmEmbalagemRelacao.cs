using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmEmbalagemRelacao
{
    public int Id { get; set; }

    public int IdEmbalagem { get; set; }

    public int IdFormaFarmaceutica { get; set; }

    public int IdTamanho { get; set; }

    public decimal QtdMinima { get; set; }

    public decimal QtdMaxima { get; set; }

    public virtual FmEmbalagem IdEmbalagemNavigation { get; set; } = null!;

    public virtual FmFormaFarmaceutica IdFormaFarmaceuticaNavigation { get; set; } = null!;

    public virtual FmTamanhoFormaFarmaceutica IdTamanhoNavigation { get; set; } = null!;
}
