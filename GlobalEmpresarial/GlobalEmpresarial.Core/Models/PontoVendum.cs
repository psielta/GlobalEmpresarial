using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PontoVendum
{
    public int Id { get; set; }

    public int IdFuncionario { get; set; }

    public string NmPonto { get; set; } = null!;

    public string Endereco { get; set; } = null!;

    public string Numero { get; set; } = null!;

    public string CdCidade { get; set; } = null!;

    public string Ativo { get; set; } = null!;

    public string TpValor { get; set; } = null!;

    public string? Integrado { get; set; }

    public virtual Cidade CdCidadeNavigation { get; set; } = null!;

    public virtual ICollection<PlanoEstoque> IdPlanoEstoques { get; set; } = new List<PlanoEstoque>();
}
