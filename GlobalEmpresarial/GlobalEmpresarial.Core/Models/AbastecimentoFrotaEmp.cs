using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class AbastecimentoFrotaEmp
{
    public int NrLanc { get; set; }

    public DateOnly? DataLanc { get; set; }

    public DateOnly Data { get; set; }

    public string? Local { get; set; }

    public int CdFunc { get; set; }

    public int CdVeiculo { get; set; }

    public string? CdEquipamento { get; set; }

    public decimal? Km { get; set; }

    public TimeOnly? Hora { get; set; }

    public string TpComb { get; set; } = null!;

    public decimal Quantidade { get; set; }

    public string? NrReq { get; set; }

    public decimal? VlComb { get; set; }

    public int CdPosto { get; set; }

    public virtual Funcionario CdFuncNavigation { get; set; } = null!;

    public virtual PostoAbastecimento CdPostoNavigation { get; set; } = null!;

    public virtual FrotaEmpresa CdVeiculoNavigation { get; set; } = null!;
}
