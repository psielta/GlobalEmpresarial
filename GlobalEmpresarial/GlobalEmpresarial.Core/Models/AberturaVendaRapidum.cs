using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class AberturaVendaRapidum
{
    public int NrLanc { get; set; }

    public DateTime? DataLanc { get; set; }

    public int CdEmpresa { get; set; }

    public DateOnly DataAbertura { get; set; }

    public TimeOnly HoraAbertura { get; set; }

    public DateOnly? DataEncerramento { get; set; }

    public TimeOnly? HoraEncerramento { get; set; }

    public string CdOperador { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal VlSuprimento { get; set; }

    public decimal? VlVendaFinal { get; set; }

    public string? CdGerente { get; set; }

    public decimal? VlVendaFinalCart { get; set; }

    public decimal? VlVendaFinalChq { get; set; }

    public decimal? VlVendaFinalPrazo { get; set; }

    public decimal? VlVendaFinalCartDeb { get; set; }

    public decimal? VlSangria { get; set; }

    public decimal? VlVendaFinalPix { get; set; }

    public decimal? VlVendaTicket { get; set; }

    public decimal? VlMoedas { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;
}
