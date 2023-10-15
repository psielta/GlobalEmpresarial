using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class LocacaoOrcamento
{
    public int? IdLoc { get; set; }

    public int? IdOrcamento { get; set; }

    public int? IdProduto { get; set; }

    public DateOnly? DtEntrega { get; set; }

    public DateOnly? DtRetirada { get; set; }

    public string? TipoUtilizacao { get; set; }

    public decimal? TaxaDiaExcedente { get; set; }

    public decimal? Qtd { get; set; }

    public decimal? Valor { get; set; }

    public decimal? Desconto { get; set; }

    public decimal? ValorTotal { get; set; }

    public string? Status { get; set; }

    public string? Obs { get; set; }

    public int? DiasPermanencia { get; set; }

    public string? FormaPgto { get; set; }

    public string? Tipo { get; set; }

    public int? CdMecanico { get; set; }

    public string? Pagou { get; set; }

    public string? HrEntrega { get; set; }

    public string? HrRetirada { get; set; }

    public string? HorasPermanencia { get; set; }

    public decimal? ValorHora { get; set; }

    public int? IdEnderecoEntrega { get; set; }
}
