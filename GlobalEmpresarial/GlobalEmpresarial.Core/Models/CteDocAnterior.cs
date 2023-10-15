using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteDocAnterior
{
    public int Codigo { get; set; }

    public string TpDocumento { get; set; } = null!;

    public string? Cpf { get; set; }

    public string? Cnpj { get; set; }

    public string? InscEstadual { get; set; }

    public string? Uf { get; set; }

    public string Nome { get; set; } = null!;

    public int NrCte { get; set; }

    public virtual ICollection<CteDocAnteriorNfe> CteDocAnteriorNves { get; set; } = new List<CteDocAnteriorNfe>();
}
