using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VendaConsumidorCab
{
    public int NrLanc { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Hora { get; set; }

    public int CdEmpresa { get; set; }

    public int CdCliente { get; set; }

    public string? NrOrdem { get; set; }

    public string? NrSerie { get; set; }

    public string? SubSerie { get; set; }

    public string? Cfop { get; set; }

    public decimal? BaseIcms { get; set; }

    public decimal? ValorIcms { get; set; }

    public int CdOperador { get; set; }

    public string? Status { get; set; }

    public string? Baixa { get; set; }

    public string? Cancelada { get; set; }

    public string? TipoNota { get; set; }

    public int? IdEcf { get; set; }

    public string? DescPg { get; set; }

    public string? DescNf { get; set; }

    public virtual Cliente CdClienteNavigation { get; set; } = null!;

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<DadosVendConsumidor> DadosVendConsumidors { get; set; } = new List<DadosVendConsumidor>();
}
