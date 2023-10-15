using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NcmProtocoloEstado
{
    public int Id { get; set; }

    public int IdCabProtocolo { get; set; }

    public string IdNcm { get; set; } = null!;

    public virtual ProtocoloEstadoNcm IdCabProtocoloNavigation { get; set; } = null!;
}
