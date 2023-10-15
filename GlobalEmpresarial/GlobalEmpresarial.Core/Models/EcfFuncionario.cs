using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfFuncionario
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public string? Telefone { get; set; }

    public string? Celular { get; set; }

    public string? Email { get; set; }

    public decimal? ComissaoVista { get; set; }

    public decimal? ComissaoPrazo { get; set; }

    public string? NivelAutorizacao { get; set; }

    public string? Integrador { get; set; }
}
