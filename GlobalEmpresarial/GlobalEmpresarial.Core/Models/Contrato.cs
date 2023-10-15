using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Contrato
{
    public int NrLanc { get; set; }

    public int CdCliente { get; set; }

    public DateOnly DtInicial { get; set; }

    public DateOnly DtFinal { get; set; }

    public decimal VlMes { get; set; }

    public int CdProjeto { get; set; }

    public string? TxtObjeto { get; set; }

    public string Ativo { get; set; } = null!;

    public string? NrContrato { get; set; }

    public string? TxtObs { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Projeto CdProjetoNavigation { get; set; } = null!;
}
