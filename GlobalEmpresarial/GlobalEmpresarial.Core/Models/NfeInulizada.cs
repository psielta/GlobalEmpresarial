using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NfeInulizada
{
    public int Id { get; set; }

    public string? Ano { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? NumeroInicio { get; set; }

    public string? NumeroFim { get; set; }

    public string? Justificativa { get; set; }

    public DateOnly? DataInutilizacao { get; set; }
}
