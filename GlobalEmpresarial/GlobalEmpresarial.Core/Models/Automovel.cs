using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Automovel
{
    public int NrLanc { get; set; }

    public int CdMarca { get; set; }

    public int CdModelo { get; set; }

    public string? Ano { get; set; }

    public string Placa { get; set; } = null!;

    public string? TpComb { get; set; }

    public decimal? CapTanque { get; set; }

    public decimal? KmDiaCad { get; set; }

    public string? NmMotorista { get; set; }

    public decimal? Cilindro { get; set; }

    public string? TxtObs { get; set; }

    public int CdCliente { get; set; }

    public string? Motor { get; set; }

    public string? Ativo { get; set; }

    public virtual ICollection<AgendarRevisao> AgendarRevisaos { get; set; } = new List<AgendarRevisao>();

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual MarcaAutomovel CdMarcaNavigation { get; set; } = null!;

    public virtual ModeloAutomovel CdModeloNavigation { get; set; } = null!;
}
