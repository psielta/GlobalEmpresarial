using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class BandeiraCartao
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public int? DiasPagto { get; set; }

    public decimal? Taxa { get; set; }

    public int? IdConta { get; set; }

    public int? IdCredenciadora { get; set; }
}
