using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ServOrcamento
{
    public int Nr { get; set; }

    public int NrOr { get; set; }

    public int CdServico { get; set; }

    public decimal Quant { get; set; }

    public decimal Valor { get; set; }

    public string PagaComissao { get; set; } = null!;

    public decimal? VlDesc { get; set; }

    public decimal? VlTotal { get; set; }

    public decimal? VlComissao { get; set; }

    public int? CdMecanico { get; set; }

    public string? PagouMec { get; set; }

    public DateOnly? DtPagouMec { get; set; }

    public string? TxtRelatoCliente { get; set; }

    public string? TxtDivergencia { get; set; }

    public string? Assessorio { get; set; }

    public string? TxtAvalTecnico { get; set; }

    public DateOnly? Data { get; set; }

    public int? IdEquipamento { get; set; }

    public string? Lado { get; set; }

    public int? CdMecanico2 { get; set; }

    public virtual Servico CdServicoNavigation { get; set; } = null!;

    public virtual Orcamento NrOrNavigation { get; set; } = null!;
}
