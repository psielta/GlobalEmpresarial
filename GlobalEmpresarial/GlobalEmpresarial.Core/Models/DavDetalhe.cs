using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DavDetalhe
{
    public int Id { get; set; }

    public int IdDavCabecalho { get; set; }

    public int IdProduto { get; set; }

    public int? Item { get; set; }

    public decimal? Quantidade { get; set; }

    public decimal? ValorUnitario { get; set; }

    public decimal? ValorTotal { get; set; }

    public string? Cancelado { get; set; }

    public string? MesclaProduto { get; set; }

    public string? GtinProduto { get; set; }

    public string? NomeProduto { get; set; }

    public string? UnidadeProduto { get; set; }

    public string? HashTripa { get; set; }

    public int? HashIncremento { get; set; }

    public string? DescricaoPdv { get; set; }

    public string? TotalizadorParcial { get; set; }

    public string? NumeroDav { get; set; }

    public DateOnly? DataMovimento { get; set; }

    public DateOnly? DataEmissao { get; set; }

    public string? Hash { get; set; }

    public char? Integrador { get; set; }

    public virtual DavCabecalho IdDavCabecalhoNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
