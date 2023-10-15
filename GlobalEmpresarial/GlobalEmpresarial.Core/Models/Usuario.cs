using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Usuario
{
    public string NmUsuario { get; set; } = null!;

    public string CdSenha { get; set; } = null!;

    public string NmPessoa { get; set; } = null!;

    public int CdEmpresa { get; set; }

    public string? Ativo { get; set; }

    public string? DestravaCliente { get; set; }

    public string? ExcluirComanda { get; set; }

    public string? FazAgendamento { get; set; }

    public string? FazBalanco { get; set; }

    public string? DaDesconto { get; set; }

    public int Id { get; set; }

    public string? AlteraSaida { get; set; }

    public string? AlteraEntrada { get; set; }

    public string? AlteraCr { get; set; }

    public string? VisualizaRelatorioGerencial { get; set; }

    public string? FechaTodasMesas { get; set; }

    public string? AlteraFormaPgtNfce { get; set; }

    public string? ExcluiItemVenda { get; set; }

    public string? DescontoOs { get; set; }

    public string? AlterarValorItemOs { get; set; }

    public string? AcertaCondicionalSaida { get; set; }

    public string? DescalcularOs { get; set; }

    public string? IdBarra { get; set; }

    public string? Integrado { get; set; }

    public string? AutorizaDescontoCsenha { get; set; }

    public string? AlteraCadProduto { get; set; }

    public string? Suporte { get; set; }

    public virtual ICollection<CabContagemEstMobile> CabContagemEstMobiles { get; set; } = new List<CabContagemEstMobile>();

    public virtual ICollection<ControleUsuario> ControleUsuarios { get; set; } = new List<ControleUsuario>();

    public virtual ICollection<FmOrdemManipulacao> FmOrdemManipulacaos { get; set; } = new List<FmOrdemManipulacao>();

    public virtual ICollection<MenuUsuario> MenuUsuarios { get; set; } = new List<MenuUsuario>();

    public virtual ICollection<TbcontaEstoque> TbcontaEstoques { get; set; } = new List<TbcontaEstoque>();

    public virtual ICollection<Empresa> CdEmpresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Funcionario> CdFuncionarios { get; set; } = new List<Funcionario>();
}
