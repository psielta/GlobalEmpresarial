using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class MarcaAutomovel
{
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Automovel> Automovels { get; set; } = new List<Automovel>();

    public virtual ICollection<FrotaEmpresa> FrotaEmpresas { get; set; } = new List<FrotaEmpresa>();

    public virtual ICollection<ModeloAutomovel> ModeloAutomovels { get; set; } = new List<ModeloAutomovel>();

    public virtual ICollection<ModeloVeicProduto> ModeloVeicProdutos { get; set; } = new List<ModeloVeicProduto>();
}
