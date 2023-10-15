using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class HistoricoCaixa
{
    public string CdSubPlano { get; set; } = null!;

    public string CdPlano { get; set; } = null!;

    public string Tipo { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual PlanoDeCaixa CdPlanoNavigation { get; set; } = null!;

    public virtual ICollection<ContasAPagar> ContasAPagars { get; set; } = new List<ContasAPagar>();

    public virtual ICollection<ContasAReceber> ContasARecebers { get; set; } = new List<ContasAReceber>();

    public virtual ICollection<ControleCheque> ControleCheques { get; set; } = new List<ControleCheque>();

    public virtual ICollection<LivroCaixa> LivroCaixas { get; set; } = new List<LivroCaixa>();
}
