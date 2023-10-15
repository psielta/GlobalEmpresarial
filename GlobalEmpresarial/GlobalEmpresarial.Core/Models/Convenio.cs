using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Convenio
{
    public int CdConvenio { get; set; }

    public string? NmConvenio { get; set; }

    public string? RazaoSocial { get; set; }

    public string? NrTelefone { get; set; }

    public decimal? Desconto { get; set; }

    public string? Email { get; set; }
}
