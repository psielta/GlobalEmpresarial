using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Parceiro
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string? CnpjCpf { get; set; }

    public string? Endereco { get; set; }

    public short? Numero { get; set; }

    public string? Bairro { get; set; }

    public string CdCidade { get; set; } = null!;

    public string? Cep { get; set; }

    public string? Telefone { get; set; }

    public string? Celular { get; set; }

    public DateOnly? DtCadastro { get; set; }

    public string Ativo { get; set; } = null!;

    public string? DiaPagt { get; set; }

    public string? NumeroAgencia { get; set; }

    public string? NumeroBanco { get; set; }

    public string? NumeroConta { get; set; }

    public virtual Cidade CdCidadeNavigation { get; set; } = null!;
}
