using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EntradaOutrasDesp
{
    public int NrEntrada { get; set; }

    public DateOnly DtEntrada { get; set; }

    public int CdFornecedor { get; set; }

    public string NrNotaFiscal { get; set; } = null!;

    public string? ModeloNf { get; set; }

    public string? Serie { get; set; }

    public string? Subserie { get; set; }

    public string? NrNotaFiscalEntrada { get; set; }

    public string Cfop { get; set; } = null!;

    public decimal ValorTotal { get; set; }

    public decimal BaseIcms { get; set; }

    public decimal PorcIcms { get; set; }

    public decimal ValorIcms { get; set; }

    public decimal VlIsentaNTrib { get; set; }

    public decimal VlOutras { get; set; }

    public int TpFrete { get; set; }

    public string? CdTipoNf { get; set; }

    public int CdEmpresa { get; set; }

    public string? ChaveCte { get; set; }

    public string? CdCidadeOrigem { get; set; }

    public string? CdCidadeDestino { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual Fornecedor CdFornecedorNavigation { get; set; } = null!;
}
