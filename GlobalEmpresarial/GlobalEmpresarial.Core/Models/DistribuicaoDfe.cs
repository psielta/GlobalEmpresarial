using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DistribuicaoDfe
{
    public int Id { get; set; }

    public string? Serie { get; set; }

    public string? NrNotaFiscal { get; set; }

    public string? ChaveAcessoNfe { get; set; }

    public string? Cnpj { get; set; }

    public string? Nome { get; set; }

    public string? Ie { get; set; }

    public string? TpNfe { get; set; }

    public string? Nsu { get; set; }

    public string? Emissao { get; set; }

    public decimal? Valor { get; set; }

    public string? Impresso { get; set; }

    public string? TpResposta { get; set; }

    public string? Manifesto { get; set; }

    public string? Transferiu { get; set; }

    public DateOnly? DtRecebimento { get; set; }

    public string? Xml { get; set; }

    public DateOnly? DtInclusao { get; set; }
}
