using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Frete
{
    public int NrLanc { get; set; }

    public int NrSaida { get; set; }

    public int FretePorConta { get; set; }

    public decimal VlFrete { get; set; }

    public int CdTransp { get; set; }

    public decimal? Quant { get; set; }

    public string? Especie { get; set; }

    public string? Marca { get; set; }

    public string? Numeracao { get; set; }

    public decimal? Pbruto { get; set; }

    public decimal? Pliq { get; set; }

    public virtual Transportadora CdTranspNavigation { get; set; } = null!;

    public virtual Saida NrSaidaNavigation { get; set; } = null!;
}
