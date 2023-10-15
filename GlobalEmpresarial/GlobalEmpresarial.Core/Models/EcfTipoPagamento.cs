using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfTipoPagamento
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descricao { get; set; }

    public string? Tef { get; set; }

    public string? ImprimeVinculado { get; set; }

    public string? PermiteTroco { get; set; }

    public string? TefTipoGp { get; set; }

    public string? GeraParcelas { get; set; }

    public string? Integrador { get; set; }

    public int? HashIncremento { get; set; }

    public string? MfAdicional { get; set; }

    public string? ModeloEcf { get; set; }

    public int? Usuario { get; set; }
}
