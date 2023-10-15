using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComandaDetalhe
{
    public int Reg { get; set; }

    public int Item { get; set; }

    public int IdComanda { get; set; }

    public int? IdVendedor { get; set; }

    public int IdProduto { get; set; }

    public int? IdEntregador { get; set; }

    public decimal? Qtde { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Comissao { get; set; }

    public decimal? Total { get; set; }

    public string Impresso { get; set; } = null!;

    public DateTime? Data { get; set; }

    public string? TipoComanda { get; set; }

    public string? Transferencia { get; set; }

    public string? OrigemLancamento { get; set; }

    public string? Obs { get; set; }

    public string? Cancelado { get; set; }

    public int? IdEmpresa { get; set; }

    public int? ComandaAnterior { get; set; }

    public string? Baixou { get; set; }

    public string? ServicoCouvert { get; set; }

    public TimeOnly? HrPedido { get; set; }

    public string? ServicoG { get; set; }

    public string? TxtObsCancelado { get; set; }

    public string? TamanhoPizza { get; set; }

    public string? MeiaPizza { get; set; }

    public int? IdPizza { get; set; }

    public virtual ComandaCabecalho IdComandaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
