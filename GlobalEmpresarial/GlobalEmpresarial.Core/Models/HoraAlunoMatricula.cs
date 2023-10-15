using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class HoraAlunoMatricula
{
    public int Id { get; set; }

    public int IdAluno { get; set; }

    public int DiaSemana { get; set; }

    public TimeOnly? HoraInicial { get; set; }

    public TimeOnly? HoraFinal { get; set; }

    public virtual Aluno IdAlunoNavigation { get; set; } = null!;
}
