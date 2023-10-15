using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TbconfGerenciadortef
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Autoativar { get; set; } = null!;

    public string Multiploscartao { get; set; } = null!;

    public int Sleep { get; set; }

    public int Sts { get; set; }

    public int? IdTipogp { get; set; }
}
