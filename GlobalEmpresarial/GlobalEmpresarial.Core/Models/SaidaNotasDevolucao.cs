using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SaidaNotasDevolucao
{
    public int Id { get; set; }

    public string? NrNfEntradaDevolucao { get; set; }

    public string? NrNfSaida { get; set; }

    public string? TpNota { get; set; }
}
