using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ItensBalanco
{
    public int Codbalanco { get; set; }

    public int Iditem { get; set; }

    public int? CdProduto { get; set; }

    public int? CdEmpresa { get; set; }

    public int? CdPlano { get; set; }

    public string? Lote { get; set; }

    public DateOnly? Validade { get; set; }

    public decimal? SaldoAtual { get; set; }

    public decimal? SaldoBalanco { get; set; }

    public decimal? SaldoDiferenca { get; set; }

    public string? NmProduto { get; set; }

    public virtual Balanco CodbalancoNavigation { get; set; } = null!;
}
