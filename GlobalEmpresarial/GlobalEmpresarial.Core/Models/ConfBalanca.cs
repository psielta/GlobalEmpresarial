using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ConfBalanca
{
    public int Id { get; set; }

    public string? ConfiguracaoBalanca { get; set; }

    public string? Modelo { get; set; }

    public int? Handshake { get; set; }

    public int? Parity { get; set; }

    public int? Stop { get; set; }

    public int? Data { get; set; }

    public int? Baud { get; set; }

    public string? Porta { get; set; }

    public int? Timeout { get; set; }

    public string? Monitorar { get; set; }

    public int? Caixa { get; set; }
}
