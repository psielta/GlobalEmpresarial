using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfConfiguracao
{
    public int Id { get; set; }

    public int? IdEcfImpressora { get; set; }

    public int? IdEcfResolucao { get; set; }

    public int? IdEcfCaixa { get; set; }

    public int? IdEcfEmpresa { get; set; }

    public string? MensagemCupom { get; set; }

    public string? PortaEcf { get; set; }

    public string? IpServidor { get; set; }

    public string? IpSitef { get; set; }

    public string? TipoTef { get; set; }

    public string? TituloTelaCaixa { get; set; }

    public string? CaminhoImagensProdutos { get; set; }

    public string? CaminhoImagensMarketing { get; set; }

    public string? CaminhoImagensLayout { get; set; }

    public string? CorJanelasInternas { get; set; }

    public string? MarketingAtivo { get; set; }

    public int? CfopEcf { get; set; }

    public int? CfopNf2 { get; set; }

    public int? TimeoutEcf { get; set; }

    public int? IntervaloEcf { get; set; }

    public string? DescricaoSuprimento { get; set; }

    public string? DescricaoSangria { get; set; }

    public int? TefTipoGp { get; set; }

    public int? TefTempoEspera { get; set; }

    public int? TefEsperaSts { get; set; }

    public int? TefNumeroVias { get; set; }

    public int? DecimaisQuantidade { get; set; }

    public int? DecimaisValor { get; set; }

    public int? BitsPorSegundo { get; set; }

    public int? QtdeMaximaCartoes { get; set; }

    public string? PesquisaParte { get; set; }

    public string? ConfiguracaoBalanca { get; set; }

    public string? ParametrosDiversos { get; set; }

    public int? UltimaExclusao { get; set; }

    public string? Laudo { get; set; }

    public string? IndiceGerencial { get; set; }

    public DateOnly? DataAtualizacaoEstoque { get; set; }

    public string? Sincronizado { get; set; }

    public string? HoraAt { get; set; }

    public char? Notamanual { get; set; }

    public int? RamoEmpresa { get; set; }

    public string? PortaPosto { get; set; }

    public int? Increment { get; set; }

    public string? Touch { get; set; }

    public string? ComandaAbertura { get; set; }

    public string? PortaBalComanda { get; set; }

    public string? BaudBalComanda { get; set; }

    public string? DataBalComanda { get; set; }

    public string? PartyBalComanda { get; set; }

    public string? StopBalComanda { get; set; }

    public string? HandBalComanda { get; set; }

    public string? TimeBalComanda { get; set; }

    public string? BalancaComanda { get; set; }

    public string? DavEcf { get; set; }

    public string? VendaEstoqueZerado { get; set; }

    public string? ModoFacil { get; set; }

    public string? Integrador { get; set; }

    public int? IdImpressoraDocumentoDia { get; set; }

    public string? SerieEcf { get; set; }

    public string? Ss { get; set; }

    public string? ControleComanda { get; set; }

    public string? ControleCancItem { get; set; }

    public string? MascaraLoginGerente { get; set; }

    public string? DesabilitarLogin { get; set; }

    public string? DesabilitarLoginGs { get; set; }

    public string? Arredondaqtde { get; set; }

    public string? Teclageral { get; set; }

    public string? TaxaServico { get; set; }

    public decimal? TaxaServicoValor { get; set; }

    public string? BaixarEstoqueRetaguarda { get; set; }

    public string? Rzautomaticamente { get; set; }

    public string? DoacaoCartao { get; set; }
}
