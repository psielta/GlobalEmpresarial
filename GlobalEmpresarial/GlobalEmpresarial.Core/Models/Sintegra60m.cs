using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Sintegra60m
{
    public int Id { get; set; }

    public DateOnly? DataEmissao { get; set; }

    public string NumeroSerieEcf { get; set; } = null!;

    public int? NumeroEquipamento { get; set; }

    public string? ModeloDocumentoFiscal { get; set; }

    public int? CooInicial { get; set; }

    public int? CooFinal { get; set; }

    public int? Crz { get; set; }

    public int? Cro { get; set; }

    public decimal? ValorVendaBruta { get; set; }

    public decimal? ValorGrandeTotal { get; set; }
}
