using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Medico
{
    public int CdMedico { get; set; }

    public string NmMedico { get; set; } = null!;

    public string? Endereco { get; set; }

    public string? Bairro { get; set; }

    public string CdCidade { get; set; } = null!;

    public string? Cep { get; set; }

    public string? Telefone { get; set; }

    public string? TxtObs { get; set; }

    public string? CdCrm { get; set; }

    public string? UfCrm { get; set; }

    public string? TpConselho { get; set; }

    public virtual ICollection<DetalheVendaFarmPopular> DetalheVendaFarmPopulars { get; set; } = new List<DetalheVendaFarmPopular>();
}
