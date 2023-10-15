using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ModeloAutomovel
{
    public int Codigo { get; set; }

    public int CdMarca { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Automovel> Automovels { get; set; } = new List<Automovel>();

    public virtual MarcaAutomovel CdMarcaNavigation { get; set; } = null!;

    public virtual ICollection<FrotaEmpresa> FrotaEmpresas { get; set; } = new List<FrotaEmpresa>();

    public virtual ICollection<ModeloVeicProduto> ModeloVeicProdutos { get; set; } = new List<ModeloVeicProduto>();
}
