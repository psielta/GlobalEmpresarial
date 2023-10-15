using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Emprestimo
{
    public int NrEmprestimo { get; set; }

    public DateOnly? DataEmp { get; set; }

    public DateOnly? DataDevol { get; set; }

    public int Requerente { get; set; }

    public int? TipoRequerente { get; set; }
}
