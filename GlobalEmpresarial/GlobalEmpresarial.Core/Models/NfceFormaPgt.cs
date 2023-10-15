using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NfceFormaPgt
{
    public int Id { get; set; }

    public int? IdSaida { get; set; }

    public string? Forma { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Troco { get; set; }

    public string? Bandeira { get; set; }

    public string? Cnpj { get; set; }

    public string? Nsu { get; set; }

    public int? NrAberturaCaixa { get; set; }

    public int? Caixa { get; set; }
}
