using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PostoAbastecimento
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public decimal? VlGasolina { get; set; }

    public decimal? VlEtanol { get; set; }

    public decimal? VlDiesel { get; set; }

    public decimal? VlGas { get; set; }

    public virtual ICollection<AbastecimentoFrotaEmp> AbastecimentoFrotaEmps { get; set; } = new List<AbastecimentoFrotaEmp>();
}
