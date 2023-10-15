﻿using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class ProdutoSaidum
{
    public int Nr { get; set; }

    public int NrSaida { get; set; }

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

    public string? ItemPedido { get; set; }

    public string? Pedido { get; set; }

    public decimal? St { get; set; }

    public decimal? IcmsSubstituto { get; set; }

    public int? Coo { get; set; }

    public decimal? QuantEntregue { get; set; }

    public decimal? QuantDevolvido { get; set; }

    public decimal? PorcDesc { get; set; }

    public decimal? DescRateio { get; set; }

    public string? IdSerieProduto { get; set; }

    public string? DescComplementoNome { get; set; }

    public string? UtilizarIdInternoNfe { get; set; }

    public string? IdSerieKit { get; set; }

    public int? TpOperacaoVeic { get; set; }

    public string? ChasiVeic { get; set; }

    public string? CorVeic { get; set; }

    public string? DescCorVeic { get; set; }

    public string? PotenciaMotorVeic { get; set; }

    public string? CilindradasVeic { get; set; }

    public decimal? PesoLiquidoVeic { get; set; }

    public decimal? PesoBrutoVeic { get; set; }

    public string? SerialVeic { get; set; }

    public string? TpCombustVeic { get; set; }

    public string? NrMotorVeic { get; set; }

    public decimal? CapcMaxTracVeic { get; set; }

    public string? DistEixosVeic { get; set; }

    public string? AnoVeic { get; set; }

    public string? AnoFabVeic { get; set; }

    public string? TpPinturaVeic { get; set; }

    public string? TpVeic { get; set; }

    public string? EspecVeic { get; set; }

    public string? IdVinVeic { get; set; }

    public string? CondVeic { get; set; }

    public string? IdMarcaVeic { get; set; }

    public string? IdCorVeic { get; set; }

    public string? CapcMaxLotVeic { get; set; }

    public string? RestricaoVeic { get; set; }

    public string? BaixaEstoque { get; set; }

    public virtual Empresa CdEmpresaNavigation { get; set; } = null!;

    public virtual ProdutoEstoque CdProdutoNavigation { get; set; } = null!;

    public virtual Saida NrSaidaNavigation { get; set; } = null!;
}
