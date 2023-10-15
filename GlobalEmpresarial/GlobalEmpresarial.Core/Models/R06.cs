using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class R06
{
    public int Id { get; set; }

    public int IdOperador { get; set; }

    public int IdImpressora { get; set; }

    public int? IdEcfCaixa { get; set; }

    public string? SerieEcf { get; set; }

    public int? Coo { get; set; }

    public int? Gnf { get; set; }

    public int? Grg { get; set; }

    public int? Cdc { get; set; }

    public string? Denominacao { get; set; }

    public DateOnly? DataEmissao { get; set; }

    public string? HoraEmissao { get; set; }

    public string? Sincronizado { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public string? MfAdicional { get; set; }

    public string? ModeloEcf { get; set; }

    public virtual ICollection<R07> R07s { get; set; } = new List<R07>();
}
