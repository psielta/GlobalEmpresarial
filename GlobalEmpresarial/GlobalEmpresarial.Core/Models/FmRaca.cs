using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmRaca
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public int? IdEspecie { get; set; }

    public virtual ICollection<FmAnimal> FmAnimals { get; set; } = new List<FmAnimal>();

    public virtual FmEspecie? IdEspecieNavigation { get; set; }
}
