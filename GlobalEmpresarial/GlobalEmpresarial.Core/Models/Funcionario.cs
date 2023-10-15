using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Funcionario
{
    public int CdFuncionario { get; set; }

    public string NmFuncionario { get; set; } = null!;

    public DateOnly? DtNascimento { get; set; }

    public string? Endereco { get; set; }

    public int? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? NrTelefone { get; set; }

    public string? NrTelefone2 { get; set; }

    public string? NrCpf { get; set; }

    public string? NrRg { get; set; }

    public string? Sexo { get; set; }

    public string? EstadoCivil { get; set; }

    public DateOnly DtAdmissao { get; set; }

    public int CdEmpresa { get; set; }

    public string Cargo { get; set; } = null!;

    public decimal Salario { get; set; }

    public string? Cep { get; set; }

    public string? CdCbo { get; set; }

    public string? Mecanico { get; set; }

    public string? Vendedor { get; set; }

    public string? Ativo { get; set; }

    public string? CdInterno { get; set; }

    public string? Color { get; set; }

    public string? TxtObs { get; set; }

    public string? NrCarteira { get; set; }

    public string? Pasep { get; set; }

    public DateOnly? DataRescisao { get; set; }

    public decimal? SalarioCarteira { get; set; }

    public string? Registrado { get; set; }

    public string? Integrado { get; set; }

    public virtual ICollection<AbastecimentoFrotaEmp> AbastecimentoFrotaEmps { get; set; } = new List<AbastecimentoFrotaEmp>();

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual Cidade? CidadeNavigation { get; set; }

    public virtual ICollection<ComissaoVendedor> ComissaoVendedors { get; set; } = new List<ComissaoVendedor>();

    public virtual ICollection<EmprestimoPeca> EmprestimoPecas { get; set; } = new List<EmprestimoPeca>();

    public virtual ICollection<LubrificanteFrotaEmp> LubrificanteFrotaEmps { get; set; } = new List<LubrificanteFrotaEmp>();

    public virtual ICollection<VendaFarmaciaPopular> VendaFarmaciaPopulars { get; set; } = new List<VendaFarmaciaPopular>();

    public virtual Vendedor? VendedorNavigation { get; set; }

    public virtual ICollection<Cliente> IdClientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Usuario> NmUsuarios { get; set; } = new List<Usuario>();
}
