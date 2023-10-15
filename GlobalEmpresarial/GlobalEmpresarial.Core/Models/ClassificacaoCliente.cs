using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ClassificacaoCliente
{
    public int CdClassificacao { get; set; }

    public string? NmClassificacao { get; set; }

    public string? Cor { get; set; }

    public decimal? DescontoClassificacao { get; set; }
}
