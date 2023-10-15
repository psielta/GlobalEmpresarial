using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SaidaModelo2
{
    public int NrSaida { get; set; }

    public DateOnly? DataEmissao { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Subserie { get; set; }

    public int? NrInicialOrdem { get; set; }

    public int? NrFinalOrdem { get; set; }

    public decimal? VlTotal { get; set; }

    public decimal? BaseCalculoIcms { get; set; }

    public decimal? VlIcms { get; set; }

    public decimal? IsentaNaotributada { get; set; }

    public decimal? Outras { get; set; }

    public decimal? Aliquota { get; set; }
}
