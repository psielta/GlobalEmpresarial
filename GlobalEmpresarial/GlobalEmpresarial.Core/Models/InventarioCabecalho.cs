using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class InventarioCabecalho
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public string? Descricao { get; set; }

    public int? CdPlano { get; set; }
}
