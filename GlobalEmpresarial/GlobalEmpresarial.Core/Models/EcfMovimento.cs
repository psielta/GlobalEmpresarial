using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfMovimento
{
    public int Id { get; set; }

    public int IdEcfEmpresa { get; set; }

    public int IdEcfTurno { get; set; }

    public int IdEcfImpressora { get; set; }

    public int IdEcfOperador { get; set; }

    public int IdEcfCaixa { get; set; }

    public int IdGerenteSupervisor { get; set; }

    public DateOnly? DataAbertura { get; set; }

    public string? HoraAbertura { get; set; }

    public DateOnly? DataFechamento { get; set; }

    public string? HoraFechamento { get; set; }

    public decimal? TotalSuprimento { get; set; }

    public decimal? TotalSangria { get; set; }

    public decimal? TotalNaoFiscal { get; set; }

    public decimal? TotalVenda { get; set; }

    public decimal? TotalDesconto { get; set; }

    public decimal? TotalAcrescimo { get; set; }

    public decimal? TotalFinal { get; set; }

    public decimal? TotalRecebido { get; set; }

    public decimal? TotalTroco { get; set; }

    public decimal? TotalCancelado { get; set; }

    public string StatusMovimento { get; set; } = null!;

    public int? IdFrente { get; set; }
}
