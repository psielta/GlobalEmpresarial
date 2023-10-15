using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfeChafe
{
    public int Id { get; set; }

    public int? IdMdfe { get; set; }

    public string? Chave { get; set; }

    public string? Cnpj { get; set; }

    public string? IdMunicipio { get; set; }

    public string? Tipo { get; set; }
}
