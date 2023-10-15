using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TipoEtiquetum
{
    public int Id { get; set; }

    public string? Nome { get; set; }

    public double? MargemSuperior { get; set; }

    public double? MargemLateral { get; set; }

    public double? Altura { get; set; }

    public double? Largura { get; set; }

    public double? EspacoHorizontal { get; set; }

    public double? EspacoVertical { get; set; }

    public int? Colunas { get; set; }

    public double? TamanhoFonte { get; set; }

    public int? TipoPapel { get; set; }
}
