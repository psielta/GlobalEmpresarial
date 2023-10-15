using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TbVlVendum
{
    public int NrLanc { get; set; }

    public DateOnly? DtLanc { get; set; }

    public TimeOnly? HrLanc { get; set; }

    public int CdProduto { get; set; }

    public decimal VlAntigoAVista { get; set; }

    public decimal VlNovoAVista { get; set; }

    public decimal VlAntigoPrazo { get; set; }

    public decimal VlNovoPrazo { get; set; }

    public decimal VlAntigoCc { get; set; }

    public decimal VlNovoCc { get; set; }

    public decimal VlAntigoDb { get; set; }

    public decimal VlNovoDb { get; set; }
}
