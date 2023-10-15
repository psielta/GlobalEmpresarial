using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ChequeProprio
{
    public int NrLanc { get; set; }

    public int CdConta { get; set; }

    public DateOnly? Data { get; set; }

    public string NrChequeInicial { get; set; } = null!;

    public string NrChequeFinal { get; set; } = null!;

    public string? NrChequeAtual { get; set; }

    public string? Ativo { get; set; }
}
