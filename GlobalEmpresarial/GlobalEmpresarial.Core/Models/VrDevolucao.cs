using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VrDevolucao
{
    public int Id { get; set; }

    public long IdVr { get; set; }

    public int CdCliente { get; set; }

    public int CdProduto { get; set; }

    public decimal? VlProduto { get; set; }

    public decimal? Qtde { get; set; }

    public decimal? VlDesconto { get; set; }

    public DateOnly? DtVr { get; set; }

    public DateOnly? DtDevolucao { get; set; }

    public int? CdVendedor { get; set; }

    public int? NrAbertura { get; set; }

    public int Caixa { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
