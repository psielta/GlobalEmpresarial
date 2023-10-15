using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PerdaMedControlado
{
    public int NrLanc { get; set; }

    public int CdEmrpesa { get; set; }

    public DateOnly? DtLanc { get; set; }

    public TimeOnly? HrLanc { get; set; }

    public int CdMotivo { get; set; }

    public int CdProduto { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValidade { get; set; }

    public decimal Quantidade { get; set; }

    public string Unidade { get; set; } = null!;

    public int CdPlano { get; set; }

    public virtual Empresa CdEmrpesaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
