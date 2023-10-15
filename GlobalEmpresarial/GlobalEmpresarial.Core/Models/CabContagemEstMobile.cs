using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class CabContagemEstMobile
{
    public int Id { get; set; }

    public int IdEmpresa { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Hora { get; set; }

    public string IdUsuario { get; set; } = null!;

    public string? Enviado { get; set; }

    public virtual ICollection<ContagemPrMobile> ContagemPrMobiles { get; set; } = new List<ContagemPrMobile>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
