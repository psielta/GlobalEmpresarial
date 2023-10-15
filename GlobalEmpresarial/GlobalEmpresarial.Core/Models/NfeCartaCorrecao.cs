using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NfeCartaCorrecao
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public string? Chave { get; set; }

    public string? Cnpj { get; set; }

    public string? Correcao { get; set; }

    public string? Numerosequencia { get; set; }

    public string? Lote { get; set; }

    public string? Protocolo { get; set; }

    public string? Nfe { get; set; }
}
