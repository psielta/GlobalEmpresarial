using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Fornecedor
{
    public int CdForn { get; set; }

    public string NmForn { get; set; } = null!;

    public string? NmEndereco { get; set; }

    public int? Numero { get; set; }

    public string CdCidade { get; set; } = null!;

    public string? CdCep { get; set; }

    public string? NmRepresentante { get; set; }

    public string? TelefoneEmpresa { get; set; }

    public string? TelefoneRepresentante { get; set; }

    public string? Cnpj { get; set; }

    public string? Bairro { get; set; }

    public string? Ramo { get; set; }

    public string? Email { get; set; }

    public string? NrInscrEstadual { get; set; }

    public string? Parceiro { get; set; }

    public string? NmFantasia { get; set; }

    public string? Complemento { get; set; }

    public int? IdCliente { get; set; }

    public string? Cpf { get; set; }

    public virtual ICollection<ContasAPagar> ContasAPagars { get; set; } = new List<ContasAPagar>();

    public virtual ICollection<DadosBancFornecedor> DadosBancFornecedors { get; set; } = new List<DadosBancFornecedor>();

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<EntradaOutrasDesp> EntradaOutrasDesps { get; set; } = new List<EntradaOutrasDesp>();

    public virtual ICollection<ItensCotacaoPreco> ItensCotacaoPrecos { get; set; } = new List<ItensCotacaoPreco>();
}
