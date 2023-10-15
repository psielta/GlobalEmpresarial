using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Aluguel
{
    public int Nr { get; set; }

    public string Controla { get; set; } = null!;

    public string DtInicio { get; set; } = null!;

    public string DtFim { get; set; } = null!;

    public string NrControle { get; set; } = null!;

    public byte[]? Arquivo { get; set; }

    public string Data { get; set; } = null!;
}
