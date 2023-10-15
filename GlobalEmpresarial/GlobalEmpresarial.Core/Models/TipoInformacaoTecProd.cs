using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TipoInformacaoTecProd
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<InformacaoTecnicaProduto> InformacaoTecnicaProdutos { get; set; } = new List<InformacaoTecnicaProduto>();
}
