using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfCaixa
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public DateOnly? DataCadastro { get; set; }

    public string? Integrador { get; set; }
}
