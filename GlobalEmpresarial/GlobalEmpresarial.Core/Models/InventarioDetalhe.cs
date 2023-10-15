using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class InventarioDetalhe
{
    public int Id { get; set; }

    public int? IdCabecalho { get; set; }

    public int? CdProduto { get; set; }

    public string? Descricao { get; set; }

    public string? Unidade { get; set; }

    public string? Tributacao { get; set; }

    public decimal? Saldo { get; set; }

    public decimal? VlUnit { get; set; }

    public decimal? VlTotal { get; set; }
}
