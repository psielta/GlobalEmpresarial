using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Servico
{
    public int Codigo { get; set; }

    public string Descricao { get; set; } = null!;

    public decimal Valor { get; set; }

    public string? PagaComissao { get; set; }

    public int? CdDepartamento { get; set; }

    public decimal? PorcComissaoParceiro { get; set; }

    public int? CdServicoGlobal { get; set; }

    public decimal? HrTrabalhadas { get; set; }

    public string? AparecerRelatorioVenda { get; set; }

    public virtual ICollection<ServOrcamento> ServOrcamentos { get; set; } = new List<ServOrcamento>();

    public virtual ICollection<Subservico> Subservicos { get; set; } = new List<Subservico>();
}
