using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Transportadora
{
    public int CdTransportadora { get; set; }

    public string? NmTransportadora { get; set; }

    public string? NmEndereco { get; set; }

    public int? Numero { get; set; }

    public string? NmBairro { get; set; }

    public string? CdCidade { get; set; }

    public string? CdCnpj { get; set; }

    public string? CdIe { get; set; }

    public string? PlacaVeiculo { get; set; }

    public string? NrTelefone { get; set; }

    public string? NrTelefone2 { get; set; }

    public string? Email { get; set; }

    public string? Cep { get; set; }

    public virtual ICollection<Frete> Fretes { get; set; } = new List<Frete>();
}
