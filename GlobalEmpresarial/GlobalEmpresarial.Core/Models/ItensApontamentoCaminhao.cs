using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ItensApontamentoCaminhao
{
    public int Nr { get; set; }

    public int NrCab { get; set; }

    public string Local { get; set; } = null!;

    public int CdMaterial { get; set; }

    public decimal Quant { get; set; }

    public decimal KmInicial { get; set; }

    public decimal KmFinal { get; set; }

    public TimeOnly HrInicial { get; set; }

    public TimeOnly HrFinal { get; set; }

    public int? QtdViagem { get; set; }

    public TimeOnly? HrDescanso { get; set; }

    public DateOnly? DtLanc { get; set; }

    public virtual MaterialTerraplenagem CdMaterialNavigation { get; set; } = null!;

    public virtual ApontamentosCaminhao NrCabNavigation { get; set; } = null!;
}
