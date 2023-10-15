using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class R02
{
    public int Id { get; set; }

    public int IdOperador { get; set; }

    public int IdImpressora { get; set; }

    public int? IdEcfCaixa { get; set; }

    public string? SerieEcf { get; set; }

    public int? Crz { get; set; }

    public int? Coo { get; set; }

    public int? Cro { get; set; }

    public DateOnly? DataMovimento { get; set; }

    public DateOnly? DataEmissao { get; set; }

    public string? HoraEmissao { get; set; }

    public decimal? VendaBruta { get; set; }

    public decimal? GrandeTotal { get; set; }

    public string? Sincronizado { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public int? Crz1 { get; set; }

    public string? Mfd { get; set; }

    public string? ParEcf { get; set; }

    public virtual ICollection<R03> R03s { get; set; } = new List<R03>();
}
