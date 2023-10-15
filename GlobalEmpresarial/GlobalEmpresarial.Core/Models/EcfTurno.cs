using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfTurno
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public string? HoraInicio { get; set; }

    public string? HoraFim { get; set; }

    public string? Integrador { get; set; }
}
