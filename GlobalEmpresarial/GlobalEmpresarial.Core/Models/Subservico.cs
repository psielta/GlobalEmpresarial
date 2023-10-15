using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Subservico
{
    public int Id { get; set; }

    public int IdServico { get; set; }

    public string NmSubservico { get; set; } = null!;

    public string? Complemento { get; set; }

    public string? Ativo { get; set; }

    public virtual Servico IdServicoNavigation { get; set; } = null!;
}
