using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmVeterinario
{
    public int Id { get; set; }

    public string Veterinario { get; set; } = null!;

    public string Crmv { get; set; } = null!;

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public string? Numero { get; set; }

    public string? Bairro { get; set; }

    public string? Cidade { get; set; }

    public string? Cep { get; set; }

    public string? NregSipeagro { get; set; }

    public virtual ICollection<FmOrdemManipulacao> FmOrdemManipulacaos { get; set; } = new List<FmOrdemManipulacao>();
}
