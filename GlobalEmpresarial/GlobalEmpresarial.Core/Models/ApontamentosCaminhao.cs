using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ApontamentosCaminhao
{
    public int NrLanc { get; set; }

    public DateOnly DtEmissao { get; set; }

    public int CdFrota { get; set; }

    public int CdFunc { get; set; }

    public int CdCliente { get; set; }

    public string? NmEquipamento { get; set; }

    public TimeOnly? HrParada { get; set; }

    public TimeOnly? HrRetorno { get; set; }

    public string? TxtMotivo { get; set; }

    public string Autorizado { get; set; } = null!;

    public string? Fechou { get; set; }

    public int? NrFechamento { get; set; }

    public int CdEmpresa { get; set; }

    public string? TxtAutorizado { get; set; }

    public string? TpPagamento { get; set; }

    public TimeOnly? HrDescanso { get; set; }

    public string? GerouNf { get; set; }

    public string? NrInterno { get; set; }

    public int? NrRecibo { get; set; }

    public string? Recebeu { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<ItensApontamentoCaminhao> ItensApontamentoCaminhaos { get; set; } = new List<ItensApontamentoCaminhao>();
}
