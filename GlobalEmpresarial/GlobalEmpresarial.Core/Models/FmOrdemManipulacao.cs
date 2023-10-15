using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class FmOrdemManipulacao
{
    public int Id { get; set; }

    public decimal? Valor { get; set; }

    public string? NmUsuario { get; set; }

    public DateOnly DtPedido { get; set; }

    public TimeOnly HrPedido { get; set; }

    public DateOnly DtValidade { get; set; }

    public DateOnly? DtPreparacao { get; set; }

    public int IdCliente { get; set; }

    public int IdAnimal { get; set; }

    public string? NrReceitaControlada { get; set; }

    public int? IdFarmaceuticoQualidade { get; set; }

    public string? NrOrdemReceita { get; set; }

    public string Status { get; set; } = null!;

    public DateOnly? DtRetirada { get; set; }

    public string? Obs { get; set; }

    public int? IdVeterinario { get; set; }

    public string? TipoMed { get; set; }

    public TimeOnly? HrRetirada { get; set; }

    public string? Documento { get; set; }

    public virtual ICollection<FmOmBaixa> FmOmBaixas { get; set; } = new List<FmOmBaixa>();

    public virtual FmAnimal IdAnimalNavigation { get; set; } = null!;

    public virtual Cliente IdClienteNavigation { get; set; } = null!;

    public virtual FmVeterinario? IdVeterinarioNavigation { get; set; }

    public virtual Usuario? NmUsuarioNavigation { get; set; }
}
