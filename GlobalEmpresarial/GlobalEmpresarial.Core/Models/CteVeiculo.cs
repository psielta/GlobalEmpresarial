using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteVeiculo
{
    public int Codigo { get; set; }

    public string Cor { get; set; } = null!;

    public string NmCor { get; set; } = null!;

    public string CdMarcaModelo { get; set; } = null!;

    public string Chassi { get; set; } = null!;

    public decimal VlVeiculo { get; set; }

    public decimal Frete { get; set; }

    public int NrCte { get; set; }
}
