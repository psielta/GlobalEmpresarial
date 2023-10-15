using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfPosicaoComponente
{
    public int Id { get; set; }

    public int? IdEcfResolucao { get; set; }

    public string? Nome { get; set; }

    public int? Altura { get; set; }

    public int? Largura { get; set; }

    public int? Topo { get; set; }

    public int? Esquerda { get; set; }

    public int? TamanhoFonte { get; set; }

    public string? Texto { get; set; }

    public string? Integrador { get; set; }
}
