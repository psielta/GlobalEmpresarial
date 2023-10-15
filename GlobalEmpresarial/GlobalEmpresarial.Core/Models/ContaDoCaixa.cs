using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ContaDoCaixa
{
    public int Nr { get; set; }

    public string NmConta { get; set; } = null!;

    public string? NrContaBanco { get; set; }

    public string? NrAgencia { get; set; }

    public string? NmBanco { get; set; }

    public decimal? SaldoInicial { get; set; }

    public string? NrChequeInicial { get; set; }

    public int CdEmpresa { get; set; }

    public string? NrDigitoAg { get; set; }

    public string? NrDigitoConta { get; set; }

    public decimal? SaldoAtual { get; set; }

    public decimal? LimiteEspecial { get; set; }

    public string? MostrarDadosImpressao { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<ConfBoleto> ConfBoletos { get; set; } = new List<ConfBoleto>();

    public virtual ICollection<ControleCheque> ControleCheques { get; set; } = new List<ControleCheque>();

    public virtual ICollection<LivroCaixa> LivroCaixas { get; set; } = new List<LivroCaixa>();
}
