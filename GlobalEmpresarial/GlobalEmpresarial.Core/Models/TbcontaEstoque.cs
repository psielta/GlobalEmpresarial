using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TbcontaEstoque
{
    public int Id { get; set; }

    public int IdProduto { get; set; }

    public int IdPlano { get; set; }

    public int IdEmpresa { get; set; }

    public decimal SaldoAnterior { get; set; }

    public decimal SaldoNovo { get; set; }

    public DateOnly? DataLanc { get; set; }

    public TimeOnly? HoraLanc { get; set; }

    public int IdUsuario { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque IdProdutoNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
