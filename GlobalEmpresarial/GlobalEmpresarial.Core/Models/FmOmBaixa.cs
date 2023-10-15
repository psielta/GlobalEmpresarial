using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmOmBaixa
{
    public int Id { get; set; }

    public int IdOm { get; set; }

    public int IdProduto { get; set; }

    public string? Lote { get; set; }

    public DateOnly? DtValidade { get; set; }

    public decimal? Dosagem { get; set; }

    public decimal VlUnitario { get; set; }

    public decimal? VlTotal { get; set; }

    public char Tipo { get; set; }

    public string? Unidade { get; set; }

    public int IdFormaTamanho { get; set; }

    public decimal? Quant { get; set; }

    public string? QuantUnidade { get; set; }

    public int? IdItem { get; set; }

    public decimal? Diluido { get; set; }

    public decimal? Correcao { get; set; }

    public virtual FmOrdemManipulacao IdOmNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
