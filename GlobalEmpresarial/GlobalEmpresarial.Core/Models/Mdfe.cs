using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class Mdfe
{
    public int Id { get; set; }

    public DateOnly? DtLanc { get; set; }

    public string? NrDmfe { get; set; }

    public TimeOnly? Hora { get; set; }

    public string? Status { get; set; }

    public string? Tpemit { get; set; }

    public string? Modelo { get; set; }

    public string? Serie { get; set; }

    public string? Modal { get; set; }

    public string? Tpemis { get; set; }

    public int IdEmpresa { get; set; }

    public string? Chnfe { get; set; }

    public string? XmlMdfe { get; set; }

    public string? Obs { get; set; }

    public string? NrAutorizacaoMdfe { get; set; }

    public string UfSaida { get; set; } = null!;

    public string UfFinal { get; set; } = null!;

    public string? Tptransp { get; set; }

    public string? NrProtoCancelamento { get; set; }

    public string? TxtJustificativaCancelamento { get; set; }

    public string? NrProtoEncerramento { get; set; }

    public int? NrCmdf { get; set; }

    public int? ProdTpCarga { get; set; }

    public string? ProdDescricao { get; set; }

    public string? ProdCean { get; set; }

    public string? ProdNcm { get; set; }

    public string? ProdCepcar { get; set; }

    public string? ProdCepdes { get; set; }

    public virtual Empresa IdEmpresaNavigation { get; set; } = null!;

    public virtual ICollection<MdfeCondutor> MdfeCondutors { get; set; } = new List<MdfeCondutor>();

    public virtual ICollection<MdfeInfcarregamento> MdfeInfcarregamentos { get; set; } = new List<MdfeInfcarregamento>();

    public virtual ICollection<MdfeReboque> MdfeReboques { get; set; } = new List<MdfeReboque>();

    public virtual ICollection<MdfeRodoviario> MdfeRodoviarios { get; set; } = new List<MdfeRodoviario>();
}
