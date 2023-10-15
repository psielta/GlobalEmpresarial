using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ItensOrcamento
{
    public int Nr { get; set; }

    public int NrOr { get; set; }

    public int CdProduto { get; set; }

    public decimal Quant { get; set; }

    public decimal Valor { get; set; }

    public decimal VlDesc { get; set; }

    public decimal VlTotal { get; set; }

    public int? CdPlano { get; set; }

    public string? Lote { get; set; }

    public DateOnly? DtValidade { get; set; }

    public int? CdEmpresa { get; set; }

    public decimal? VlCusto { get; set; }

    public decimal? VlComissao { get; set; }

    public string? IdSerieProduto { get; set; }

    public string? IdSerieConstrutor { get; set; }

    public int? IdTipoTabelaPreco { get; set; }

    public decimal? QtEntrega { get; set; }

    public decimal? QtRecolhimento { get; set; }

    public string? ObsProduto { get; set; }

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual ICollection<KitItensOrcamento> KitItensOrcamentos { get; set; } = new List<KitItensOrcamento>();

    public virtual Orcamento NrOrNavigation { get; set; } = null!;
}
