using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteSeguro
{
    public int Codigo { get; set; }

    public string Responsavel { get; set; } = null!;

    public string? NmSeguradoura { get; set; }

    public string? NrApolice { get; set; }

    public string? NrAverbacao { get; set; }

    public decimal? VlMercadoria { get; set; }

    public int NrCte { get; set; }
}
