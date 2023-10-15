using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class SaldoEstoque
{
    public int CdProduto { get; set; }

    public int CdEmpresa { get; set; }

    public int CdPlano { get; set; }

    public decimal? QuantE { get; set; }

    public decimal? QuantV { get; set; }

    public decimal? QuantF { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValidade { get; set; }

    public decimal? VlCusto { get; set; }

    public decimal? VlSaida { get; set; }

    public int? PeriodoFinal { get; set; }

    public decimal? PorcVendaAPrazo { get; set; }

    public decimal? PorcVendaCd { get; set; }

    public decimal? PorcVendaCc { get; set; }

    public decimal? PorcVendaVista { get; set; }

    public string? Alterado { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
