using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfePercurso
{
    public int Id { get; set; }

    public int? IdMdfe { get; set; }

    public string? Estado { get; set; }
}
