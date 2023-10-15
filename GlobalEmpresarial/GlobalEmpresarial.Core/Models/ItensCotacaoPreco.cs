using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ItensCotacaoPreco
{
    public int Nr { get; set; }

    public int NrCab { get; set; }

    public int CdFornecedor { get; set; }

    public decimal Valor { get; set; }

    public int Posicao { get; set; }

    public virtual Fornecedor CdFornecedorNavigation { get; set; } = null!;

    public virtual CabCotacaoPreco NrCabNavigation { get; set; } = null!;
}
