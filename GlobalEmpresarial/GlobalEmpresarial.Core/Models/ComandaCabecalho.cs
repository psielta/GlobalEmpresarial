using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComandaCabecalho
{
    public int Id { get; set; }

    public int IdEmpresa { get; set; }

    public int IdVendedor { get; set; }

    public int IdCliente { get; set; }

    public string TipoComanda { get; set; } = null!;

    public string Vinculo { get; set; } = null!;

    public DateTime Abertura { get; set; }

    public DateTime? Fechamento { get; set; }

    public int? QtdeLugares { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Couvert { get; set; }

    public decimal? Entrega { get; set; }

    public decimal? Consumacao { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? Servico { get; set; }

    public decimal? Total { get; set; }

    public decimal? TrocoCliente { get; set; }

    public string Status { get; set; } = null!;

    public string? Conferido { get; set; }

    public string? Cupom { get; set; }

    public string? TipoPagamento { get; set; }

    public decimal? ValorPago { get; set; }

    public string? Cr { get; set; }

    public string? Coo { get; set; }

    public string? Necf { get; set; }

    public string NrComanda { get; set; } = null!;

    public string? Baixou { get; set; }

    public string? Transf { get; set; }

    public string? ConvertCobra { get; set; }

    public string? ServicoCobra { get; set; }

    public int NrMesa { get; set; }

    public TimeOnly? HrEntrega { get; set; }

    public string? TxtObsDelivery { get; set; }

    public string? TpPagamento { get; set; }

    public decimal? Entrada { get; set; }

    public string? VemBuscar { get; set; }

    public string? ImportouVenda { get; set; }

    public DateOnly? DtEntrega { get; set; }

    public virtual ICollection<ComandaDetalhe> ComandaDetalhes { get; set; } = new List<ComandaDetalhe>();

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<ObsItemComandum> ObsItemComanda { get; set; } = new List<ObsItemComandum>();
}
