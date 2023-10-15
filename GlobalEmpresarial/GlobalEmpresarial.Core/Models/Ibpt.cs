using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Ibpt
{
    public int NrLanc { get; set; }

    public string Codigo { get; set; } = null!;

    public string? Ex { get; set; }

    public string? Tabela { get; set; }

    public decimal? Aliqnac { get; set; }

    public decimal? Aliqimp { get; set; }

    public string? Descricao { get; set; }

    public decimal? Aliqestadual { get; set; }

    public decimal? Aliqmunicipal { get; set; }
}
