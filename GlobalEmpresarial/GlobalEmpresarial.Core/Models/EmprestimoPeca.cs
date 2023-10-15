using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EmprestimoPeca
{
    public int Nr { get; set; }

    public int CdEmpresa { get; set; }

    public int CdCliente { get; set; }

    public DateOnly? Data { get; set; }

    public int CdProduto { get; set; }

    public decimal Quant { get; set; }

    public DateOnly? DtDevol { get; set; }

    public int CdFunc { get; set; }

    public string? TxtObs { get; set; }

    public string? Status { get; set; }

    public string? Lote { get; set; }

    public DateOnly? DtValidade { get; set; }

    public int? CdPlano { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual Funcionario CdFuncNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;
}
