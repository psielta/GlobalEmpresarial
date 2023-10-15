using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Sangrium
{
    public int NrLanc { get; set; }

    public DateOnly Data { get; set; }

    public string NrCaixa { get; set; } = null!;

    public TimeOnly Hora { get; set; }

    public int CdOperador { get; set; }

    public decimal Valor { get; set; }
}
