using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class LogImportacao
{
    public int Id { get; set; }

    public DateOnly? DataImportacao { get; set; }

    public string? HoraImportacao { get; set; }

    public string? LogErro { get; set; }

    public string? Integrador { get; set; }
}
