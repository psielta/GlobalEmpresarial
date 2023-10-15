using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Vendedor
{
    public int CdFuncionario { get; set; }

    public decimal? ComissaoAPrazo { get; set; }

    public decimal? ComissaoAVista { get; set; }

    public string? TipoPagamento { get; set; }

    public virtual Funcionario CdFuncionarioNavigation { get; set; } = null!;
}
