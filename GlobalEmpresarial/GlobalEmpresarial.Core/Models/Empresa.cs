using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Empresa
{
    public int CdEmpresa { get; set; }

    public string NmEmpresa { get; set; } = null!;

    public string NmEndereco { get; set; } = null!;

    public int Numero { get; set; }

    public string CdCidade { get; set; } = null!;

    public string CdCep { get; set; } = null!;

    public string? CdCnpj { get; set; }

    public string? NmBairro { get; set; }

    public string? Telefone { get; set; }

    public string? Telefone2 { get; set; }

    public string? NrInscrMunicipal { get; set; }

    public string? NrInscrEstadual { get; set; }

    public string? TxtObs { get; set; }

    public short? TpNotaFiscal { get; set; }

    public string? PathLogo { get; set; }

    public string? InscrSubTrib { get; set; }

    public string? Cnae { get; set; }

    public string? ImgDanfeCab { get; set; }

    public int? TipoRegime { get; set; }

    public string? TpPerfilSpeedFiscal { get; set; }

    public string? TpAtividadeFiscal { get; set; }

    public string? UsaGaveta { get; set; }

    public string? Logo { get; set; }

    public string? TpQuali { get; set; }

    public string? Suframa { get; set; }

    public decimal? AliquotaPis { get; set; }

    public decimal? AliquotaCofins { get; set; }

    public string? Complemento { get; set; }

    public string? Contato { get; set; }

    public string? PerfilPaf { get; set; }

    public decimal? PorcIss { get; set; }

    public decimal? PorcIrrf { get; set; }

    public decimal? PorcIrpj { get; set; }

    public decimal? PorcContsocial { get; set; }

    public decimal? PorcLucroPresumido { get; set; }

    public string? LoginFarmaciaPopular { get; set; }

    public string? SenhaFarmaciaPopular { get; set; }

    public string? SenhaSngpc { get; set; }

    public string? EMail { get; set; }

    public string? CodIncTrib { get; set; }

    public string? IndAproCred { get; set; }

    public string? CodTipoCont { get; set; }

    public string? IndRegCum { get; set; }

    public string? CodRecPis { get; set; }

    public string? CodRecCofins { get; set; }

    public string? NatRec { get; set; }

    public string? NmCidade { get; set; }

    public string? Uf { get; set; }

    public string? Registro { get; set; }

    public string? OrgaoRegistro { get; set; }

    public DateOnly? DataRegistro { get; set; }

    public string? InfSaidaSpeedFiscal { get; set; }

    public string? BlocoGeracaoSpeedFiscal { get; set; }

    public string? ContaAnaSpedInv { get; set; }

    public string? Idcsc { get; set; }

    public string? Csc { get; set; }

    public string? AutorizoXml { get; set; }

    public string? CpfcnpfAutorizado { get; set; }

    public string? NomeFantasia { get; set; }

    public string? Integrado { get; set; }

    public int? IdVendaMobile { get; set; }

    public string? ChavePix { get; set; }

    public virtual ICollection<AberturaVendaRapidum> AberturaVendaRapida { get; set; } = new List<AberturaVendaRapidum>();

    public virtual ICollection<AgendamentoEntrega> AgendamentoEntregas { get; set; } = new List<AgendamentoEntrega>();

    public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();

    public virtual ICollection<ApontamentoMaquina> ApontamentoMaquinas { get; set; } = new List<ApontamentoMaquina>();

    public virtual ICollection<ApontamentosCaminhao> ApontamentosCaminhaos { get; set; } = new List<ApontamentosCaminhao>();

    public virtual ICollection<CabContagemEstMobile> CabContagemEstMobiles { get; set; } = new List<CabContagemEstMobile>();

    public virtual ICollection<CabDevolucaoSaidum> CabDevolucaoSaida { get; set; } = new List<CabDevolucaoSaidum>();

    public virtual ICollection<CabVendaControlado> CabVendaControlados { get; set; } = new List<CabVendaControlado>();

    public virtual Cidade CdCidadeNavigation { get; set; } = null!;

    public virtual ICollection<CfopContaSpeed> CfopContaSpeeds { get; set; } = new List<CfopContaSpeed>();

    public virtual ICollection<ComandaCabecalho> ComandaCabecalhos { get; set; } = new List<ComandaCabecalho>();

    public virtual ICollection<ConfEmailNfe> ConfEmailNves { get; set; } = new List<ConfEmailNfe>();

    public virtual ICollection<ConfNfe> ConfNves { get; set; } = new List<ConfNfe>();

    public virtual ICollection<ContaDoCaixa> ContaDoCaixas { get; set; } = new List<ContaDoCaixa>();

    public virtual ICollection<Contador> Contadors { get; set; } = new List<Contador>();

    public virtual ICollection<ContasAPagar> ContasAPagars { get; set; } = new List<ContasAPagar>();

    public virtual ICollection<ContasAReceber> ContasARecebers { get; set; } = new List<ContasAReceber>();

    public virtual ICollection<ControleCheque> ControleCheques { get; set; } = new List<ControleCheque>();

    public virtual ICollection<EmprestimoPeca> EmprestimoPecas { get; set; } = new List<EmprestimoPeca>();

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<EntradaOutrasDesp> EntradaOutrasDesps { get; set; } = new List<EntradaOutrasDesp>();

    public virtual ICollection<Funcionario> Funcionarios { get; set; } = new List<Funcionario>();

    public virtual ICollection<LivroCaixa> LivroCaixas { get; set; } = new List<LivroCaixa>();

    public virtual ICollection<Mdfe> Mdves { get; set; } = new List<Mdfe>();

    public virtual ICollection<NfceAberturaCaixa> NfceAberturaCaixas { get; set; } = new List<NfceAberturaCaixa>();

    public virtual ICollection<PerdaMedControlado> PerdaMedControlados { get; set; } = new List<PerdaMedControlado>();

    public virtual ICollection<ProdutoSaidum> ProdutoSaida { get; set; } = new List<ProdutoSaidum>();

    public virtual ICollection<Saida> Saida { get; set; } = new List<Saida>();

    public virtual ICollection<SaidaMateriaPrima> SaidaMateriaPrimas { get; set; } = new List<SaidaMateriaPrima>();

    public virtual ICollection<SaldoEstoque> SaldoEstoques { get; set; } = new List<SaldoEstoque>();

    public virtual ICollection<TbcontaEstoque> TbcontaEstoques { get; set; } = new List<TbcontaEstoque>();

    public virtual ICollection<TransferenciaEstoque> TransferenciaEstoques { get; set; } = new List<TransferenciaEstoque>();

    public virtual ICollection<VendaConsumidorCab> VendaConsumidorCabs { get; set; } = new List<VendaConsumidorCab>();

    public virtual ICollection<VendaFarmaciaPopular> VendaFarmaciaPopulars { get; set; } = new List<VendaFarmaciaPopular>();

    public virtual ICollection<Usuario> CdUsuarios { get; set; } = new List<Usuario>();
}
