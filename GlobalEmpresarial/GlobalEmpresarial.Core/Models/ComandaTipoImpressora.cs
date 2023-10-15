using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComandaTipoImpressora
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public string? Mesa { get; set; }

    public string? Cartao { get; set; }

    public string? Balcao { get; set; }

    public string? Delivery { get; set; }

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;
}
