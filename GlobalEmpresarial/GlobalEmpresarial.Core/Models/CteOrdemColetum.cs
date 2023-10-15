using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteOrdemColetum
{
    public int Codigo { get; set; }

    public string? SerieOcc { get; set; }

    public int NrOcc { get; set; }

    public DateOnly DtEmissao { get; set; }

    public string? Cnpj { get; set; }

    public string? InscEstadual { get; set; }

    public string? Uf { get; set; }

    public string? Telefone { get; set; }

    public string? CdInterno { get; set; }

    public int NrCte { get; set; }
}
