using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class VendaMobileCab
{
    public int Id { get; set; }

    public DateTime? DtRecebimento { get; set; }

    public string Status { get; set; } = null!;

    public int IdVendaMobile { get; set; }

    public int IdVendedor { get; set; }

    public DateOnly? DtVenda { get; set; }

    public TimeOnly? HrVenda { get; set; }

    public int IdCliente { get; set; }

    public string? TxtObs { get; set; }

    public decimal? VlDescontoGeral { get; set; }

    public int? IdFormaPgt { get; set; }

    public string? Alterado { get; set; }

    public int? IdPedido { get; set; }

    public int? TpImp { get; set; }

    public virtual ICollection<VendaMobileDetalhe> VendaMobileDetalhes { get; set; } = new List<VendaMobileDetalhe>();
}
