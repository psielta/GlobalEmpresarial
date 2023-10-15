using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CredenciadoraCartao
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public string? Cnpj { get; set; }
}
