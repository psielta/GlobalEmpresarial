using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SerieKitItensOrcamento
{
    public int Id { get; set; }

    public string IdSerie { get; set; } = null!;

    public int IdKit { get; set; }

    public int IdProdKit { get; set; }

    public int IdProdutoPai { get; set; }

    public string? SeriePrinc { get; set; }

    public string? SerieCor { get; set; }

    public string? SerieAcess { get; set; }
}
