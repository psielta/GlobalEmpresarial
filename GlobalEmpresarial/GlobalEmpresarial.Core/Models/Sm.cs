using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Sm
{
    public int NrLanc { get; set; }

    public int NrCliente { get; set; }

    public string? NrCelular { get; set; }

    public string? Mensagem { get; set; }

    public int? Usuario { get; set; }

    public DateTime? DataEnvio { get; set; }

    public string? Enviado { get; set; }
}
