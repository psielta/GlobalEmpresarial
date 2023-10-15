using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CurvaAbc
{
    public int? Codigo { get; set; }

    public string? Descricao { get; set; }

    public decimal? VlUnit { get; set; }

    public decimal? QtConsumo { get; set; }

    public decimal? VlConsumo { get; set; }

    public decimal? VlConsumoAc { get; set; }

    public decimal? PorcVlConsAc { get; set; }

    public decimal? PorcQtTotal { get; set; }

    public decimal? PorcQtAc { get; set; }

    public int? Classif { get; set; }

    public string? Faixa { get; set; }

    public string? Unidade { get; set; }

    public decimal? PorcFaixa { get; set; }
}
