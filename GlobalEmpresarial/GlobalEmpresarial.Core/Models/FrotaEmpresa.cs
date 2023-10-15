using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FrotaEmpresa
{
    public int NrLanc { get; set; }

    public string NmVeiculo { get; set; } = null!;

    public string Placa { get; set; } = null!;

    public string TpCombustivel { get; set; } = null!;

    public string? TxtObs { get; set; }

    public int CdMarca { get; set; }

    public int CdModelo { get; set; }

    public virtual ICollection<AbastecimentoFrotaEmp> AbastecimentoFrotaEmps { get; set; } = new List<AbastecimentoFrotaEmp>();

    public virtual MarcaAutomovel CdMarcaNavigation { get; set; } = null!;

    public virtual ModeloAutomovel CdModeloNavigation { get; set; } = null!;

    public virtual ICollection<LubrificanteFrotaEmp> LubrificanteFrotaEmps { get; set; } = new List<LubrificanteFrotaEmp>();
}
