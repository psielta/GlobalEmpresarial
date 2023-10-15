using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfeSeguro
{
    public int Id { get; set; }

    public int? IdMdfe { get; set; }

    public string? Responsavel { get; set; }

    public string? NmSeguradora { get; set; }

    public string? NrApolice { get; set; }

    public string? NrAverbacao { get; set; }

    public decimal? VlMercadoria { get; set; }

    public string? Cnpj { get; set; }
}
