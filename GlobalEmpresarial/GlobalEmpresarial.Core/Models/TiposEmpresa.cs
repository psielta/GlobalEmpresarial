using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TiposEmpresa
{
    public int CdTipo { get; set; }

    public string Descricao { get; set; } = null!;

    public string Chave { get; set; } = null!;
}
