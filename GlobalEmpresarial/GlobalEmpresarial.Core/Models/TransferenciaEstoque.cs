using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TransferenciaEstoque
{
    public int NrLanc { get; set; }

    public DateOnly? DtTranf { get; set; }

    public TimeOnly? HrTransf { get; set; }

    public int CdEmpresa { get; set; }

    public int CdPlanoSaida { get; set; }

    public int CdPlanoEntrada { get; set; }

    public string Transferiu { get; set; } = null!;

    public string? AcertouRet { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual PlanoEstoque CdPlanoEntradaNavigation { get; set; } = null!;

    public virtual PlanoEstoque CdPlanoSaidaNavigation { get; set; } = null!;

    public virtual ICollection<ProdutoTransferencium> ProdutoTransferencia { get; set; } = new List<ProdutoTransferencium>();
}
