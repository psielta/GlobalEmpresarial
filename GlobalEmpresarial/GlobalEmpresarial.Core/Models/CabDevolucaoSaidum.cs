using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CabDevolucaoSaidum
{
    public int Id { get; set; }

    public DateOnly? DtDevolucao { get; set; }

    public int IdEmpresa { get; set; }

    public int IdCliente { get; set; }

    public string Status { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;
}
