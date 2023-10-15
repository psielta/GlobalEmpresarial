using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ClienteCredito
{
    public int Id { get; set; }

    public DateOnly? DataLanc { get; set; }

    public int? IdCliente { get; set; }

    public int? IdOs { get; set; }

    public int? IdEntrada { get; set; }

    public decimal? Valor { get; set; }

    public string? Pagou { get; set; }

    public DateOnly? DataPagto { get; set; }

    public int? IdOsPagou { get; set; }

    public string? PagouDinheiro { get; set; }
}
