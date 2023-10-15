using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ComandaImpressora
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public string? Endereco { get; set; }

    public string? Modelo { get; set; }

    public string? Ativa { get; set; }

    public int? Pulo { get; set; }

    public string? Ip { get; set; }
}
