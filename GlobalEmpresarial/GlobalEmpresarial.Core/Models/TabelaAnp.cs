using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TabelaAnp
{
    public int Id { get; set; }

    public int? Codigo { get; set; }

    public string? Produto { get; set; }

    public string? Familia { get; set; }

    public string? Grupo { get; set; }

    public string? SubGrupo { get; set; }

    public string? SubSubgrupo { get; set; }

    public string? UnidadeGrandeza { get; set; }

    public string? UnidadeMedidaSimp { get; set; }

    public string? Ramo { get; set; }

    public string? DataInicioValidade { get; set; }

    public string? DataFinalValidade { get; set; }
}
