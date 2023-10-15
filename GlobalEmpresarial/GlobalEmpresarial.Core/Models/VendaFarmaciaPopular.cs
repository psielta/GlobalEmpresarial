using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VendaFarmaciaPopular
{
    public int NrLanc { get; set; }

    public DateOnly? DtLanc { get; set; }

    public TimeOnly? HrLanc { get; set; }

    public int CdEmpresa { get; set; }

    public int CdVendedor { get; set; }

    public int CdCliente { get; set; }

    public string Status { get; set; } = null!;

    public string? NrCupom { get; set; }

    public string? Fechou { get; set; }

    public string? Transf { get; set; }

    public string? TxtCupomVinculado { get; set; }

    public string? CpfVendeodr { get; set; }

    public string? LoginEmpresa { get; set; }

    public string? SenhaEmpresa { get; set; }

    public string? SenhaVendedor { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual Funcionario CdVendedorNavigation { get; set; } = null!;

    public virtual ICollection<DetalheVendaFarmPopular> DetalheVendaFarmPopulars { get; set; } = new List<DetalheVendaFarmPopular>();
}
