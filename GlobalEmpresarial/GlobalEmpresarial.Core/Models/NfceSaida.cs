﻿using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class NfceSaida
{
    public int Id { get; set; }

    public DateOnly? Data { get; set; }

    public int Empresa { get; set; }

    public int Cliente { get; set; }

    public string? Requisicao { get; set; }

    public string? Observacao { get; set; }

    public string TpSaida { get; set; } = null!;

    public string TpPagt { get; set; } = null!;

    public DateOnly DtSaida { get; set; }

    public DateOnly? DtPedido { get; set; }

    public string? TabelaVenda { get; set; }

    public string? Pagou { get; set; }

    public string? Cfop { get; set; }

    public int? CdCarga { get; set; }

    public string? TxtObsNf { get; set; }

    public int? CdVendedor { get; set; }

    public string? PagaComissao { get; set; }

    public string? NrNotaFiscal { get; set; }

    public string? ChaveAcessoNfe { get; set; }

    public string? CdUf { get; set; }

    public string? CdSituacao { get; set; }

    public string? TxtJustificativaCancelamento { get; set; }

    public string? NrProtoCancelamento { get; set; }

    public DateOnly? DtPagouComis { get; set; }

    public string? XmNf { get; set; }

    public decimal? VlOutro { get; set; }

    public decimal? VlDescGlobal { get; set; }

    public string? NrAutorizacaoNfe { get; set; }

    public int? IdPontoVenda { get; set; }

    public string? ChaveNfeSaida { get; set; }

    public int? IdConvenio { get; set; }

    public int? IdMedico { get; set; }

    public int? IdPaciente { get; set; }

    public DateOnly? DtCirugia { get; set; }

    public TimeOnly? HrSaida { get; set; }

    public string? NmVendedor { get; set; }

    public string? NrAberturaCaixa { get; set; }

    public int? NrCnf { get; set; }

    public string? NmOperador { get; set; }

    public int? Serie { get; set; }

    public string? Delivery { get; set; }

    public decimal? Frete { get; set; }

    public string? NrProtocoloInutilizacao { get; set; }

    public string? LocalSalvoNota { get; set; }

    public int? Caixa { get; set; }

    public string? Alterado { get; set; }

    public string? DescontoClassificacao { get; set; }

    public decimal? VlDescontoClassificacao { get; set; }

    public virtual ICollection<NfceProdutoSaidum> NfceProdutoSaida { get; set; } = new List<NfceProdutoSaidum>();
}
