using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfeCondutor
{
    public int Id { get; set; }

    public int IdMdfe { get; set; }

    public string? Xnome { get; set; }

    public string? Cpf { get; set; }

    public virtual Mdfe IdMdfeNavigation { get; set; } = null!;
}
