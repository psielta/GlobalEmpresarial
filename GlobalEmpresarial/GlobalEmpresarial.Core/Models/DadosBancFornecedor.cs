using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DadosBancFornecedor
{
    public int Id { get; set; }

    public int IdFornecedor { get; set; }

    public string? Agencia { get; set; }

    public string? IdConta { get; set; }

    public string? NmBanco { get; set; }

    public string? ChavePix { get; set; }

    public string? TxtObs { get; set; }

    public virtual Fornecedor IdFornecedorNavigation { get; set; } = null!;
}
