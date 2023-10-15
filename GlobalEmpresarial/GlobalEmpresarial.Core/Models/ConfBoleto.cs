using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ConfBoleto
{
    public int NrLanc { get; set; }

    public int NrConta { get; set; }

    public int BcoBoleto { get; set; }

    public string? Carteira { get; set; }

    public string? TxtLocalPgt { get; set; }

    public string? NrInicialBoleto { get; set; }

    public string? NrBoletoAtual { get; set; }

    public string? CdCedente { get; set; }

    public string? CdConvenio { get; set; }

    public string? CdTransmissao { get; set; }

    public string? EspecieDoc { get; set; }

    public string? LayoutRemessa { get; set; }

    public string? CdMora { get; set; }

    public string? CaracTitulo { get; set; }

    public string? FormaCadastramento { get; set; }

    public string? DiretorioRetorno { get; set; }

    public string? DiretorioEnvio { get; set; }

    public decimal? Multa { get; set; }

    public decimal? JurosMora { get; set; }

    public int? Protesto { get; set; }

    public virtual BcoBoleto BcoBoletoNavigation { get; set; } = null!;

    public virtual ContaDoCaixa NrContaNavigation { get; set; } = null!;
}
