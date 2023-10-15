using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PlanoDeCaixa
{
    public string CdClassificacao { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<HistoricoCaixa> HistoricoCaixas { get; set; } = new List<HistoricoCaixa>();
}
