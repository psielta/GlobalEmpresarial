using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmAnimal
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public int IdCliente { get; set; }

    public int? IdRaca { get; set; }

    public int? IdEspecie { get; set; }

    public string? Idade { get; set; }

    public string? Peso { get; set; }

    public char? Sexo { get; set; }

    public string? Cor { get; set; }

    public string? Obs { get; set; }

    public virtual ICollection<FmOrdemManipulacao> FmOrdemManipulacaos { get; set; } = new List<FmOrdemManipulacao>();

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual FmEspecie? IdEspecieNavigation { get; set; }

    public virtual FmRaca? IdRacaNavigation { get; set; }
}
