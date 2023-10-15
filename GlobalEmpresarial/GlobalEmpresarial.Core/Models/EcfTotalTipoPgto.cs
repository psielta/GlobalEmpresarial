using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfTotalTipoPgto
{
    public int Id { get; set; }

    public int IdEcfVendaCabecalho { get; set; }

    public int IdEcfTipoPagamento { get; set; }

    public string? SerieEcf { get; set; }

    public int? Coo { get; set; }

    public int? Ccf { get; set; }

    public int? Gnf { get; set; }

    public decimal? Valor { get; set; }

    public string? Nsu { get; set; }

    public string? Estorno { get; set; }

    public string? Rede { get; set; }

    public string? CartaoDc { get; set; }

    public string? Sincronizado { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public string? TpPagt { get; set; }

    public string? Baixou { get; set; }

    public string? MfAdicional { get; set; }

    public string? ModeloEcf { get; set; }
}
