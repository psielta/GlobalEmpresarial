using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public string? IdInterno { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly? DtNascimento { get; set; }
}
