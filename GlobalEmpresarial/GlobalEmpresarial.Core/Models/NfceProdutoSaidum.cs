﻿using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NfceProdutoSaidum
{
    public int Id { get; set; }

    public int IdSaida { get; set; }

    public int CdProduto { get; set; }

    public int CdPlano { get; set; }

    public decimal Quant { get; set; }

    public decimal VlVenda { get; set; }

    public decimal Desconto { get; set; }

    public decimal VlTotal { get; set; }

    public string Lote { get; set; } = null!;

    public DateOnly DtValidade { get; set; }

    public int CdEmpresa { get; set; }

    public string NmProduto { get; set; } = null!;

    public string? Pagou { get; set; }

    public decimal? VlCusto { get; set; }

    public decimal? QuantEstorno { get; set; }

    public string? Cst { get; set; }

    public string? Cfop { get; set; }

    public string? Un { get; set; }

    public string? Ncm { get; set; }

    public decimal? VlComissao { get; set; }

    public decimal? PocIcms { get; set; }

    public decimal? VlBaseIcms { get; set; }

    public decimal? VlIcms { get; set; }

    public string? IpiSiTribut { get; set; }

    public string? IpiClasEnqua { get; set; }

    public string? CdSeloIpi { get; set; }

    public short? QtdeSeloIpi { get; set; }

    public string? CdEnquadraIpi { get; set; }

    public decimal? VlUnid { get; set; }

    public string? CnpjProd { get; set; }

    public decimal? VlBaseIpi { get; set; }

    public decimal? PorcIpi { get; set; }

    public decimal? VlIpi { get; set; }

    public decimal? VlBaseSt { get; set; }

    public decimal? PorcSt { get; set; }

    public decimal? VlSt { get; set; }

    public decimal? PocReducao { get; set; }

    public decimal? MvaSt { get; set; }

    public short? NrItem { get; set; }

    public string? Cancelou { get; set; }

    public string? EOrOs { get; set; }

    public decimal? VlBaseRetido { get; set; }

    public decimal? VlIcmsRet { get; set; }

    public string? CdCsosn { get; set; }

    public decimal? PcreditoIcms { get; set; }

    public decimal? VlCreditoIcms { get; set; }

    public decimal? VlAproxImposto { get; set; }

    public decimal? PorcIbpt { get; set; }

    public decimal? QtTotal { get; set; }

    public string? CdTipSt { get; set; }

    public decimal? VlBasePis { get; set; }

    public decimal? VlPis { get; set; }

    public decimal? PorcPis { get; set; }

    public string? CstPis { get; set; }

    public string? CdContSocialApPis { get; set; }

    public decimal? VlBaseCofins { get; set; }

    public decimal? VlCofins { get; set; }

    public decimal? PorcCofins { get; set; }

    public string? CstCofins { get; set; }

    public string? CdContSocialApCofins { get; set; }

    public decimal? VlBasePisSt { get; set; }

    public decimal? VlPisSt { get; set; }

    public decimal? PorcPisSt { get; set; }

    public decimal? VlBaseCofinsSt { get; set; }

    public decimal? VlCofinsSt { get; set; }

    public decimal? PorcCofinsSt { get; set; }

    public string? Cest { get; set; }

    public decimal? Vbcufdest { get; set; }

    public decimal? Picmsufdest { get; set; }

    public decimal? Vicmsufdest { get; set; }

    public decimal? Vicmsufremt { get; set; }

    public decimal? Vbcfcpufdest { get; set; }

    public decimal? Pfcpufdest { get; set; }

    public decimal? Vfcpufdest { get; set; }

    public decimal? Picmsinter { get; set; }

    public decimal? Picmsinterpart { get; set; }

    public string? CdInterno { get; set; }

    public int? SequenciaItem { get; set; }

    public decimal? IcmsSubstituto { get; set; }

    public decimal? St { get; set; }

    public virtual NfceSaida IdSaidaNavigation { get; set; } = null!;
}
