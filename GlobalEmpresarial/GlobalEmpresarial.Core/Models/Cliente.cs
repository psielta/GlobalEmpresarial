using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Cliente
{
    public int CdCliente { get; set; }

    public string NmCliente { get; set; } = null!;

    public string? NmEndereco { get; set; }

    public int? Numero { get; set; }

    public string CdCidade { get; set; } = null!;

    public string? CdCep { get; set; }

    public string? NmBairro { get; set; }

    public string? Telefone { get; set; }

    public string? Telefone2 { get; set; }

    public DateOnly? DtNasc { get; set; }

    public DateOnly? DtCadastro { get; set; }

    public string? Sexo { get; set; }

    public string? Ativo { get; set; }

    public string? TxtRecado { get; set; }

    public string? Cpf { get; set; }

    public string? Cnpj { get; set; }

    public string TpCliente { get; set; } = null!;

    public decimal? LimiteCredito { get; set; }

    public string? DiaPagt { get; set; }

    public string? TxtObs { get; set; }

    public string? NmUsuario { get; set; }

    public string? Email { get; set; }

    public int? Convenio { get; set; }

    public string? Profissao { get; set; }

    public string? NrCelular { get; set; }

    public string? PodeComprar { get; set; }

    public string? NrInscrEstadual { get; set; }

    public decimal? PorcIss { get; set; }

    public decimal? PorcIrrf { get; set; }

    public string? IncideIss { get; set; }

    public string? EmiteNf { get; set; }

    public string? NmEnderecoNfe { get; set; }

    public int? NumeroNfe { get; set; }

    public string CdCidadeNfe { get; set; } = null!;

    public string? CdCepNfe { get; set; }

    public string? NmBairroNfe { get; set; }

    public string? NmFatansia { get; set; }

    public int? TpRegime { get; set; }

    public string? Mva { get; set; }

    public string? Complemento { get; set; }

    public string? Rg { get; set; }

    public string? OrgaoRg { get; set; }

    public string? UfOrgaoRg { get; set; }

    public string? Transferiu { get; set; }

    public decimal? Consumacao { get; set; }

    public decimal? Entrada { get; set; }

    public int? Comanda { get; set; }

    public string? Foto { get; set; }

    public string? ComplementoNfe { get; set; }

    public int? CdClassificacao { get; set; }

    public string? ContribuinteInss { get; set; }

    public int? TipoPagto { get; set; }

    public string? PrecisaAutorizacao { get; set; }

    public string? ConsumidorFinal { get; set; }

    public string? Integrado { get; set; }

    public string? CdInterno { get; set; }

    public decimal? ComissaoCliente { get; set; }

    public virtual ICollection<AgendarRevisao> AgendarRevisaos { get; set; } = new List<AgendarRevisao>();

    public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

    public virtual ICollection<ApontamentoMaquina> ApontamentoMaquinas { get; set; } = new List<ApontamentoMaquina>();

    public virtual ICollection<ApontamentosCaminhao> ApontamentosCaminhaos { get; set; } = new List<ApontamentosCaminhao>();

    public virtual ICollection<Automovel> Automovels { get; set; } = new List<Automovel>();

    public virtual ICollection<CabDevolucaoSaidum> CabDevolucaoSaida { get; set; } = new List<CabDevolucaoSaidum>();

    public virtual ICollection<CabVendaControlado> CabVendaControlados { get; set; } = new List<CabVendaControlado>();

    public virtual Cidade CdCidadeNavigation { get; set; } = null!;

    public virtual ICollection<ContasAReceber> ContasARecebers { get; set; } = new List<ContasAReceber>();

    public virtual ICollection<Contrato> Contratos { get; set; } = new List<Contrato>();

    public virtual ICollection<EmprestimoPeca> EmprestimoPecas { get; set; } = new List<EmprestimoPeca>();

    public virtual ICollection<FechamentoTerra> FechamentoTerras { get; set; } = new List<FechamentoTerra>();

    public virtual ICollection<FmAnimal> FmAnimals { get; set; } = new List<FmAnimal>();

    public virtual ICollection<FmOrdemManipulacao> FmOrdemManipulacaos { get; set; } = new List<FmOrdemManipulacao>();

    public virtual ICollection<Saida> Saida { get; set; } = new List<Saida>();

    public virtual ICollection<TiposEquipamento> TiposEquipamentos { get; set; } = new List<TiposEquipamento>();

    public virtual ICollection<VendaConsumidorCab> VendaConsumidorCabs { get; set; } = new List<VendaConsumidorCab>();

    public virtual ICollection<VendaFarmaciaPopular> VendaFarmaciaPopulars { get; set; } = new List<VendaFarmaciaPopular>();

    public virtual ICollection<VrDevolucao> VrDevolucaos { get; set; } = new List<VrDevolucao>();

    public virtual ICollection<Funcionario> IdVendedors { get; set; } = new List<Funcionario>();
}
