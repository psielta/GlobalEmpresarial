using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Ncm
{
    public int Id { get; set; }

    public string? Ncm1 { get; set; }

    public DateOnly? DtVigencia { get; set; }

    public string? Unidade { get; set; }

    public string? Descricao { get; set; }
}
