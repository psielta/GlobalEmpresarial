using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmComplexo
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int? IdForma { get; set; }

    public int? IdTamanho { get; set; }

    public decimal? Quantidade { get; set; }

    public int? IdEmbalagem { get; set; }

    public string? Posologia { get; set; }
}
