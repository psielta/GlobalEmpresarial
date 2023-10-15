using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfeReboque
{
    public int Id { get; set; }

    public int IdMdfe { get; set; }

    public string? Cint { get; set; }

    public string? Placa { get; set; }

    public string? Renavam { get; set; }

    public decimal? Tara { get; set; }

    public decimal? Capkg { get; set; }

    public decimal? Capm3 { get; set; }

    public string? Tprod { get; set; }

    public string? Tpcar { get; set; }

    public string? Uf { get; set; }

    public virtual Mdfe IdMdfeNavigation { get; set; } = null!;
}
