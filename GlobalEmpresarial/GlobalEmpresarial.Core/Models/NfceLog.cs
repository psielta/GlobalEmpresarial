using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NfceLog
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public int? Nfce { get; set; }

    public string? Evento { get; set; }

    public int? Serie { get; set; }
}
