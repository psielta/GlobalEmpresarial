using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Contador
{
    public int Codigo { get; set; }

    public string CdCrc { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Cpf { get; set; }

    public string? Cnpj { get; set; }

    public string? End { get; set; }

    public int? Numero { get; set; }

    public string? Bairro { get; set; }

    public string CdCidade { get; set; } = null!;

    public string? Telefone { get; set; }

    public int CdEmpresa { get; set; }

    public string? Cep { get; set; }

    public string? EMail { get; set; }

    public string? TelFax { get; set; }

    public virtual Cidade CdCidadeNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;
}
