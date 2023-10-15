using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmEspecie
{
    public int Id { get; set; }

    public string Descricao { get; set; } = null!;

    public virtual ICollection<FmAnimal> FmAnimals { get; set; } = new List<FmAnimal>();

    public virtual ICollection<FmMedContraindicaco> FmMedContraindicacos { get; set; } = new List<FmMedContraindicaco>();

    public virtual ICollection<FmRaca> FmRacas { get; set; } = new List<FmRaca>();
}
