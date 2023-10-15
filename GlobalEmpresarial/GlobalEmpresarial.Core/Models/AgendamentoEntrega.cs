using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class AgendamentoEntrega
{
    public int NrAgenda { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Hora { get; set; }

    public int CdEmpresa { get; set; }

    public int? CdCliente { get; set; }

    public string Status { get; set; } = null!;

    public string? TxtObs { get; set; }

    public DateOnly? DtEntrega { get; set; }

    public TimeOnly? HrEntrega { get; set; }

    public string? FormaPagamento { get; set; }

    public string? Entrega { get; set; }

    public decimal? VlTotal { get; set; }

    public string? TxtObsFechamento { get; set; }

    public string? Endereco { get; set; }

    public int? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Telefone { get; set; }

    public string? NmCliente { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<ProdAgendaEntrega> ProdAgendaEntregas { get; set; } = new List<ProdAgendaEntrega>();
}
