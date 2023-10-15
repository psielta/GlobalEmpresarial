using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class AlteracaoPrecoPdv
{
    public int Caixa { get; set; }

    public string MacAddress { get; set; } = null!;

    public int? NrItem { get; set; }

    public string? CdProduto { get; set; }

    public string? Nome { get; set; }

    public decimal? VlAntigo { get; set; }

    public decimal? VlNovo { get; set; }
}
