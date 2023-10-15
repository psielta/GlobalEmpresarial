using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class AvaliacaoFisica
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public TimeOnly? Hora { get; set; }

    public int IdAluno { get; set; }

    public int IdCadTpAvalfisica { get; set; }

    public string Avaliacao { get; set; } = null!;

    public string? TxtObs { get; set; }

    public virtual Aluno IdAlunoNavigation { get; set; } = null!;

    public virtual CadTpAvalfisica IdCadTpAvalfisicaNavigation { get; set; } = null!;
}
