using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MdfeRodoviario
{
    public int Id { get; set; }

    public int IdMdfe { get; set; }

    public string? Rntrc { get; set; }

    public string? Ciot { get; set; }

    public string? Cint { get; set; }

    public string? Placa { get; set; }

    public string? Renavam { get; set; }

    public decimal? Tara { get; set; }

    public decimal? Capkg { get; set; }

    public decimal? Capm3 { get; set; }

    public string Tprod { get; set; } = null!;

    public string? Tpcar { get; set; }

    public string? Uf { get; set; }

    public decimal? PesoTotal { get; set; }

    public decimal? ValorCarga { get; set; }

    public string? PropCpfcnpj { get; set; }

    public string? PropRntrc { get; set; }

    public string? PropNome { get; set; }

    public string? PropUf { get; set; }

    public string? PropIe { get; set; }

    public string? PropTipo { get; set; }

    public virtual Mdfe IdMdfeNavigation { get; set; } = null!;
}
