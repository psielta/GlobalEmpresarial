using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CteRodVeiculo
{
    public int Codigo { get; set; }

    public string? CdInterno { get; set; }

    public string Renavam { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public int Tara { get; set; }

    public int CapacidadeKg { get; set; }

    public int CapacidadeM3 { get; set; }

    public string TpRodado { get; set; } = null!;

    public string TpCarroceria { get; set; } = null!;

    public string TpVeiculo { get; set; } = null!;

    public string TpProprietario { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public char? PertenceEmitente { get; set; }

    public string? PropTipoDocumento { get; set; }

    public string? PropCpf { get; set; }

    public string? PropCnpj { get; set; }

    public string? PropRntrc { get; set; }

    public string? PropInscEstadual { get; set; }

    public string? PropUf { get; set; }

    public string? PropTpProprietario { get; set; }

    public string? PropRazaoSocial { get; set; }

    public int NrCte { get; set; }

    public string? Responsavel { get; set; }

    public string? NmSeguradora { get; set; }

    public string? NrApolice { get; set; }

    public string? NrAverbacao { get; set; }

    public decimal? VlMercadoria { get; set; }

    public string? Ativo { get; set; }
}
