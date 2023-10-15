using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VendaRapidaFormapgt
{
    public int Id { get; set; }

    public int? IdVr { get; set; }

    public string? Forma { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Troco { get; set; }

    public int? IdTipoVenda { get; set; }

    public int? CdVendedor { get; set; }

    public int? NrAberturaCaixa { get; set; }

    public DateOnly? DtLanc { get; set; }

    public decimal? Desconto { get; set; }

    public int? Caixa { get; set; }
}
