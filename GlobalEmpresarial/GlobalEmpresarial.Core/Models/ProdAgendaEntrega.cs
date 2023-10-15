using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdAgendaEntrega
{
    public int NrLanc { get; set; }

    public int NrAgendamento { get; set; }

    public int CdProduto { get; set; }

    public decimal? Quant { get; set; }

    public decimal? VlUnitario { get; set; }

    public decimal? VlDesconto { get; set; }

    public decimal? VlTotal { get; set; }

    public string? TxtObs { get; set; }

    public string? CdUnidade { get; set; }

    public virtual AgendamentoEntrega NrAgendamentoNavigation { get; set; } = null!;
}
