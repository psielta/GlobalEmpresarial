using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CadEnderecoRetiradum
{
    public int Id { get; set; }

    public int? IdEmpresa { get; set; }

    public string? CpfCnpj { get; set; }

    public string? Descricao { get; set; }

    public string? Rua { get; set; }

    public string? Numero { get; set; }

    public string? Complemento { get; set; }

    public string? Bairro { get; set; }

    public string? CodigoCidade { get; set; }

    public string? NomeCidade { get; set; }

    public string? Uf { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public string? InscricaoEstadual { get; set; }

    public string? Cep { get; set; }
}
