using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Aluno
{
    public int Id { get; set; }

    public int CdEmpresa { get; set; }

    public string Nome { get; set; } = null!;

    public DateOnly? DtNascimento { get; set; }

    public DateOnly? DtMatricula { get; set; }

    public string? Sexo { get; set; }

    public string? NmMae { get; set; }

    public string? NmPai { get; set; }

    public int IdRespPagante { get; set; }

    public string? Ativo { get; set; }

    public decimal? Peso { get; set; }

    public decimal? Altura { get; set; }

    public decimal? VlMensalidade { get; set; }

    public string? DaDesconto { get; set; }

    public virtual ICollection<AvaliacaoFisica> AvaliacaoFisicas { get; set; } = new List<AvaliacaoFisica>();

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<HoraAlunoMatricula> HoraAlunoMatriculas { get; set; } = new List<HoraAlunoMatricula>();

    public virtual Cliente IdRespPaganteNavigation { get; set; } = null!;

    public virtual ICollection<QuestAlunoMatricula> QuestAlunoMatriculas { get; set; } = new List<QuestAlunoMatricula>();
}
