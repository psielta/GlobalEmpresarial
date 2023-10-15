using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Pedido
{
    public int Id { get; set; }

    public int? IdMobile { get; set; }

    public DateOnly? DtVenda { get; set; }

    public TimeOnly? HrVenda { get; set; }

    public int? IdVendedor { get; set; }

    public string? Fechou { get; set; }

    public string? Enviou { get; set; }

    public int? IdCliente { get; set; }

    public string? TxtObs { get; set; }

    public decimal? VlDescontoGeral { get; set; }

    public int? IdFormaPagt { get; set; }

    /// <summary>
    /// id do cliente
    /// </summary>
    public int? IdGlobal { get; set; }

    public int? IdProduto { get; set; }

    public decimal? Qtde { get; set; }

    public decimal? VlUnitario { get; set; }

    public decimal? VlDesconto { get; set; }

    public decimal? VlTotal { get; set; }

    public int? TipoValor { get; set; }

    public string? TxtObsProduto { get; set; }

    public int? IdEmpresa { get; set; }

    public string? Integrado { get; set; }
}
