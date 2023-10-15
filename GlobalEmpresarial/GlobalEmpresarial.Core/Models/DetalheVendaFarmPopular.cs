using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class DetalheVendaFarmPopular
{
    public int Nr { get; set; }

    public int NrCabecalho { get; set; }

    public int CdMedico { get; set; }

    public DateOnly DtPrescricao { get; set; }

    public int CdProduto { get; set; }

    public decimal VlVendaApres { get; set; }

    public decimal QtSolicitado { get; set; }

    public decimal QtDiariaPrescrita { get; set; }

    public string? StatusTransmissao { get; set; }

    public string? CodSolicitadoDatasus { get; set; }

    public string? StatusTransmissaoMed { get; set; }

    public decimal? QtAutorizadoSus { get; set; }

    public decimal? VlTotalSus { get; set; }

    public decimal? VlTotalPacSus { get; set; }

    public decimal VlUnitario { get; set; }

    public string? CodAutorizacaoSus { get; set; }

    public string? CodConfEstorno { get; set; }

    public string? CodEstornoDatasus { get; set; }

    public string? Estornou { get; set; }

    public virtual Medico CdMedicoNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual VendaFarmaciaPopular NrCabecalhoNavigation { get; set; } = null!;
}
