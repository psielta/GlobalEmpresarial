using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProtocoloEstadoNcm
{
    public int Id { get; set; }

    public string Ativo { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Uf { get; set; } = null!;

    public decimal? Iva { get; set; }

    public decimal? St { get; set; }

    public decimal? RedSt { get; set; }

    public decimal? RedIcms { get; set; }

    public string? TxtObs { get; set; }

    public virtual ICollection<NcmProtocoloEstado> NcmProtocoloEstados { get; set; } = new List<NcmProtocoloEstado>();
}
