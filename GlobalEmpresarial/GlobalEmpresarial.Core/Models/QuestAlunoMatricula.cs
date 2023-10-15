using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class QuestAlunoMatricula
{
    public int Id { get; set; }

    public int IdAluno { get; set; }

    public string AlunoFazAtvFisica { get; set; } = null!;

    public string? TxtRestricao { get; set; }

    public string EntregouAtestado { get; set; } = null!;

    public DateOnly? DtAtestado { get; set; }

    public virtual Aluno IdAlunoNavigation { get; set; } = null!;
}
