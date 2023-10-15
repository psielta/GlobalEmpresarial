using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfeInfcarregamento
{
    public int Id { get; set; }

    public int IdMdfe { get; set; }

    public string Cmuncarrega { get; set; } = null!;

    public virtual Cidade CmuncarregaNavigation { get; set; } = null!;

    public virtual Mdfe IdMdfeNavigation { get; set; } = null!;
}
