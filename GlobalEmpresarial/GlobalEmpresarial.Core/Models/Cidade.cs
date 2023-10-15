using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Cidade
{
    public string CdCidade { get; set; } = null!;

    public string NmCidade { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Contador> Contadors { get; set; } = new List<Contador>();

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

    public virtual ICollection<MdfeInfcarregamento> MdfeInfcarregamentos { get; set; } = new List<MdfeInfcarregamento>();

    public virtual ICollection<Parceiro> Parceiros { get; set; } = new List<Parceiro>();

    public virtual ICollection<PontoVendum> PontoVenda { get; set; } = new List<PontoVendum>();
}
