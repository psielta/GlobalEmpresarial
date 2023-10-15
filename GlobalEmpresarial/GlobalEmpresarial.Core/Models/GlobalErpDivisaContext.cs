using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GlobalEmpresarial.Core.Models;

public partial class GlobalErpDivisaContext : DbContext
{
    public GlobalErpDivisaContext()
    {
    }

    public GlobalErpDivisaContext(DbContextOptions<GlobalErpDivisaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Abastecimento> Abastecimentos { get; set; }

    public virtual DbSet<AbastecimentoFrotaEmp> AbastecimentoFrotaEmps { get; set; }

    public virtual DbSet<Abertura> Aberturas { get; set; }

    public virtual DbSet<AberturaVendaRapidum> AberturaVendaRapida { get; set; }

    public virtual DbSet<AgendamentoEntrega> AgendamentoEntregas { get; set; }

    public virtual DbSet<AgendarRevisao> AgendarRevisaos { get; set; }

    public virtual DbSet<AlteracaoPrecoPdv> AlteracaoPrecoPdvs { get; set; }

    public virtual DbSet<Aluguel> Aluguels { get; set; }

    public virtual DbSet<Aluno> Alunos { get; set; }

    public virtual DbSet<ApontamentoMaquina> ApontamentoMaquinas { get; set; }

    public virtual DbSet<ApontamentosCaminhao> ApontamentosCaminhaos { get; set; }

    public virtual DbSet<Automovel> Automovels { get; set; }

    public virtual DbSet<AvaliacaoFisica> AvaliacaoFisicas { get; set; }

    public virtual DbSet<Balanco> Balancos { get; set; }

    public virtual DbSet<BandeiraCartao> BandeiraCartaos { get; set; }

    public virtual DbSet<BcoBoleto> BcoBoletos { get; set; }

    public virtual DbSet<Bico> Bicos { get; set; }

    public virtual DbSet<CabContagemEstMobile> CabContagemEstMobiles { get; set; }

    public virtual DbSet<CabCotacaoPreco> CabCotacaoPrecos { get; set; }

    public virtual DbSet<CabDevolucaoSaidum> CabDevolucaoSaida { get; set; }

    public virtual DbSet<CabVendaControlado> CabVendaControlados { get; set; }

    public virtual DbSet<CadEnderecoEntrega> CadEnderecoEntregas { get; set; }

    public virtual DbSet<CadEnderecoRetiradum> CadEnderecoRetirada { get; set; }

    public virtual DbSet<CadTpAvalfisica> CadTpAvalfisicas { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cbo> Cbos { get; set; }

    public virtual DbSet<CepCidade> CepCidades { get; set; }

    public virtual DbSet<Cest> Cests { get; set; }

    public virtual DbSet<CestNcm> CestNcms { get; set; }

    public virtual DbSet<Cfop> Cfops { get; set; }

    public virtual DbSet<CfopContaSpeed> CfopContaSpeeds { get; set; }

    public virtual DbSet<CfopSaidum> CfopSaida { get; set; }

    public virtual DbSet<CfopXCfopEntradum> CfopXCfopEntrada { get; set; }

    public virtual DbSet<ChequeProprio> ChequeProprios { get; set; }

    public virtual DbSet<Cidade> Cidades { get; set; }

    public virtual DbSet<ClassificacaoCliente> ClassificacaoClientes { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteCredito> ClienteCreditos { get; set; }

    public virtual DbSet<CodMunIbge> CodMunIbges { get; set; }

    public virtual DbSet<ComandaCabecalho> ComandaCabecalhos { get; set; }

    public virtual DbSet<ComandaDetalhe> ComandaDetalhes { get; set; }

    public virtual DbSet<ComandaFormapgt> ComandaFormapgts { get; set; }

    public virtual DbSet<ComandaImpressora> ComandaImpressoras { get; set; }

    public virtual DbSet<ComandaPerda> ComandaPerdas { get; set; }

    public virtual DbSet<ComandaTipoImpressora> ComandaTipoImpressoras { get; set; }

    public virtual DbSet<ComissaoVendedor> ComissaoVendedors { get; set; }

    public virtual DbSet<ComposicaoKitProduto> ComposicaoKitProdutos { get; set; }

    public virtual DbSet<ComposicaoProduto> ComposicaoProdutos { get; set; }

    public virtual DbSet<CondicaoTroca> CondicaoTrocas { get; set; }

    public virtual DbSet<ConfBalanca> ConfBalancas { get; set; }

    public virtual DbSet<ConfBoleto> ConfBoletos { get; set; }

    public virtual DbSet<ConfEmailNfe> ConfEmailNves { get; set; }

    public virtual DbSet<ConfIntegradorEcomerce> ConfIntegradorEcomerces { get; set; }

    public virtual DbSet<ConfNfe> ConfNves { get; set; }

    public virtual DbSet<ContaDoCaixa> ContaDoCaixas { get; set; }

    public virtual DbSet<Contador> Contadors { get; set; }

    public virtual DbSet<ContagemPrMobile> ContagemPrMobiles { get; set; }

    public virtual DbSet<ContasAPagar> ContasAPagars { get; set; }

    public virtual DbSet<ContasAReceber> ContasARecebers { get; set; }

    public virtual DbSet<Contrato> Contratos { get; set; }

    public virtual DbSet<ControleCheque> ControleCheques { get; set; }

    public virtual DbSet<ControleUsuario> ControleUsuarios { get; set; }

    public virtual DbSet<Convenio> Convenios { get; set; }

    public virtual DbSet<CredenciadoraCartao> CredenciadoraCartaos { get; set; }

    public virtual DbSet<Cst> Csts { get; set; }

    public virtual DbSet<CstConfin> CstConfins { get; set; }

    public virtual DbSet<CstIpi> CstIpis { get; set; }

    public virtual DbSet<CstPi> CstPis { get; set; }

    public virtual DbSet<Cte> Ctes { get; set; }

    public virtual DbSet<CteCompPrestacao> CteCompPrestacaos { get; set; }

    public virtual DbSet<CteDocAnterior> CteDocAnteriors { get; set; }

    public virtual DbSet<CteDocAnteriorNfe> CteDocAnteriorNves { get; set; }

    public virtual DbSet<CteDuplicatum> CteDuplicata { get; set; }

    public virtual DbSet<CteNf> CteNfs { get; set; }

    public virtual DbSet<CteNfe> CteNves { get; set; }

    public virtual DbSet<CteOb> CteObs { get; set; }

    public virtual DbSet<CteOrdemColetum> CteOrdemColeta { get; set; }

    public virtual DbSet<CteOutrosDoc> CteOutrosDocs { get; set; }

    public virtual DbSet<CtePassagem> CtePassagems { get; set; }

    public virtual DbSet<CteProdPerigoso> CteProdPerigosos { get; set; }

    public virtual DbSet<CteQtdCarga> CteQtdCargas { get; set; }

    public virtual DbSet<CteRodMotoristum> CteRodMotorista { get; set; }

    public virtual DbSet<CteRodVeiculo> CteRodVeiculos { get; set; }

    public virtual DbSet<CteSeguro> CteSeguros { get; set; }

    public virtual DbSet<CteValePedagio> CteValePedagios { get; set; }

    public virtual DbSet<CteVeiculo> CteVeiculos { get; set; }

    public virtual DbSet<CupomNfe> CupomNves { get; set; }

    public virtual DbSet<CurvaAbc> CurvaAbcs { get; set; }

    public virtual DbSet<DadosBancFornecedor> DadosBancFornecedors { get; set; }

    public virtual DbSet<DadosEcf> DadosEcfs { get; set; }

    public virtual DbSet<DadosVendConsumidor> DadosVendConsumidors { get; set; }

    public virtual DbSet<DavCabecalho> DavCabecalhos { get; set; }

    public virtual DbSet<DavDetalhe> DavDetalhes { get; set; }

    public virtual DbSet<Davmani> Davmanis { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<DescricaoDespesa> DescricaoDespesas { get; set; }

    public virtual DbSet<DetalheVendaFarmPopular> DetalheVendaFarmPopulars { get; set; }

    public virtual DbSet<DistribuicaoDfe> DistribuicaoDves { get; set; }

    public virtual DbSet<Diverso> Diversos { get; set; }

    public virtual DbSet<EcfAliquota> EcfAliquotas { get; set; }

    public virtual DbSet<EcfCaixa> EcfCaixas { get; set; }

    public virtual DbSet<EcfConfiguracao> EcfConfiguracaos { get; set; }

    public virtual DbSet<EcfFechamento> EcfFechamentos { get; set; }

    public virtual DbSet<EcfFuncionario> EcfFuncionarios { get; set; }

    public virtual DbSet<EcfImpressora> EcfImpressoras { get; set; }

    public virtual DbSet<EcfMovimento> EcfMovimentos { get; set; }

    public virtual DbSet<EcfOperador> EcfOperadors { get; set; }

    public virtual DbSet<EcfPosicaoComponente> EcfPosicaoComponentes { get; set; }

    public virtual DbSet<EcfResolucao> EcfResolucaos { get; set; }

    public virtual DbSet<EcfSuprimento> EcfSuprimentos { get; set; }

    public virtual DbSet<EcfTipoPagamento> EcfTipoPagamentos { get; set; }

    public virtual DbSet<EcfTotalTipoPgto> EcfTotalTipoPgtos { get; set; }

    public virtual DbSet<EcfTotalTipoPgtoSalve> EcfTotalTipoPgtoSalves { get; set; }

    public virtual DbSet<EcfTurno> EcfTurnos { get; set; }

    public virtual DbSet<EcfVendaCabecalho> EcfVendaCabecalhos { get; set; }

    public virtual DbSet<EcfVendaDetalhe> EcfVendaDetalhes { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Emprestimo> Emprestimos { get; set; }

    public virtual DbSet<EmprestimoPeca> EmprestimoPecas { get; set; }

    public virtual DbSet<Entrada> Entradas { get; set; }

    public virtual DbSet<EntradaOutrasDesp> EntradaOutrasDesps { get; set; }

    public virtual DbSet<Estado> Estados { get; set; }

    public virtual DbSet<FechamentoTerra> FechamentoTerras { get; set; }

    public virtual DbSet<FichaTecnica> FichaTecnicas { get; set; }

    public virtual DbSet<FmAnimal> FmAnimals { get; set; }

    public virtual DbSet<FmComplexo> FmComplexos { get; set; }

    public virtual DbSet<FmComponente> FmComponentes { get; set; }

    public virtual DbSet<FmEmbalagem> FmEmbalagems { get; set; }

    public virtual DbSet<FmEmbalagemRelacao> FmEmbalagemRelacaos { get; set; }

    public virtual DbSet<FmEspecie> FmEspecies { get; set; }

    public virtual DbSet<FmFormaFarmaceutica> FmFormaFarmaceuticas { get; set; }

    public virtual DbSet<FmFormaTamDosComponenteFk> FmFormaTamDosComponenteFks { get; set; }

    public virtual DbSet<FmFormaTamanhoFk> FmFormaTamanhoFks { get; set; }

    public virtual DbSet<FmHistEstoque> FmHistEstoques { get; set; }

    public virtual DbSet<FmIncompatibilidade> FmIncompatibilidades { get; set; }

    public virtual DbSet<FmItemComplexo> FmItemComplexos { get; set; }

    public virtual DbSet<FmItemForma> FmItemFormas { get; set; }

    public virtual DbSet<FmItemFormaTam> FmItemFormaTams { get; set; }

    public virtual DbSet<FmItemOm> FmItemOms { get; set; }

    public virtual DbSet<FmMedContraindicaco> FmMedContraindicacoes { get; set; }

    public virtual DbSet<FmMedOm> FmMedOms { get; set; }

    public virtual DbSet<FmMedicamento> FmMedicamentos { get; set; }

    public virtual DbSet<FmMedicamentoFfarmaceuticaFk> FmMedicamentoFfarmaceuticaFks { get; set; }

    public virtual DbSet<FmOmBaixa> FmOmBaixas { get; set; }

    public virtual DbSet<FmOrdemManipulacao> FmOrdemManipulacaos { get; set; }

    public virtual DbSet<FmPerda> FmPerdas { get; set; }

    public virtual DbSet<FmPosologium> FmPosologia { get; set; }

    public virtual DbSet<FmRaca> FmRacas { get; set; }

    public virtual DbSet<FmTamanhoFormaFarmaceutica> FmTamanhoFormaFarmaceuticas { get; set; }

    public virtual DbSet<FmVeterinario> FmVeterinarios { get; set; }

    public virtual DbSet<FormaPagt> FormaPagts { get; set; }

    public virtual DbSet<Fornecedor> Fornecedors { get; set; }

    public virtual DbSet<Frete> Fretes { get; set; }

    public virtual DbSet<FrotaEmpresa> FrotaEmpresas { get; set; }

    public virtual DbSet<Funcionario> Funcionarios { get; set; }

    public virtual DbSet<GeneroFisal> GeneroFisals { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<GrupoEstoque> GrupoEstoques { get; set; }

    public virtual DbSet<HistoricoCaixa> HistoricoCaixas { get; set; }

    public virtual DbSet<HoraAlunoMatricula> HoraAlunoMatriculas { get; set; }

    public virtual DbSet<Ibpt> Ibpts { get; set; }

    public virtual DbSet<Icm> Icms { get; set; }

    public virtual DbSet<IcmsCsosn> IcmsCsosns { get; set; }

    public virtual DbSet<InformacaoTecnicaProduto> InformacaoTecnicaProdutos { get; set; }

    public virtual DbSet<InventarioCabecalho> InventarioCabecalhos { get; set; }

    public virtual DbSet<InventarioDetalhe> InventarioDetalhes { get; set; }

    public virtual DbSet<ItensApontamentoCaminhao> ItensApontamentoCaminhaos { get; set; }

    public virtual DbSet<ItensBalanco> ItensBalancos { get; set; }

    public virtual DbSet<ItensCotacaoPreco> ItensCotacaoPrecos { get; set; }

    public virtual DbSet<ItensOrcamento> ItensOrcamentos { get; set; }

    public virtual DbSet<ItensVendaControlado> ItensVendaControlados { get; set; }

    public virtual DbSet<KitItensOrcamento> KitItensOrcamentos { get; set; }

    public virtual DbSet<KitProduto> KitProdutos { get; set; }

    public virtual DbSet<LancCarga> LancCargas { get; set; }

    public virtual DbSet<LivroCaixa> LivroCaixas { get; set; }

    public virtual DbSet<LocacaoOrcamento> LocacaoOrcamentos { get; set; }

    public virtual DbSet<LogContaDoCaixa> LogContaDoCaixas { get; set; }

    public virtual DbSet<LogImportacao> LogImportacaos { get; set; }

    public virtual DbSet<LubrificanteFrotaEmp> LubrificanteFrotaEmps { get; set; }

    public virtual DbSet<MPagamento> MPagamentos { get; set; }

    public virtual DbSet<MarcaAutomovel> MarcaAutomovels { get; set; }

    public virtual DbSet<MarcaProduto> MarcaProdutos { get; set; }

    public virtual DbSet<MaterialTerraplenagem> MaterialTerraplenagems { get; set; }

    public virtual DbSet<Mdfe> Mdves { get; set; }

    public virtual DbSet<MdfeChafe> MdfeChaves { get; set; }

    public virtual DbSet<MdfeCondutor> MdfeCondutors { get; set; }

    public virtual DbSet<MdfeInfcarregamento> MdfeInfcarregamentos { get; set; }

    public virtual DbSet<MdfePercurso> MdfePercursos { get; set; }

    public virtual DbSet<MdfeReboque> MdfeReboques { get; set; }

    public virtual DbSet<MdfeRodoviario> MdfeRodoviarios { get; set; }

    public virtual DbSet<MdfeSeguro> MdfeSeguros { get; set; }

    public virtual DbSet<Medico> Medicos { get; set; }

    public virtual DbSet<Medico1> Medicos1 { get; set; }

    public virtual DbSet<MenuSistema> MenuSistemas { get; set; }

    public virtual DbSet<MenuUsuario> MenuUsuarios { get; set; }

    public virtual DbSet<Mesa> Mesas { get; set; }

    public virtual DbSet<ModeloAutomovel> ModeloAutomovels { get; set; }

    public virtual DbSet<ModeloVeicProduto> ModeloVeicProdutos { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<MrepNfceVr> MrepNfceVrs { get; set; }

    public virtual DbSet<Ncm> Ncms { get; set; }

    public virtual DbSet<NcmProtocoloEstado> NcmProtocoloEstados { get; set; }

    public virtual DbSet<NfceAberturaCaixa> NfceAberturaCaixas { get; set; }

    public virtual DbSet<NfceCartaoBandeira> NfceCartaoBandeiras { get; set; }

    public virtual DbSet<NfceCartaoEmpresa> NfceCartaoEmpresas { get; set; }

    public virtual DbSet<NfceFormaPgt> NfceFormaPgts { get; set; }

    public virtual DbSet<NfceLog> NfceLogs { get; set; }

    public virtual DbSet<NfceProdutoSaidum> NfceProdutoSaida { get; set; }

    public virtual DbSet<NfceSaida> NfceSaidas { get; set; }

    public virtual DbSet<NfeCartaCorrecao> NfeCartaCorrecaos { get; set; }

    public virtual DbSet<NfeInulizada> NfeInulizadas { get; set; }

    public virtual DbSet<NutricionalProduto> NutricionalProdutos { get; set; }

    public virtual DbSet<ObsComandaProduto> ObsComandaProdutos { get; set; }

    public virtual DbSet<ObsItemComandum> ObsItemComanda { get; set; }

    public virtual DbSet<ObsNf> ObsNfs { get; set; }

    public virtual DbSet<ObsPadraoContasReceber> ObsPadraoContasRecebers { get; set; }

    public virtual DbSet<OperacaoTerra> OperacaoTerras { get; set; }

    public virtual DbSet<Orcamento> Orcamentos { get; set; }

    public virtual DbSet<OrigemCst> OrigemCsts { get; set; }

    public virtual DbSet<OsDevolucao> OsDevolucaos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<PagtosParciaisCr> PagtosParciaisCrs { get; set; }

    public virtual DbSet<Parceiro> Parceiros { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PerdaMedControlado> PerdaMedControlados { get; set; }

    public virtual DbSet<PlanoDeCaixa> PlanoDeCaixas { get; set; }

    public virtual DbSet<PlanoEstoque> PlanoEstoques { get; set; }

    public virtual DbSet<PontoVendum> PontoVenda { get; set; }

    public virtual DbSet<PostoAbastecimento> PostoAbastecimentos { get; set; }

    public virtual DbSet<PrecoProduto> PrecoProdutos { get; set; }

    public virtual DbSet<ProdAdcAcai> ProdAdcAcais { get; set; }

    public virtual DbSet<ProdAgendaEntrega> ProdAgendaEntregas { get; set; }

    public virtual DbSet<ProdEntrMatAcabado> ProdEntrMatAcabados { get; set; }

    public virtual DbSet<ProdKit> ProdKits { get; set; }

    public virtual DbSet<ProdSaidaMatPrima> ProdSaidaMatPrimas { get; set; }

    public virtual DbSet<ProdutoEntradum> ProdutoEntrada { get; set; }

    public virtual DbSet<ProdutoEstoque> ProdutoEstoques { get; set; }

    public virtual DbSet<ProdutoSaidum> ProdutoSaida { get; set; }

    public virtual DbSet<ProdutoTransferencium> ProdutoTransferencia { get; set; }

    public virtual DbSet<ProdutosForn> ProdutosForns { get; set; }

    public virtual DbSet<ProdutosSaidaModelo2> ProdutosSaidaModelo2s { get; set; }

    public virtual DbSet<Projeto> Projetos { get; set; }

    public virtual DbSet<ProtocoloEstadoNcm> ProtocoloEstadoNcms { get; set; }

    public virtual DbSet<QuestAlunoMatricula> QuestAlunoMatriculas { get; set; }

    public virtual DbSet<Quitacao> Quitacaos { get; set; }

    public virtual DbSet<R01> R01s { get; set; }

    public virtual DbSet<R02> R02s { get; set; }

    public virtual DbSet<R03> R03s { get; set; }

    public virtual DbSet<R06> R06s { get; set; }

    public virtual DbSet<R07> R07s { get; set; }

    public virtual DbSet<ReceitasPisCofin> ReceitasPisCofins { get; set; }

    public virtual DbSet<ReferenciaEstoque> ReferenciaEstoques { get; set; }

    public virtual DbSet<RelMedicao> RelMedicaos { get; set; }

    public virtual DbSet<RetornoWbsPopular> RetornoWbsPopulars { get; set; }

    public virtual DbSet<Saida> Saidas { get; set; }

    public virtual DbSet<SaidaMateriaPrima> SaidaMateriaPrimas { get; set; }

    public virtual DbSet<SaidaModelo2> SaidaModelo2s { get; set; }

    public virtual DbSet<SaidaNotasDevolucao> SaidaNotasDevolucaos { get; set; }

    public virtual DbSet<SaldoEstoque> SaldoEstoques { get; set; }

    public virtual DbSet<SangriaCaixa> SangriaCaixas { get; set; }

    public virtual DbSet<Sangrium> Sangria { get; set; }

    public virtual DbSet<SericoGlobal> SericoGlobals { get; set; }

    public virtual DbSet<SerieKitItensOrcamento> SerieKitItensOrcamentos { get; set; }

    public virtual DbSet<ServOrcamento> ServOrcamentos { get; set; }

    public virtual DbSet<Servico> Servicos { get; set; }

    public virtual DbSet<SetorFuncionario> SetorFuncionarios { get; set; }

    public virtual DbSet<Sintegra60a> Sintegra60as { get; set; }

    public virtual DbSet<Sintegra60m> Sintegra60ms { get; set; }

    public virtual DbSet<Sm> Sms { get; set; }

    public virtual DbSet<SpedPlanoConta> SpedPlanoContas { get; set; }

    public virtual DbSet<SubItensCompProduto> SubItensCompProdutos { get; set; }

    public virtual DbSet<Subservico> Subservicos { get; set; }

    public virtual DbSet<TabelaAnp> TabelaAnps { get; set; }

    public virtual DbSet<TabelaPreco> TabelaPrecos { get; set; }

    public virtual DbSet<Tanque> Tanques { get; set; }

    public virtual DbSet<TaxaJurosFormaPgt> TaxaJurosFormaPgts { get; set; }

    public virtual DbSet<TbAjusteContrCredito> TbAjusteContrCreditos { get; set; }

    public virtual DbSet<TbCdBaseCredito> TbCdBaseCreditos { get; set; }

    public virtual DbSet<TbCdContrSocialApuradum> TbCdContrSocialApurada { get; set; }

    public virtual DbSet<TbDescVProd> TbDescVProds { get; set; }

    public virtual DbSet<TbStatusO> TbStatusOs { get; set; }

    public virtual DbSet<TbTipoCredito> TbTipoCreditos { get; set; }

    public virtual DbSet<TbVlVendum> TbVlVenda { get; set; }

    public virtual DbSet<TbcomoAchou> TbcomoAchous { get; set; }

    public virtual DbSet<TbconfGerenciadortef> TbconfGerenciadortefs { get; set; }

    public virtual DbSet<TbcontaEstoque> TbcontaEstoques { get; set; }

    public virtual DbSet<TbimagemProjetoO> TbimagemProjetoOs { get; set; }

    public virtual DbSet<Tipi> Tipis { get; set; }

    public virtual DbSet<TipoEtiquetum> TipoEtiqueta { get; set; }

    public virtual DbSet<TipoInformacaoTecProd> TipoInformacaoTecProds { get; set; }

    public virtual DbSet<TipoKitProduto> TipoKitProdutos { get; set; }

    public virtual DbSet<TipoNf> TipoNfs { get; set; }

    public virtual DbSet<TipoPapel> TipoPapels { get; set; }

    public virtual DbSet<TiposEmpresa> TiposEmpresas { get; set; }

    public virtual DbSet<TiposEquipamento> TiposEquipamentos { get; set; }

    public virtual DbSet<TpAdcAcai> TpAdcAcais { get; set; }

    public virtual DbSet<TransferenciaEstoque> TransferenciaEstoques { get; set; }

    public virtual DbSet<Transportadora> Transportadoras { get; set; }

    public virtual DbSet<UnidadeMedidum> UnidadeMedida { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<VProdutoKit> VProdutoKits { get; set; }

    public virtual DbSet<VProdutosFornecedorEntradum> VProdutosFornecedorEntrada { get; set; }

    public virtual DbSet<VProdutosFornecedorOrcamento> VProdutosFornecedorOrcamentos { get; set; }

    public virtual DbSet<VProdutosFornecedorSaidum> VProdutosFornecedorSaida { get; set; }

    public virtual DbSet<VendaConsumidorCab> VendaConsumidorCabs { get; set; }

    public virtual DbSet<VendaFarmaciaPopular> VendaFarmaciaPopulars { get; set; }

    public virtual DbSet<VendaMobileCab> VendaMobileCabs { get; set; }

    public virtual DbSet<VendaMobileDetalhe> VendaMobileDetalhes { get; set; }

    public virtual DbSet<VendaRapidaFormapgt> VendaRapidaFormapgts { get; set; }

    public virtual DbSet<VendaSimple> VendaSimples { get; set; }

    public virtual DbSet<Vendedor> Vendedors { get; set; }

    public virtual DbSet<Verificacao> Verificacaos { get; set; }

    public virtual DbSet<VrDevolucao> VrDevolucaos { get; set; }

    public virtual DbSet<VrTipoVendum> VrTipoVenda { get; set; }

    public virtual DbSet<WebServNfe> WebServNves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=GlobalERP_Divisa;Username=ADM;Password=2104");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Abastecimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("abastecimento_pkey");

            entity.ToTable("abastecimento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.Crz).HasColumnName("crz");
            entity.Property(e => e.DataAbastecimento).HasColumnName("data_abastecimento");
            entity.Property(e => e.DataEcf).HasColumnName("data_ecf");
            entity.Property(e => e.EcfSerie)
                .HasMaxLength(30)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("ecf_serie");
            entity.Property(e => e.EncerranteFinal)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("encerrante_final");
            entity.Property(e => e.EncerranteInicial)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("encerrante_inicial");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HoraAbastatecimento).HasColumnName("hora_abastatecimento");
            entity.Property(e => e.HoraEcf).HasColumnName("hora_ecf");
            entity.Property(e => e.IdAutomacao)
                .HasPrecision(18, 3)
                .HasColumnName("id_automacao");
            entity.Property(e => e.IdBico).HasColumnName("id_bico");
            entity.Property(e => e.IdIdentified).HasColumnName("id_identified");
            entity.Property(e => e.IdMovimento).HasColumnName("id_movimento");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.NBico).HasColumnName("n_bico");
            entity.Property(e => e.NBomba).HasColumnName("n_bomba");
            entity.Property(e => e.NTanque).HasColumnName("n_tanque");
            entity.Property(e => e.NotaNf).HasColumnName("nota_nf");
            entity.Property(e => e.SelecaoAbastecimento)
                .HasMaxLength(20)
                .HasDefaultValueSql("'Aguardando'::character varying")
                .HasColumnName("selecao_abastecimento");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("0")
                .HasColumnName("status");
            entity.Property(e => e.StringAbastecimento)
                .HasMaxLength(100)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("string_abastecimento");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("valor_total");
            entity.Property(e => e.ValorUnitario)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("valor_unitario");
            entity.Property(e => e.Volume)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("volume");
        });

        modelBuilder.Entity<AbastecimentoFrotaEmp>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("abastecimento_frota_emp_pkey");

            entity.ToTable("abastecimento_frota_emp");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_abast_fr_emp_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdEquipamento)
                .HasMaxLength(15)
                .HasColumnName("cd_equipamento");
            entity.Property(e => e.CdFunc).HasColumnName("cd_func");
            entity.Property(e => e.CdPosto).HasColumnName("cd_posto");
            entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DataLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data_lanc");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.Km)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("km");
            entity.Property(e => e.Local)
                .HasMaxLength(150)
                .HasColumnName("local");
            entity.Property(e => e.NrReq)
                .HasMaxLength(25)
                .HasColumnName("nr_req");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.TpComb)
                .HasMaxLength(1)
                .HasColumnName("tp_comb");
            entity.Property(e => e.VlComb)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comb");

            entity.HasOne(d => d.CdFuncNavigation).WithMany(p => p.AbastecimentoFrotaEmps)
                .HasForeignKey(d => d.CdFunc)
                .HasConstraintName("abastecimento_frota_emp_fk");

            entity.HasOne(d => d.CdPostoNavigation).WithMany(p => p.AbastecimentoFrotaEmps)
                .HasForeignKey(d => d.CdPosto)
                .HasConstraintName("abastecimento_frota_emp_fk2");

            entity.HasOne(d => d.CdVeiculoNavigation).WithMany(p => p.AbastecimentoFrotaEmps)
                .HasForeignKey(d => d.CdVeiculo)
                .HasConstraintName("abastecimento_frota_emp_fk1");
        });

        modelBuilder.Entity<Abertura>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("abertura_pkey");

            entity.ToTable("abertura");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_abertura_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdOperador).HasColumnName("cd_operador");
            entity.Property(e => e.Cro).HasColumnName("cro");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.NrCaixa)
                .HasMaxLength(10)
                .HasColumnName("nr_caixa");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
            entity.Property(e => e.VlVendaBruta)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_bruta");
        });

        modelBuilder.Entity<AberturaVendaRapidum>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("abertura_venda_rapida_pkey");

            entity.ToTable("abertura_venda_rapida");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_ab_v_rap_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdGerente)
                .HasMaxLength(62)
                .HasColumnName("cd_gerente");
            entity.Property(e => e.CdOperador)
                .HasMaxLength(62)
                .HasColumnName("cd_operador");
            entity.Property(e => e.DataAbertura).HasColumnName("data_abertura");
            entity.Property(e => e.DataEncerramento).HasColumnName("data_encerramento");
            entity.Property(e => e.DataLanc)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_lanc");
            entity.Property(e => e.HoraAbertura).HasColumnName("hora_abertura");
            entity.Property(e => e.HoraEncerramento).HasColumnName("hora_encerramento");
            entity.Property(e => e.Status)
                .HasMaxLength(4)
                .HasColumnName("status");
            entity.Property(e => e.VlMoedas)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_moedas");
            entity.Property(e => e.VlSangria)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_sangria");
            entity.Property(e => e.VlSuprimento)
                .HasPrecision(18, 4)
                .HasColumnName("vl_suprimento");
            entity.Property(e => e.VlVendaFinal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final");
            entity.Property(e => e.VlVendaFinalCart)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_cart");
            entity.Property(e => e.VlVendaFinalCartDeb)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_cart_deb");
            entity.Property(e => e.VlVendaFinalChq)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_chq");
            entity.Property(e => e.VlVendaFinalPix)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_pix");
            entity.Property(e => e.VlVendaFinalPrazo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_prazo");
            entity.Property(e => e.VlVendaTicket)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_ticket");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.AberturaVendaRapida)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("abertura_venda_rapida_fk");
        });

        modelBuilder.Entity<AgendamentoEntrega>(entity =>
        {
            entity.HasKey(e => e.NrAgenda).HasName("agendamento_entrega_pkey");

            entity.ToTable("agendamento_entrega");

            entity.Property(e => e.NrAgenda)
                .HasDefaultValueSql("nextval('gen_agend_ent_id'::regclass)")
                .HasColumnName("nr_agenda");
            entity.Property(e => e.Bairro)
                .HasMaxLength(25)
                .HasColumnName("bairro");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DtEntrega).HasColumnName("dt_entrega");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.Entrega)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("entrega");
            entity.Property(e => e.FormaPagamento)
                .HasMaxLength(20)
                .HasColumnName("forma_pagamento");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.HrEntrega).HasColumnName("hr_entrega");
            entity.Property(e => e.NmCliente)
                .HasMaxLength(150)
                .HasColumnName("nm_cliente");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'AB'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasColumnName("telefone");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.TxtObsFechamento)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs_fechamento");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_total");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.AgendamentoEntregas)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("agendamento_entrega_fk");
        });

        modelBuilder.Entity<AgendarRevisao>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("agendar_revisao_pkey");

            entity.ToTable("agendar_revisao");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_agendar_revisao_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DtRetornar).HasColumnName("dt_retornar");
            entity.Property(e => e.DtRetorno).HasColumnName("dt_retorno");
            entity.Property(e => e.NrAutomovel).HasColumnName("nr_automovel");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.AgendarRevisaos)
                .HasForeignKey(d => d.CdCliente)
                .HasConstraintName("agendar_revisao_fk1");

            entity.HasOne(d => d.NrAutomovelNavigation).WithMany(p => p.AgendarRevisaos)
                .HasForeignKey(d => d.NrAutomovel)
                .HasConstraintName("agendar_revisao_fk");
        });

        modelBuilder.Entity<AlteracaoPrecoPdv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("alteracao_preco_pdv");

            entity.Property(e => e.Caixa).HasColumnName("caixa");
            entity.Property(e => e.CdProduto)
                .HasMaxLength(30)
                .HasColumnName("cd_produto");
            entity.Property(e => e.MacAddress)
                .HasMaxLength(255)
                .HasColumnName("mac_address");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("nome");
            entity.Property(e => e.NrItem).HasColumnName("nr_item");
            entity.Property(e => e.VlAntigo)
                .HasPrecision(18, 4)
                .HasColumnName("vl_antigo");
            entity.Property(e => e.VlNovo)
                .HasPrecision(18, 4)
                .HasColumnName("vl_novo");
        });

        modelBuilder.Entity<Aluguel>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("aluguel_pkey");

            entity.ToTable("aluguel");

            entity.Property(e => e.Nr)
                .ValueGeneratedNever()
                .HasColumnName("nr");
            entity.Property(e => e.Arquivo).HasColumnName("arquivo");
            entity.Property(e => e.Controla)
                .HasMaxLength(62)
                .HasColumnName("controla");
            entity.Property(e => e.Data)
                .HasMaxLength(62)
                .HasColumnName("data");
            entity.Property(e => e.DtFim)
                .HasMaxLength(62)
                .HasColumnName("dt_fim");
            entity.Property(e => e.DtInicio)
                .HasMaxLength(62)
                .HasColumnName("dt_inicio");
            entity.Property(e => e.NrControle)
                .HasMaxLength(152)
                .HasColumnName("nr_controle");
        });

        modelBuilder.Entity<Aluno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("alunos_pkey");

            entity.ToTable("alunos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altura)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("altura");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.DaDesconto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("da_desconto");
            entity.Property(e => e.DtMatricula)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_matricula");
            entity.Property(e => e.DtNascimento).HasColumnName("dt_nascimento");
            entity.Property(e => e.IdRespPagante).HasColumnName("id_resp_pagante");
            entity.Property(e => e.NmMae)
                .HasMaxLength(162)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_mae");
            entity.Property(e => e.NmPai)
                .HasMaxLength(162)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_pai");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
            entity.Property(e => e.Peso)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("peso");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'M'::character varying")
                .HasColumnName("sexo");
            entity.Property(e => e.VlMensalidade)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_mensalidade");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.Alunos)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("alunos_fk");

            entity.HasOne(d => d.IdRespPaganteNavigation).WithMany(p => p.Alunos)
                .HasForeignKey(d => d.IdRespPagante)
                .HasConstraintName("alunos_fk1");
        });

        modelBuilder.Entity<ApontamentoMaquina>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("apontamento_maquina_pkey");

            entity.ToTable("apontamento_maquina");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_ap_maq_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Autorizado)
                .HasMaxLength(1)
                .HasColumnName("autorizado");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdFrota).HasColumnName("cd_frota");
            entity.Property(e => e.CdFunc).HasColumnName("cd_func");
            entity.Property(e => e.CdOperacao).HasColumnName("cd_operacao");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.Fechou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("fechou");
            entity.Property(e => e.GerouNf)
                .HasMaxLength(1)
                .HasColumnName("gerou_nf");
            entity.Property(e => e.HorFinal)
                .HasPrecision(18, 2)
                .HasColumnName("hor_final");
            entity.Property(e => e.HorInicial)
                .HasPrecision(18, 2)
                .HasColumnName("hor_inicial");
            entity.Property(e => e.HrDescanso).HasColumnName("hr_descanso");
            entity.Property(e => e.HrFinal).HasColumnName("hr_final");
            entity.Property(e => e.HrInicial).HasColumnName("hr_inicial");
            entity.Property(e => e.Local)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("local");
            entity.Property(e => e.NrFechamento).HasColumnName("nr_fechamento");
            entity.Property(e => e.NrInterno)
                .HasMaxLength(25)
                .HasColumnName("nr_interno");
            entity.Property(e => e.NrRecibo).HasColumnName("nr_recibo");
            entity.Property(e => e.Recebeu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("recebeu");
            entity.Property(e => e.TpPagamento)
                .HasMaxLength(1)
                .HasColumnName("tp_pagamento");
            entity.Property(e => e.TxtAutorizado)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_autorizado");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.TxtOperacao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_operacao");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.ApontamentoMaquinas)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("apontamento_maquina_fk1");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ApontamentoMaquinas)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("apontamento_maquina_fk2");

            entity.HasOne(d => d.CdOperacaoNavigation).WithMany(p => p.ApontamentoMaquinas)
                .HasForeignKey(d => d.CdOperacao)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("apontamento_maquina_fk");
        });

        modelBuilder.Entity<ApontamentosCaminhao>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("apontamentos_caminhao_pkey");

            entity.ToTable("apontamentos_caminhao");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_apont_cam_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Autorizado)
                .HasMaxLength(1)
                .HasColumnName("autorizado");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdFrota).HasColumnName("cd_frota");
            entity.Property(e => e.CdFunc).HasColumnName("cd_func");
            entity.Property(e => e.DtEmissao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_emissao");
            entity.Property(e => e.Fechou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("fechou");
            entity.Property(e => e.GerouNf)
                .HasMaxLength(1)
                .HasColumnName("gerou_nf");
            entity.Property(e => e.HrDescanso).HasColumnName("hr_descanso");
            entity.Property(e => e.HrParada).HasColumnName("hr_parada");
            entity.Property(e => e.HrRetorno).HasColumnName("hr_retorno");
            entity.Property(e => e.NmEquipamento)
                .HasMaxLength(150)
                .HasColumnName("nm_equipamento");
            entity.Property(e => e.NrFechamento).HasColumnName("nr_fechamento");
            entity.Property(e => e.NrInterno)
                .HasMaxLength(25)
                .HasColumnName("nr_interno");
            entity.Property(e => e.NrRecibo).HasColumnName("nr_recibo");
            entity.Property(e => e.Recebeu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("recebeu");
            entity.Property(e => e.TpPagamento)
                .HasMaxLength(1)
                .HasColumnName("tp_pagamento");
            entity.Property(e => e.TxtAutorizado)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_autorizado");
            entity.Property(e => e.TxtMotivo)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_motivo");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.ApontamentosCaminhaos)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("apontamentos_caminhao_fk");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ApontamentosCaminhaos)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("apontamentos_caminhao_fk1");
        });

        modelBuilder.Entity<Automovel>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("automovel_pkey");

            entity.ToTable("automovel");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_automovel_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Ano)
                .HasMaxLength(4)
                .HasColumnName("ano");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CapTanque)
                .HasPrecision(18, 2)
                .HasColumnName("cap_tanque");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdMarca).HasColumnName("cd_marca");
            entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");
            entity.Property(e => e.Cilindro)
                .HasPrecision(18, 2)
                .HasColumnName("cilindro");
            entity.Property(e => e.KmDiaCad)
                .HasPrecision(18, 2)
                .HasColumnName("km_dia_cad");
            entity.Property(e => e.Motor)
                .HasMaxLength(40)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("motor");
            entity.Property(e => e.NmMotorista)
                .HasMaxLength(150)
                .HasColumnName("nm_motorista");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.TpComb)
                .HasMaxLength(1)
                .HasColumnName("tp_comb");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.Automovels)
                .HasForeignKey(d => d.CdCliente)
                .HasConstraintName("automovel_fk2");

            entity.HasOne(d => d.CdMarcaNavigation).WithMany(p => p.Automovels)
                .HasForeignKey(d => d.CdMarca)
                .HasConstraintName("automovel_fk");

            entity.HasOne(d => d.CdModeloNavigation).WithMany(p => p.Automovels)
                .HasForeignKey(d => d.CdModelo)
                .HasConstraintName("automovel_fk1");
        });

        modelBuilder.Entity<AvaliacaoFisica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("avaliacao_fisica_pkey");

            entity.ToTable("avaliacao_fisica");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Avaliacao)
                .HasMaxLength(62)
                .HasColumnName("avaliacao");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.IdAluno).HasColumnName("id_aluno");
            entity.Property(e => e.IdCadTpAvalfisica).HasColumnName("id_cad_tp_avalfisica");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.IdAlunoNavigation).WithMany(p => p.AvaliacaoFisicas)
                .HasForeignKey(d => d.IdAluno)
                .HasConstraintName("avaliacao_fisica_fk");

            entity.HasOne(d => d.IdCadTpAvalfisicaNavigation).WithMany(p => p.AvaliacaoFisicas)
                .HasForeignKey(d => d.IdCadTpAvalfisica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("avaliacao_fisica_fk1");
        });

        modelBuilder.Entity<Balanco>(entity =>
        {
            entity.HasKey(e => e.Idbalanco).HasName("balanco_pkey");

            entity.ToTable("balanco");

            entity.Property(e => e.Idbalanco)
                .HasDefaultValueSql("nextval('gen_id_balanco'::regclass)")
                .HasColumnName("idbalanco");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.Gerado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("gerado");
        });

        modelBuilder.Entity<BandeiraCartao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bandeira_cartao");

            entity.Property(e => e.Descricao)
                .HasMaxLength(128)
                .HasColumnName("descricao");
            entity.Property(e => e.DiasPagto).HasColumnName("dias_pagto");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdConta).HasColumnName("id_conta");
            entity.Property(e => e.IdCredenciadora).HasColumnName("id_credenciadora");
            entity.Property(e => e.Taxa)
                .HasPrecision(4, 2)
                .HasColumnName("taxa");
        });

        modelBuilder.Entity<BcoBoleto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("bco_boletos_pkey");

            entity.ToTable("bco_boletos");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_bco_boletos_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Abrev)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("abrev");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Bico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("bico_pkey");

            entity.ToTable("bico");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EncerranteFinal)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("encerrante_final");
            entity.Property(e => e.EncerranteInicial)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("encerrante_inicial");
            entity.Property(e => e.IdBomba).HasColumnName("id_bomba");
            entity.Property(e => e.IdTanque).HasColumnName("id_tanque");
            entity.Property(e => e.IdTanqueConjugado1).HasColumnName("id_tanque_conjugado1");
            entity.Property(e => e.IdTanqueConjugado2).HasColumnName("id_tanque_conjugado2");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.NumeroBico).HasColumnName("numero_bico");
            entity.Property(e => e.NumeroLogico)
                .HasMaxLength(2)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("numero_logico");
            entity.Property(e => e.PrecoBico)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("preco_bico");
            entity.Property(e => e.VolumeVendas)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("volume_vendas");
        });

        modelBuilder.Entity<CabContagemEstMobile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cab_contagem_est_mobile_pkey");

            entity.ToTable("cab_contagem_est_mobile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.Enviado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("enviado");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(62)
                .HasColumnName("id_usuario");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CabContagemEstMobiles)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("cab_contagem_est_mobile_fk");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.CabContagemEstMobiles)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cab_contagem_est_mobile_fk1");
        });

        modelBuilder.Entity<CabCotacaoPreco>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("cab_cotacao_preco_pkey");

            entity.ToTable("cab_cotacao_preco");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_cab_cot_pc_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.CabCotacaoPrecos)
                .HasForeignKey(d => d.CdProduto)
                .HasConstraintName("cab_cotacao_preco_fk");
        });

        modelBuilder.Entity<CabDevolucaoSaidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cab_devolucao_saida_pkey");

            entity.ToTable("cab_devolucao_saida");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtDevolucao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_devolucao");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("status");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.CabDevolucaoSaida)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("cab_devolucao_saida_fk1");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CabDevolucaoSaida)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("cab_devolucao_saida_fk");
        });

        modelBuilder.Entity<CabVendaControlado>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("cab_venda_controlados_pkey");

            entity.ToTable("cab_venda_controlados");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_cab_venda_cont_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdConselho)
                .HasMaxLength(10)
                .HasColumnName("cd_conselho");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdMedico).HasColumnName("cd_medico");
            entity.Property(e => e.Cid)
                .HasMaxLength(4)
                .HasColumnName("cid");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.DtPrescricao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_prescricao");
            entity.Property(e => e.HrLanc)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_lanc");
            entity.Property(e => e.NmComprador)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_comprador");
            entity.Property(e => e.NrNotificacao)
                .HasMaxLength(10)
                .HasColumnName("nr_notificacao");
            entity.Property(e => e.Status)
                .HasMaxLength(4)
                .HasColumnName("status");
            entity.Property(e => e.TpDocComprador)
                .HasMaxLength(2)
                .HasColumnName("tp_doc_comprador");
            entity.Property(e => e.TpReceita).HasColumnName("tp_receita");
            entity.Property(e => e.UfMedico)
                .HasMaxLength(2)
                .HasColumnName("uf_medico");
            entity.Property(e => e.UsoMedicamento)
                .HasMaxLength(1)
                .HasColumnName("uso_medicamento");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.CabVendaControlados)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cab_venda_controlados_fk1");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.CabVendaControlados)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("cab_venda_controlados_fk");
        });

        modelBuilder.Entity<CadEnderecoEntrega>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cad_endereco_entrega_pkey");

            entity.ToTable("cad_endereco_entrega");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.CodigoCidade)
                .HasMaxLength(20)
                .HasColumnName("codigo_cidade");
            entity.Property(e => e.Complemento)
                .HasMaxLength(30)
                .HasColumnName("complemento");
            entity.Property(e => e.CpfCnpj)
                .HasMaxLength(25)
                .HasColumnName("cpf_cnpj");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.InscricaoEstadual)
                .HasMaxLength(25)
                .HasColumnName("inscricao_estadual");
            entity.Property(e => e.NomeCidade)
                .HasMaxLength(60)
                .HasColumnName("nome_cidade");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero");
            entity.Property(e => e.Rua)
                .HasMaxLength(50)
                .HasColumnName("rua");
            entity.Property(e => e.Telefone)
                .HasMaxLength(30)
                .HasColumnName("telefone");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<CadEnderecoRetiradum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cad_endereco_retirada_pkey");

            entity.ToTable("cad_endereco_retirada");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(50)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(10)
                .HasColumnName("cep");
            entity.Property(e => e.CodigoCidade)
                .HasMaxLength(20)
                .HasColumnName("codigo_cidade");
            entity.Property(e => e.Complemento)
                .HasMaxLength(30)
                .HasColumnName("complemento");
            entity.Property(e => e.CpfCnpj)
                .HasMaxLength(25)
                .HasColumnName("cpf_cnpj");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.InscricaoEstadual)
                .HasMaxLength(25)
                .HasColumnName("inscricao_estadual");
            entity.Property(e => e.NomeCidade)
                .HasMaxLength(60)
                .HasColumnName("nome_cidade");
            entity.Property(e => e.Numero)
                .HasMaxLength(10)
                .HasColumnName("numero");
            entity.Property(e => e.Rua)
                .HasMaxLength(50)
                .HasColumnName("rua");
            entity.Property(e => e.Telefone)
                .HasMaxLength(30)
                .HasColumnName("telefone");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<CadTpAvalfisica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cad_tp_avalfisica_pkey");

            entity.ToTable("cad_tp_avalfisica");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("categoria");

            entity.Property(e => e.Nome)
                .HasMaxLength(42)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nome");
            entity.Property(e => e.NrCategoria)
                .HasDefaultValueSql("nextval('gen_categoria_id'::regclass)")
                .HasColumnName("nr_categoria");
        });

        modelBuilder.Entity<Cbo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cbo_pkey");

            entity.ToTable("cbo");

            entity.HasIndex(e => e.Id, "cbo_id_key").IsUnique();

            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(600)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval(('public.gen_cbo_id'::text)::regclass)")
                .HasColumnName("id");
        });

        modelBuilder.Entity<CepCidade>(entity =>
        {
            entity.HasKey(e => new { e.Cep, e.CdCidade }).HasName("cep_cidade_pkey");

            entity.ToTable("cep_cidade");

            entity.Property(e => e.Cep)
                .HasMaxLength(8)
                .HasColumnName("cep");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
        });

        modelBuilder.Entity<Cest>(entity =>
        {
            entity.HasKey(e => e.NrCest).HasName("cest_pkey");

            entity.ToTable("cest");

            entity.Property(e => e.NrCest)
                .HasMaxLength(7)
                .HasColumnName("nr_cest");
            entity.Property(e => e.Descricao)
                .HasMaxLength(16384)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<CestNcm>(entity =>
        {
            entity.HasKey(e => new { e.NrCest, e.NrNcm }).HasName("cest_ncm_pkey");

            entity.ToTable("cest_ncm");

            entity.Property(e => e.NrCest)
                .HasMaxLength(7)
                .HasColumnName("nr_cest");
            entity.Property(e => e.NrNcm)
                .HasMaxLength(8)
                .HasColumnName("nr_ncm");

            entity.HasOne(d => d.NrCestNavigation).WithMany(p => p.CestNcms)
                .HasForeignKey(d => d.NrCest)
                .HasConstraintName("cest_ncm_fk");
        });

        modelBuilder.Entity<Cfop>(entity =>
        {
            entity.HasKey(e => e.CdCfop).HasName("cfop_pkey");

            entity.ToTable("cfop");

            entity.HasIndex(e => e.Descricao, "cfop_idx");

            entity.Property(e => e.CdCfop)
                .HasMaxLength(5)
                .HasColumnName("cd_cfop");
            entity.Property(e => e.DescNfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desc_nfe");
            entity.Property(e => e.Descricao)
                .HasMaxLength(155)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao");
            entity.Property(e => e.TipoCfop)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tipo_cfop");

            entity.HasMany(d => d.Csosns).WithMany(p => p.Cfops)
                .UsingEntity<Dictionary<string, object>>(
                    "CfopCsosn",
                    r => r.HasOne<IcmsCsosn>().WithMany()
                        .HasForeignKey("Csosn")
                        .HasConstraintName("cfop_csosn_fk1"),
                    l => l.HasOne<Cfop>().WithMany()
                        .HasForeignKey("Cfop")
                        .HasConstraintName("cfop_csosn_fk"),
                    j =>
                    {
                        j.HasKey("Cfop", "Csosn").HasName("cfop_csosn_pkey");
                        j.ToTable("cfop_csosn");
                        j.IndexerProperty<string>("Cfop")
                            .HasMaxLength(5)
                            .HasColumnName("cfop");
                        j.IndexerProperty<string>("Csosn")
                            .HasMaxLength(10)
                            .HasColumnName("csosn");
                    });
        });

        modelBuilder.Entity<CfopContaSpeed>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cfop_conta_speed_pkey");

            entity.ToTable("cfop_conta_speed");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContaAnaSpedInv)
                .HasMaxLength(32)
                .HasColumnName("conta_ana_sped_inv");
            entity.Property(e => e.IdCfop)
                .HasMaxLength(5)
                .HasColumnName("id_cfop");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

            entity.HasOne(d => d.IdCfopNavigation).WithMany(p => p.CfopContaSpeeds)
                .HasForeignKey(d => d.IdCfop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cfop_conta_speed_fk1");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.CfopContaSpeeds)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("cfop_conta_speed_fk");
        });

        modelBuilder.Entity<CfopSaidum>(entity =>
        {
            entity.HasKey(e => new { e.NrSaida, e.CdCfop }).HasName("cfop_saida_pkey");

            entity.ToTable("cfop_saida");

            entity.HasIndex(e => new { e.NrSaida, e.CdCfop, e.Principal }, "cfop_saida_idx").IsUnique();

            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.CdCfop)
                .HasMaxLength(4)
                .HasColumnName("cd_cfop");
            entity.Property(e => e.Principal)
                .HasMaxLength(1)
                .HasColumnName("principal");

            entity.HasOne(d => d.CdCfopNavigation).WithMany(p => p.CfopSaida)
                .HasForeignKey(d => d.CdCfop)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cfop_saida_fk1");
        });

        modelBuilder.Entity<CfopXCfopEntradum>(entity =>
        {
            entity.HasKey(e => new { e.CdCfopS, e.CdCfopE }).HasName("cfop_x_cfop_entrada_pkey");

            entity.ToTable("cfop_x_cfop_entrada");

            entity.Property(e => e.CdCfopS)
                .HasMaxLength(5)
                .HasColumnName("cd_cfop_s");
            entity.Property(e => e.CdCfopE)
                .HasMaxLength(5)
                .HasColumnName("cd_cfop_e");
            entity.Property(e => e.CfopDentro)
                .HasMaxLength(5)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfop_dentro");
            entity.Property(e => e.CfopFora)
                .HasMaxLength(5)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfop_fora");
            entity.Property(e => e.Csosn)
                .HasMaxLength(4)
                .HasColumnName("csosn");
        });

        modelBuilder.Entity<ChequeProprio>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("cheque_proprio_pkey");

            entity.ToTable("cheque_proprio");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_ch_p_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CdConta).HasColumnName("cd_conta");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.NrChequeAtual)
                .HasMaxLength(10)
                .HasColumnName("nr_cheque_atual");
            entity.Property(e => e.NrChequeFinal)
                .HasMaxLength(10)
                .HasColumnName("nr_cheque_final");
            entity.Property(e => e.NrChequeInicial)
                .HasMaxLength(10)
                .HasColumnName("nr_cheque_inicial");
        });

        modelBuilder.Entity<Cidade>(entity =>
        {
            entity.HasKey(e => e.CdCidade).HasName("cidade_pkey");

            entity.ToTable("cidade");

            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.NmCidade)
                .HasMaxLength(150)
                .HasColumnName("nm_cidade");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasDefaultValueSql("'XX'::character varying")
                .HasColumnName("uf");
        });

        modelBuilder.Entity<ClassificacaoCliente>(entity =>
        {
            entity.HasKey(e => e.CdClassificacao).HasName("classificacao_cliente_pkey");

            entity.ToTable("classificacao_cliente");

            entity.Property(e => e.CdClassificacao)
                .HasDefaultValueSql("nextval(('public.classificacao_cliente_cd_classificacao_seq'::text)::regclass)")
                .HasColumnName("cd_classificacao");
            entity.Property(e => e.Cor)
                .HasMaxLength(32)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cor");
            entity.Property(e => e.DescontoClassificacao)
                .HasPrecision(3, 2)
                .HasColumnName("desconto_classificacao");
            entity.Property(e => e.NmClassificacao)
                .HasMaxLength(600)
                .HasColumnName("nm_classificacao");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.CdCliente).HasName("cliente_pkey");

            entity.ToTable("cliente");

            entity.HasIndex(e => e.NmCliente, "cliente_idx");

            entity.Property(e => e.CdCliente)
                .HasDefaultValueSql("nextval('gen_cliente_id'::regclass)")
                .HasColumnName("cd_cliente");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CdCep)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_cep");
            entity.Property(e => e.CdCepNfe)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_cep_nfe");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.CdCidadeNfe)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade_nfe");
            entity.Property(e => e.CdClassificacao)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_classificacao");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(50)
                .HasColumnName("cd_interno");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cnpj");
            entity.Property(e => e.Comanda).HasColumnName("comanda");
            entity.Property(e => e.ComissaoCliente)
                .HasPrecision(18, 2)
                .HasColumnName("comissao_cliente");
            entity.Property(e => e.Complemento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("complemento");
            entity.Property(e => e.ComplementoNfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("complemento_nfe");
            entity.Property(e => e.Consumacao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("consumacao");
            entity.Property(e => e.ConsumidorFinal)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("consumidor_final");
            entity.Property(e => e.ContribuinteInss)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("contribuinte_inss");
            entity.Property(e => e.Convenio).HasColumnName("convenio");
            entity.Property(e => e.Cpf)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cpf");
            entity.Property(e => e.DiaPagt)
                .HasMaxLength(2)
                .HasDefaultValueSql("'10'::character varying")
                .HasColumnName("dia_pagt");
            entity.Property(e => e.DtCadastro)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_cadastro");
            entity.Property(e => e.DtNasc).HasColumnName("dt_nasc");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.EmiteNf)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("emite_nf");
            entity.Property(e => e.Entrada)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("entrada");
            entity.Property(e => e.Foto)
                .HasDefaultValueSql("''::text")
                .HasColumnName("foto");
            entity.Property(e => e.IncideIss)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("incide_iss");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.LimiteCredito)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("limite_credito");
            entity.Property(e => e.Mva)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("mva");
            entity.Property(e => e.NmBairro)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_bairro");
            entity.Property(e => e.NmBairroNfe)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_bairro_nfe");
            entity.Property(e => e.NmCliente)
                .HasMaxLength(150)
                .HasColumnName("nm_cliente");
            entity.Property(e => e.NmEndereco)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_endereco");
            entity.Property(e => e.NmEnderecoNfe)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_endereco_nfe");
            entity.Property(e => e.NmFatansia)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_fatansia");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_usuario");
            entity.Property(e => e.NrCelular)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_celular");
            entity.Property(e => e.NrInscrEstadual)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_inscr_estadual");
            entity.Property(e => e.Numero)
                .HasDefaultValueSql("0")
                .HasColumnName("numero");
            entity.Property(e => e.NumeroNfe)
                .HasDefaultValueSql("0")
                .HasColumnName("numero_nfe");
            entity.Property(e => e.OrgaoRg)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("orgao_rg");
            entity.Property(e => e.PodeComprar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("pode_comprar");
            entity.Property(e => e.PorcIrrf)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_irrf");
            entity.Property(e => e.PorcIss)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_iss");
            entity.Property(e => e.PrecisaAutorizacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("precisa_autorizacao");
            entity.Property(e => e.Profissao)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("profissao");
            entity.Property(e => e.Rg)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("rg");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sexo");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone");
            entity.Property(e => e.Telefone2)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone2");
            entity.Property(e => e.TipoPagto).HasColumnName("tipo_pagto");
            entity.Property(e => e.TpCliente)
                .HasMaxLength(1)
                .HasColumnName("tp_cliente");
            entity.Property(e => e.TpRegime).HasColumnName("tp_regime");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transferiu");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.TxtRecado)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_recado");
            entity.Property(e => e.UfOrgaoRg)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uf_orgao_rg");

            entity.HasOne(d => d.CdCidadeNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.CdCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_fk");

            entity.HasMany(d => d.IdVendedors).WithMany(p => p.IdClientes)
                .UsingEntity<Dictionary<string, object>>(
                    "VendedorCliente",
                    r => r.HasOne<Funcionario>().WithMany()
                        .HasForeignKey("IdVendedor")
                        .HasConstraintName("vendedor_cliente_fk1"),
                    l => l.HasOne<Cliente>().WithMany()
                        .HasForeignKey("IdCliente")
                        .HasConstraintName("vendedor_cliente_fk"),
                    j =>
                    {
                        j.HasKey("IdCliente", "IdVendedor").HasName("vendedor_cliente_idx");
                        j.ToTable("vendedor_cliente");
                        j.IndexerProperty<int>("IdCliente").HasColumnName("id_cliente");
                        j.IndexerProperty<int>("IdVendedor").HasColumnName("id_vendedor");
                    });
        });

        modelBuilder.Entity<ClienteCredito>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cliente_credito_pkey");

            entity.ToTable("cliente_credito");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataLanc).HasColumnName("data_lanc");
            entity.Property(e => e.DataPagto).HasColumnName("data_pagto");
            entity.Property(e => e.IdCliente)
                .HasDefaultValueSql("0")
                .HasColumnName("id_cliente");
            entity.Property(e => e.IdEntrada)
                .HasDefaultValueSql("0")
                .HasColumnName("id_entrada");
            entity.Property(e => e.IdOs)
                .HasDefaultValueSql("0")
                .HasColumnName("id_os");
            entity.Property(e => e.IdOsPagou)
                .HasDefaultValueSql("0")
                .HasColumnName("id_os_pagou");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.PagouDinheiro)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou_dinheiro");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<CodMunIbge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cod_mun_ibge");

            entity.Property(e => e.CodMunicipio)
                .HasMaxLength(5)
                .HasColumnName("cod_municipio");
            entity.Property(e => e.CodUf)
                .HasMaxLength(2)
                .HasColumnName("cod_uf");
            entity.Property(e => e.Municipio)
                .HasMaxLength(50)
                .HasColumnName("municipio");
            entity.Property(e => e.Uf)
                .HasMaxLength(20)
                .HasColumnName("uf");
            entity.Property(e => e.UfSigla)
                .HasMaxLength(2)
                .HasColumnName("uf_sigla");
        });

        modelBuilder.Entity<ComandaCabecalho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("comanda_cabecalho_pkey");

            entity.ToTable("comanda_cabecalho");

            entity.HasIndex(e => e.NrComanda, "comanda_cabecalho_idx");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_comanda_cabecalho_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Abertura)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("abertura");
            entity.Property(e => e.Baixou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("baixou");
            entity.Property(e => e.Conferido)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("conferido");
            entity.Property(e => e.Consumacao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("consumacao");
            entity.Property(e => e.ConvertCobra)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("convert_cobra");
            entity.Property(e => e.Coo)
                .HasMaxLength(10)
                .HasColumnName("coo");
            entity.Property(e => e.Couvert)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("couvert");
            entity.Property(e => e.Cr)
                .HasMaxLength(10)
                .HasColumnName("cr");
            entity.Property(e => e.Cupom)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cupom");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.DtEntrega)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_entrega");
            entity.Property(e => e.Entrada)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("entrada");
            entity.Property(e => e.Entrega)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("entrega");
            entity.Property(e => e.Fechamento)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("fechamento");
            entity.Property(e => e.HrEntrega)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_entrega");
            entity.Property(e => e.IdCliente)
                .HasDefaultValueSql("1")
                .HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa)
                .HasDefaultValueSql("1")
                .HasColumnName("id_empresa");
            entity.Property(e => e.IdVendedor)
                .HasDefaultValueSql("1")
                .HasColumnName("id_vendedor");
            entity.Property(e => e.ImportouVenda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("importou_venda");
            entity.Property(e => e.Necf)
                .HasMaxLength(10)
                .HasColumnName("necf");
            entity.Property(e => e.NrComanda)
                .HasMaxLength(62)
                .HasColumnName("nr_comanda");
            entity.Property(e => e.NrMesa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_mesa");
            entity.Property(e => e.QtdeLugares)
                .HasDefaultValueSql("1")
                .HasColumnName("qtde_lugares");
            entity.Property(e => e.Servico)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("servico");
            entity.Property(e => e.ServicoCobra)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("servico_cobra");
            entity.Property(e => e.Status)
                .HasMaxLength(12)
                .HasDefaultValueSql("'FECHADA'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TipoComanda)
                .HasMaxLength(12)
                .HasDefaultValueSql("'MESA'::character varying")
                .HasColumnName("tipo_comanda");
            entity.Property(e => e.TipoPagamento)
                .HasMaxLength(30)
                .HasDefaultValueSql("'DINHEIRO'::character varying")
                .HasColumnName("tipo_pagamento");
            entity.Property(e => e.Total)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("total");
            entity.Property(e => e.TpPagamento)
                .HasMaxLength(1)
                .HasDefaultValueSql("'V'::character varying")
                .HasColumnName("tp_pagamento");
            entity.Property(e => e.Transf)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transf");
            entity.Property(e => e.TrocoCliente)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("troco_cliente");
            entity.Property(e => e.TxtObsDelivery)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs_delivery");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
            entity.Property(e => e.ValorPago)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_pago");
            entity.Property(e => e.VemBuscar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("vem_buscar");
            entity.Property(e => e.Vinculo)
                .HasMaxLength(12)
                .HasDefaultValueSql("'NENHUM'::character varying")
                .HasColumnName("vinculo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.ComandaCabecalhos)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("comanda_cabecalho_fk");
        });

        modelBuilder.Entity<ComandaDetalhe>(entity =>
        {
            entity.HasKey(e => e.Reg).HasName("comanda_detalhe_pkey");

            entity.ToTable("comanda_detalhe");

            entity.Property(e => e.Reg)
                .HasDefaultValueSql("nextval('gen_comanda_detalhe_id'::regclass)")
                .HasColumnName("reg");
            entity.Property(e => e.Baixou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("baixou");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cancelado");
            entity.Property(e => e.ComandaAnterior).HasColumnName("comanda_anterior");
            entity.Property(e => e.Comissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("comissao");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data");
            entity.Property(e => e.HrPedido)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_pedido");
            entity.Property(e => e.IdComanda).HasColumnName("id_comanda");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdEntregador).HasColumnName("id_entregador");
            entity.Property(e => e.IdPizza)
                .HasDefaultValueSql("0")
                .HasColumnName("id_pizza");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");
            entity.Property(e => e.Impresso)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("impresso");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.MeiaPizza)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("meia_pizza");
            entity.Property(e => e.Obs)
                .HasMaxLength(200)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("obs");
            entity.Property(e => e.OrigemLancamento)
                .HasMaxLength(30)
                .HasDefaultValueSql("'SISTEMA'::character varying")
                .HasColumnName("origem_lancamento");
            entity.Property(e => e.Qtde)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("qtde");
            entity.Property(e => e.ServicoCouvert)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("servico_couvert");
            entity.Property(e => e.ServicoG)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("servico_g");
            entity.Property(e => e.TamanhoPizza)
                .HasMaxLength(1)
                .HasDefaultValueSql("'G'::character varying")
                .HasColumnName("tamanho_pizza");
            entity.Property(e => e.TipoComanda)
                .HasMaxLength(12)
                .HasDefaultValueSql("'MESA'::character varying")
                .HasColumnName("tipo_comanda");
            entity.Property(e => e.Total)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("total");
            entity.Property(e => e.Transferencia)
                .HasMaxLength(30)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transferencia");
            entity.Property(e => e.TxtObsCancelado)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs_cancelado");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdComandaNavigation).WithMany(p => p.ComandaDetalhes)
                .HasForeignKey(d => d.IdComanda)
                .HasConstraintName("comanda_detalhe_fk");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.ComandaDetalhes)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("comanda_detalhe_fk1");
        });

        modelBuilder.Entity<ComandaFormapgt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("comanda_formapgt");

            entity.Property(e => e.Forma)
                .HasMaxLength(30)
                .HasColumnName("forma");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdVr).HasColumnName("id_vr");
            entity.Property(e => e.Troco)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("troco");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<ComandaImpressora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("comanda_impressora_pkey");

            entity.ToTable("comanda_impressora");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_comanda_impressora_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Ativa)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativa");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
            entity.Property(e => e.Endereco)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("endereco");
            entity.Property(e => e.Ip)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ip");
            entity.Property(e => e.Modelo)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("modelo");
            entity.Property(e => e.Pulo)
                .HasDefaultValueSql("6")
                .HasColumnName("pulo");
        });

        modelBuilder.Entity<ComandaPerda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("comanda_perdas_pkey");

            entity.ToTable("comanda_perdas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Observacao)
                .HasMaxLength(512)
                .HasColumnName("observacao");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
        });

        modelBuilder.Entity<ComandaTipoImpressora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("comanda_tipo_impressora_pkey");

            entity.ToTable("comanda_tipo_impressora");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_comanda_tipo_impressora_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Balcao)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("balcao");
            entity.Property(e => e.Cartao)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cartao");
            entity.Property(e => e.Delivery)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("delivery");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Mesa)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mesa");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.ComandaTipoImpressoras)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("comanda_tipo_impressora_fk");
        });

        modelBuilder.Entity<ComissaoVendedor>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("comissao_vendedor_pkey");

            entity.ToTable("comissao_vendedor");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_comissao_vendedor_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DtPagou).HasColumnName("dt_pagou");
            entity.Property(e => e.NrCr).HasColumnName("nr_cr");
            entity.Property(e => e.NrItemSaida).HasColumnName("nr_item_saida");
            entity.Property(e => e.NrOr).HasColumnName("nr_or");
            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasColumnName("pagou");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasColumnName("vl_comissao");

            entity.HasOne(d => d.CdVendedorNavigation).WithMany(p => p.ComissaoVendedors)
                .HasForeignKey(d => d.CdVendedor)
                .HasConstraintName("comissao_vendedor_fk");
        });

        modelBuilder.Entity<ComposicaoKitProduto>(entity =>
        {
            entity.HasKey(e => new { e.IdProduto, e.IdKit }).HasName("composicao_kit_produto_pkey");

            entity.ToTable("composicao_kit_produto");

            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdKit).HasColumnName("id_kit");
            entity.Property(e => e.Sequencia)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("sequencia");

            entity.HasOne(d => d.IdKitNavigation).WithMany(p => p.ComposicaoKitProdutos)
                .HasForeignKey(d => d.IdKit)
                .HasConstraintName("composicao_kit_produto_fk1");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.ComposicaoKitProdutos)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("composicao_kit_produto_fk");
        });

        modelBuilder.Entity<ComposicaoProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("composicao_produto_pkey");

            entity.ToTable("composicao_produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdProdutoPrincipal).HasColumnName("id_produto_principal");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasColumnName("quantidade");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.ComposicaoProdutoIdProdutoNavigations)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("composicao_produto_fk1");

            entity.HasOne(d => d.IdProdutoPrincipalNavigation).WithMany(p => p.ComposicaoProdutoIdProdutoPrincipalNavigations)
                .HasForeignKey(d => d.IdProdutoPrincipal)
                .HasConstraintName("composicao_produto_fk");
        });

        modelBuilder.Entity<CondicaoTroca>(entity =>
        {
            entity.HasKey(e => e.CdCondicao).HasName("condicao_troca_pkey");

            entity.ToTable("condicao_troca");

            entity.Property(e => e.CdCondicao)
                .HasDefaultValueSql("nextval('gen_condicao_troca_id'::regclass)")
                .HasColumnName("cd_condicao");
            entity.Property(e => e.NmCondicao)
                .HasMaxLength(62)
                .HasColumnName("nm_condicao");
        });

        modelBuilder.Entity<ConfBalanca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("conf_balanca_pkey");

            entity.ToTable("conf_balanca");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Baud).HasColumnName("baud");
            entity.Property(e => e.Caixa).HasColumnName("caixa");
            entity.Property(e => e.ConfiguracaoBalanca)
                .HasMaxLength(150)
                .HasColumnName("configuracao_balanca");
            entity.Property(e => e.Handshake).HasColumnName("handshake");
            entity.Property(e => e.Modelo)
                .HasMaxLength(150)
                .HasColumnName("modelo");
            entity.Property(e => e.Monitorar)
                .HasMaxLength(15)
                .HasColumnName("monitorar");
            entity.Property(e => e.Parity).HasColumnName("parity");
            entity.Property(e => e.Porta)
                .HasMaxLength(15)
                .HasColumnName("porta");
            entity.Property(e => e.Stop).HasColumnName("stop");
            entity.Property(e => e.Timeout).HasColumnName("timeout");
        });

        modelBuilder.Entity<ConfBoleto>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("conf_boleto_pkey");

            entity.ToTable("conf_boleto");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval(('public.conf_boleto_nr_lanc_seq'::text)::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.BcoBoleto).HasColumnName("bco_boleto");
            entity.Property(e => e.CaracTitulo)
                .HasMaxLength(2)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("carac_titulo");
            entity.Property(e => e.Carteira)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("carteira");
            entity.Property(e => e.CdCedente)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_cedente");
            entity.Property(e => e.CdConvenio)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_convenio");
            entity.Property(e => e.CdMora)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("cd_mora");
            entity.Property(e => e.CdTransmissao)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_transmissao");
            entity.Property(e => e.DiretorioEnvio)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("diretorio_envio");
            entity.Property(e => e.DiretorioRetorno)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("diretorio_retorno");
            entity.Property(e => e.EspecieDoc)
                .HasMaxLength(4)
                .HasDefaultValueSql("'DM'::character varying")
                .HasColumnName("especie_doc");
            entity.Property(e => e.FormaCadastramento)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("forma_cadastramento");
            entity.Property(e => e.JurosMora)
                .HasPrecision(18, 4)
                .HasColumnName("juros_mora");
            entity.Property(e => e.LayoutRemessa)
                .HasMaxLength(1)
                .HasDefaultValueSql("'1'::character varying")
                .HasColumnName("layout_remessa");
            entity.Property(e => e.Multa)
                .HasPrecision(18, 4)
                .HasColumnName("multa");
            entity.Property(e => e.NrBoletoAtual)
                .HasMaxLength(25)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("nr_boleto_atual");
            entity.Property(e => e.NrConta).HasColumnName("nr_conta");
            entity.Property(e => e.NrInicialBoleto)
                .HasMaxLength(25)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("nr_inicial_boleto");
            entity.Property(e => e.Protesto)
                .HasDefaultValueSql("0")
                .HasColumnName("protesto");
            entity.Property(e => e.TxtLocalPgt)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_local_pgt");

            entity.HasOne(d => d.BcoBoletoNavigation).WithMany(p => p.ConfBoletos)
                .HasForeignKey(d => d.BcoBoleto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("conf_boleto_fk1");

            entity.HasOne(d => d.NrContaNavigation).WithMany(p => p.ConfBoletos)
                .HasForeignKey(d => d.NrConta)
                .HasConstraintName("conf_boleto_fk");
        });

        modelBuilder.Entity<ConfEmailNfe>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("conf_email_nfe_pkey");

            entity.ToTable("conf_email_nfe");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_conf_email_nfe_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.AssuntoEmail)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("assunto_email");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.ConexaoSegura)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("conexao_segura");
            entity.Property(e => e.EMailCopia)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("e_mail_copia");
            entity.Property(e => e.Porta)
                .HasMaxLength(10)
                .HasColumnName("porta");
            entity.Property(e => e.Senha)
                .HasMaxLength(62)
                .HasColumnName("senha");
            entity.Property(e => e.Smtp)
                .HasMaxLength(62)
                .HasColumnName("smtp");
            entity.Property(e => e.Ssl)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("ssl");
            entity.Property(e => e.Tsl)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("tsl");
            entity.Property(e => e.TxtPadrao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_padrao");
            entity.Property(e => e.Usuario)
                .HasMaxLength(62)
                .HasColumnName("usuario");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ConfEmailNves)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("conf_email_nfe_fk");
        });

        modelBuilder.Entity<ConfIntegradorEcomerce>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("conf_integrador_ecomerce_pkey");

            entity.ToTable("conf_integrador_ecomerce");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdTipoIntegrador)
                .HasMaxLength(4)
                .HasColumnName("id_tipo_integrador");
            entity.Property(e => e.Senha)
                .HasMaxLength(160)
                .HasColumnName("senha");
            entity.Property(e => e.Usuario)
                .HasMaxLength(160)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<ConfNfe>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("conf_nfe_pkey");

            entity.ToTable("conf_nfe");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_conf_nfe_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CaminhoCertificado)
                .HasMaxLength(152)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("caminho_certificado");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.EMailContador)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("e_mail_contador");
            entity.Property(e => e.Senha)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("senha");
            entity.Property(e => e.SerialCertificado)
                .HasMaxLength(62)
                .HasColumnName("serial_certificado");
            entity.Property(e => e.TpCertificado)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_certificado");
            entity.Property(e => e.ValidadeCert).HasColumnName("validade_cert");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ConfNves)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("conf_nfe_fk");
        });

        modelBuilder.Entity<ContaDoCaixa>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("conta_do_caixa_pkey");

            entity.ToTable("conta_do_caixa");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_conta_do_caixa_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.LimiteEspecial)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("limite_especial");
            entity.Property(e => e.MostrarDadosImpressao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("mostrar_dados_impressao");
            entity.Property(e => e.NmBanco)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_banco");
            entity.Property(e => e.NmConta)
                .HasMaxLength(62)
                .HasColumnName("nm_conta");
            entity.Property(e => e.NrAgencia)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_agencia");
            entity.Property(e => e.NrChequeInicial)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_cheque_inicial");
            entity.Property(e => e.NrContaBanco)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_conta_banco");
            entity.Property(e => e.NrDigitoAg)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_digito_ag");
            entity.Property(e => e.NrDigitoConta)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_digito_conta");
            entity.Property(e => e.SaldoAtual)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("saldo_atual");
            entity.Property(e => e.SaldoInicial)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("saldo_inicial");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ContaDoCaixas)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("conta_do_caixa_fk");
        });

        modelBuilder.Entity<Contador>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("contador_pkey");

            entity.ToTable("contador");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_contador_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(25)
                .HasColumnName("bairro");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.CdCrc)
                .HasMaxLength(15)
                .HasColumnName("cd_crc");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.Cep)
                .HasMaxLength(9)
                .HasColumnName("cep");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasColumnName("cnpj");
            entity.Property(e => e.Cpf)
                .HasMaxLength(15)
                .HasColumnName("cpf");
            entity.Property(e => e.EMail)
                .HasMaxLength(255)
                .HasColumnName("e_mail");
            entity.Property(e => e.End)
                .HasMaxLength(150)
                .HasColumnName("end");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.TelFax)
                .HasMaxLength(15)
                .HasColumnName("tel_fax");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasColumnName("telefone");

            entity.HasOne(d => d.CdCidadeNavigation).WithMany(p => p.Contadors)
                .HasForeignKey(d => d.CdCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contador_fk");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.Contadors)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("contador_fk1");
        });

        modelBuilder.Entity<ContagemPrMobile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("contagem_pr_mobile_pkey");

            entity.ToTable("contagem_pr_mobile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Conferido)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("conferido");
            entity.Property(e => e.IdCab).HasColumnName("id_cab");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Quant)
                .HasPrecision(15, 2)
                .HasColumnName("quant");

            entity.HasOne(d => d.IdCabNavigation).WithMany(p => p.ContagemPrMobiles)
                .HasForeignKey(d => d.IdCab)
                .HasConstraintName("contagem_pr_mobile_fk");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.ContagemPrMobiles)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("contagem_pr_mobile_fk1");
        });

        modelBuilder.Entity<ContasAPagar>(entity =>
        {
            entity.HasKey(e => e.NrLancamento).HasName("contas_a_pagar_pkey");

            entity.ToTable("contas_a_pagar");

            entity.HasIndex(e => e.DtVencimento, "contas_a_pagar_idx");

            entity.Property(e => e.NrLancamento)
                .HasDefaultValueSql("nextval('gen_contas_a_pagar_id'::regclass)")
                .HasColumnName("nr_lancamento");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");
            entity.Property(e => e.CdHistoricoCaixa)
                .HasMaxLength(25)
                .HasColumnName("cd_historico_caixa");
            entity.Property(e => e.CdPlanoCaixa)
                .HasMaxLength(25)
                .HasColumnName("cd_plano_caixa");
            entity.Property(e => e.DtLancamento)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lancamento");
            entity.Property(e => e.DtPagou).HasColumnName("dt_pagou");
            entity.Property(e => e.DtVencimento).HasColumnName("dt_vencimento");
            entity.Property(e => e.IdLancPrinc)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_lanc_princ");
            entity.Property(e => e.NrCheque)
                .HasMaxLength(10)
                .HasColumnName("nr_cheque");
            entity.Property(e => e.NrConta).HasColumnName("nr_conta");
            entity.Property(e => e.NrDuplicata)
                .HasMaxLength(25)
                .HasColumnName("nr_duplicata");
            entity.Property(e => e.NrEntrada).HasColumnName("nr_entrada");
            entity.Property(e => e.NrEntradaOutraDesp)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_entrada_outra_desp");
            entity.Property(e => e.NrFormaPagt).HasColumnName("nr_forma_pagt");
            entity.Property(e => e.NrNf)
                .HasMaxLength(15)
                .HasColumnName("nr_nf");
            entity.Property(e => e.PagoA)
                .HasMaxLength(62)
                .HasColumnName("pago_a");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.TpFormaPagt)
                .HasMaxLength(1)
                .HasColumnName("tp_forma_pagt");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlAcrescimo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_acrescimo");
            entity.Property(e => e.VlCheque)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cheque");
            entity.Property(e => e.VlCp)
                .HasPrecision(18, 4)
                .HasColumnName("vl_cp");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlDinheiro)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_dinheiro");
            entity.Property(e => e.VlPagoFinal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pago_final");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ContasAPagars)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("contas_a_pagar_fk1");

            entity.HasOne(d => d.CdFornecedorNavigation).WithMany(p => p.ContasAPagars)
                .HasForeignKey(d => d.CdFornecedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contas_a_pagar_fk");

            entity.HasOne(d => d.Cd).WithMany(p => p.ContasAPagars)
                .HasForeignKey(d => new { d.CdHistoricoCaixa, d.CdPlanoCaixa })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contas_a_pagar_fk2");
        });

        modelBuilder.Entity<ContasAReceber>(entity =>
        {
            entity.HasKey(e => e.NrConta).HasName("contas_a_receber_pkey");

            entity.ToTable("contas_a_receber");

            entity.Property(e => e.NrConta)
                .HasDefaultValueSql("nextval('gen_contas_a_receber_id'::regclass)")
                .HasColumnName("nr_conta");
            entity.Property(e => e.Alteradodtvenc)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("alteradodtvenc");
            entity.Property(e => e.Base)
                .HasMaxLength(7)
                .HasColumnName("base");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cancelado");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdHistoricoCaixa)
                .HasMaxLength(25)
                .HasColumnName("cd_historico_caixa");
            entity.Property(e => e.CdPlanoCaixa)
                .HasMaxLength(25)
                .HasColumnName("cd_plano_caixa");
            entity.Property(e => e.CdProjeto)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_projeto");
            entity.Property(e => e.DataLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data_lanc");
            entity.Property(e => e.DtPagamento).HasColumnName("dt_pagamento");
            entity.Property(e => e.DtVencimento).HasColumnName("dt_vencimento");
            entity.Property(e => e.IdAluno)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_aluno");
            entity.Property(e => e.IdBandeira).HasColumnName("id_bandeira");
            entity.Property(e => e.IdGrupo)
                .HasDefaultValueSql("0")
                .HasColumnName("id_grupo");
            entity.Property(e => e.IdLancPrincipal)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_lanc_principal");
            entity.Property(e => e.Imprimiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("imprimiu");
            entity.Property(e => e.NrBoleto)
                .HasMaxLength(25)
                .HasColumnName("nr_boleto");
            entity.Property(e => e.NrContaCaixa).HasColumnName("nr_conta_caixa");
            entity.Property(e => e.NrContaRenegociado)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_conta_renegociado");
            entity.Property(e => e.NrDuplicata)
                .HasMaxLength(20)
                .HasColumnName("nr_duplicata");
            entity.Property(e => e.NrFormaPagt)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_forma_pagt");
            entity.Property(e => e.NrOs)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_os");
            entity.Property(e => e.NrSaida)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_saida");
            entity.Property(e => e.NrUsuario).HasColumnName("nr_usuario");
            entity.Property(e => e.QtParcela)
                .HasDefaultValueSql("1")
                .HasColumnName("qt_parcela");
            entity.Property(e => e.Quantidade)
                .HasDefaultValueSql("1")
                .HasColumnName("quantidade");
            entity.Property(e => e.Recebeu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("recebeu");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TxtBoleto)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_boleto");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.Vinculado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("vinculado");
            entity.Property(e => e.VlAcrescimo)
                .HasPrecision(18, 4)
                .HasColumnName("vl_acrescimo");
            entity.Property(e => e.VlBruto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_bruto");
            entity.Property(e => e.VlConta)
                .HasPrecision(18, 4)
                .HasColumnName("vl_conta");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlIrrf)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_irrf");
            entity.Property(e => e.VlIss)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_iss");
            entity.Property(e => e.VlJuros)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_juros");
            entity.Property(e => e.VlPago)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pago");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.ContasARecebers)
                .HasForeignKey(d => d.CdCliente)
                .HasConstraintName("contas_a_receber_fk1");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ContasARecebers)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("contas_a_receber_fk");

            entity.HasOne(d => d.Cd).WithMany(p => p.ContasARecebers)
                .HasForeignKey(d => new { d.CdHistoricoCaixa, d.CdPlanoCaixa })
                .HasConstraintName("contas_a_receber_fk2");
        });

        modelBuilder.Entity<Contrato>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("contratos_pkey");

            entity.ToTable("contratos");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_contratos_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdProjeto).HasColumnName("cd_projeto");
            entity.Property(e => e.DtFinal).HasColumnName("dt_final");
            entity.Property(e => e.DtInicial).HasColumnName("dt_inicial");
            entity.Property(e => e.NrContrato)
                .HasMaxLength(150)
                .HasColumnName("nr_contrato");
            entity.Property(e => e.TxtObjeto)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_objeto");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlMes)
                .HasPrecision(18, 4)
                .HasColumnName("vl_mes");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.CdCliente)
                .HasConstraintName("contratos_fk");

            entity.HasOne(d => d.CdProjetoNavigation).WithMany(p => p.Contratos)
                .HasForeignKey(d => d.CdProjeto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("contratos_fk1");
        });

        modelBuilder.Entity<ControleCheque>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("controle_cheques_pkey");

            entity.ToTable("controle_cheques");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_controle_cheques_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Baixou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("baixou");
            entity.Property(e => e.BandaMagnetica)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("banda_magnetica");
            entity.Property(e => e.CdAgencia)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_agencia");
            entity.Property(e => e.CdBanco)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_banco");
            entity.Property(e => e.CdCliente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_cliente");
            entity.Property(e => e.CdConta).HasColumnName("cd_conta");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdForn)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_forn");
            entity.Property(e => e.CdHistorico)
                .HasMaxLength(25)
                .HasColumnName("cd_historico");
            entity.Property(e => e.CdPlanoCaixa)
                .HasMaxLength(25)
                .HasColumnName("cd_plano_caixa");
            entity.Property(e => e.ChequeDe)
                .HasMaxLength(62)
                .HasColumnName("cheque_de");
            entity.Property(e => e.DtBaixa).HasColumnName("dt_baixa");
            entity.Property(e => e.DtLancamento)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lancamento");
            entity.Property(e => e.DtPrazoCheque).HasColumnName("dt_prazo_cheque");
            entity.Property(e => e.NrCheque)
                .HasMaxLength(10)
                .HasColumnName("nr_cheque");
            entity.Property(e => e.NrContaCheque)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_conta_cheque");
            entity.Property(e => e.NrCp)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_cp");
            entity.Property(e => e.NrCr)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_cr");
            entity.Property(e => e.Passoupara)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("passoupara");
            entity.Property(e => e.PorcJuros)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_juros");
            entity.Property(e => e.QtdeDias)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("qtde_dias");
            entity.Property(e => e.TpBaixa)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_baixa");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.ValorLiquido)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_liquido");
            entity.Property(e => e.VlCheque)
                .HasPrecision(18, 4)
                .HasColumnName("vl_cheque");

            entity.HasOne(d => d.CdContaNavigation).WithMany(p => p.ControleCheques)
                .HasForeignKey(d => d.CdConta)
                .HasConstraintName("controle_cheques_fk1");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ControleCheques)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("controle_cheques_fk");

            entity.HasOne(d => d.Cd).WithMany(p => p.ControleCheques)
                .HasForeignKey(d => new { d.CdHistorico, d.CdPlanoCaixa })
                .HasConstraintName("controle_cheques_fk2");
        });

        modelBuilder.Entity<ControleUsuario>(entity =>
        {
            entity.HasKey(e => e.NrControle).HasName("controle_usuario_pkey");

            entity.ToTable("controle_usuario");

            entity.Property(e => e.NrControle)
                .HasDefaultValueSql("nextval('gen_ct_usr_id'::regclass)")
                .HasColumnName("nr_controle");
            entity.Property(e => e.DtHr)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dt_hr");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(62)
                .HasColumnName("nm_usuario");
            entity.Property(e => e.Tabela)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tabela");
            entity.Property(e => e.TpAcao)
                .HasMaxLength(1)
                .HasColumnName("tp_acao");
            entity.Property(e => e.TxtAcao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_acao");

            entity.HasOne(d => d.NmUsuarioNavigation).WithMany(p => p.ControleUsuarios)
                .HasForeignKey(d => d.NmUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("controle_usuario_fk");
        });

        modelBuilder.Entity<Convenio>(entity =>
        {
            entity.HasKey(e => e.CdConvenio).HasName("convenio_pkey");

            entity.ToTable("convenio");

            entity.Property(e => e.CdConvenio)
                .HasDefaultValueSql("nextval('gen_convenio_id'::regclass)")
                .HasColumnName("cd_convenio");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.NmConvenio)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_convenio");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_telefone");
            entity.Property(e => e.RazaoSocial)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("razao_social");
        });

        modelBuilder.Entity<CredenciadoraCartao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("credenciadora_cartao_pkey");

            entity.ToTable("credenciadora_cartao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(32)
                .HasColumnName("cnpj");
            entity.Property(e => e.Descricao)
                .HasMaxLength(128)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<Cst>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cst_pkey");

            entity.ToTable("cst");

            entity.HasIndex(e => e.Descricao, "cst_idx");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");

            entity.HasMany(d => d.Cfops).WithMany(p => p.Csts)
                .UsingEntity<Dictionary<string, object>>(
                    "CstCfop",
                    r => r.HasOne<Cfop>().WithMany()
                        .HasForeignKey("Cfop")
                        .HasConstraintName("cst_cfop_fk1"),
                    l => l.HasOne<Cst>().WithMany()
                        .HasForeignKey("Cst")
                        .HasConstraintName("cst_cfop_fk"),
                    j =>
                    {
                        j.HasKey("Cst", "Cfop").HasName("cst_cfop_pkey");
                        j.ToTable("cst_cfop");
                        j.IndexerProperty<string>("Cst")
                            .HasMaxLength(2)
                            .HasColumnName("cst");
                        j.IndexerProperty<string>("Cfop")
                            .HasMaxLength(5)
                            .HasColumnName("cfop");
                    });
        });

        modelBuilder.Entity<CstConfin>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cst_confins_pkey");

            entity.ToTable("cst_confins");

            entity.HasIndex(e => e.Nome, "cst_confins_idx");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<CstIpi>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cst_ipi_pkey");

            entity.ToTable("cst_ipi");

            entity.HasIndex(e => e.Nome, "cst_ipi_idx");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<CstPi>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cst_pis_pkey");

            entity.ToTable("cst_pis");

            entity.HasIndex(e => e.Nome, "cst_pis_idx");

            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Cte>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_pkey");

            entity.ToTable("cte");

            entity.HasIndex(e => e.NrCte, "cte_nr_cte_key").IsUnique();

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.AliqIcms)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliq_icms");
            entity.Property(e => e.AliqInterestUft)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliq_interest_uft");
            entity.Property(e => e.AliqInternaUft)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliq_interna_uft");
            entity.Property(e => e.CaractAdServico)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("caract_ad_servico");
            entity.Property(e => e.CaractAdTransp)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("caract_ad_transp");
            entity.Property(e => e.CdDestinatario)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_destinatario");
            entity.Property(e => e.CdExpedidor)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_expedidor");
            entity.Property(e => e.CdModeloTomador)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_modelo_tomador");
            entity.Property(e => e.CdNumerico)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_numerico");
            entity.Property(e => e.CdPartUft)
                .HasMaxLength(3)
                .HasDefaultValueSql("0")
                .HasColumnName("cd_part_uft");
            entity.Property(e => e.CdRecebedor)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_recebedor");
            entity.Property(e => e.CdRemetente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_remetente");
            entity.Property(e => e.CdRotaEntrega)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_rota_entrega");
            entity.Property(e => e.CdSituacaoCte)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_situacao_cte");
            entity.Property(e => e.CdStIcms)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_st_icms");
            entity.Property(e => e.CdTomadorServico)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_tomador_servico");
            entity.Property(e => e.Cfop)
                .HasMaxLength(4)
                .HasColumnName("cfop");
            entity.Property(e => e.ChaveAcesso)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_acesso");
            entity.Property(e => e.ChaveAcessoReferenc)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_acesso_referenc");
            entity.Property(e => e.ChaveCteAnulacao)
                .HasMaxLength(44)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_cte_anulacao");
            entity.Property(e => e.ChaveCteSubst)
                .HasMaxLength(44)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_cte_subst");
            entity.Property(e => e.ChaveCteTomador)
                .HasMaxLength(44)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_cte_tomador");
            entity.Property(e => e.ChaveNfeTomador)
                .HasMaxLength(44)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_nfe_tomador");
            entity.Property(e => e.Ciot)
                .HasMaxLength(12)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ciot");
            entity.Property(e => e.CnpjTomador)
                .HasMaxLength(14)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cnpj_tomador");
            entity.Property(e => e.CpfTomador)
                .HasMaxLength(11)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cpf_tomador");
            entity.Property(e => e.DadosRetirada)
                .HasMaxLength(2)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("dados_retirada");
            entity.Property(e => e.DataViagem).HasColumnName("data_viagem");
            entity.Property(e => e.DestinoFluxoCaixa)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("destino_fluxo_caixa");
            entity.Property(e => e.Detalhe)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("detalhe");
            entity.Property(e => e.DtFimPrevisao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_fim_previsao");
            entity.Property(e => e.DtHrEmissao)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("dt_hr_emissao");
            entity.Property(e => e.DtInicioPrevisao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_inicio_previsao");
            entity.Property(e => e.DtPrevEntrega)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_prev_entrega");
            entity.Property(e => e.DtTomador)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_tomador");
            entity.Property(e => e.FinalidadeEmissao)
                .HasMaxLength(2)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("finalidade_emissao");
            entity.Property(e => e.FormaEmissao)
                .HasMaxLength(2)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("forma_emissao");
            entity.Property(e => e.FormaPagto)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("forma_pagto");
            entity.Property(e => e.FuncEmissorCte)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("func_emissor_cte");
            entity.Property(e => e.HoraViagem)
                .HasPrecision(0)
                .HasColumnName("hora_viagem");
            entity.Property(e => e.HrFimPrevisao)
                .HasPrecision(0)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_fim_previsao");
            entity.Property(e => e.HrInicioPrevisao)
                .HasPrecision(0)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_inicio_previsao");
            entity.Property(e => e.IcmsUfTermino)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("icms_uf_termino");
            entity.Property(e => e.IndicadorLot)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("indicador_lot");
            entity.Property(e => e.InfFiscoIcms)
                .HasMaxLength(16384)
                .HasDefaultValueSql("0")
                .HasColumnName("inf_fisco_icms");
            entity.Property(e => e.Inss)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("inss");
            entity.Property(e => e.Modal)
                .HasMaxLength(2)
                .HasColumnName("modal");
            entity.Property(e => e.Modelo)
                .HasMaxLength(2)
                .HasDefaultValueSql("'57'::character varying")
                .HasColumnName("modelo");
            entity.Property(e => e.MunicipioDestinoCalcFrete)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("municipio_destino_calc_frete");
            entity.Property(e => e.MunicipioEmissao)
                .HasMaxLength(10)
                .HasColumnName("municipio_emissao");
            entity.Property(e => e.MunicipioFimPrestacao)
                .HasMaxLength(10)
                .HasColumnName("municipio_fim_prestacao");
            entity.Property(e => e.MunicipioInicioPrestacao)
                .HasMaxLength(10)
                .HasColumnName("municipio_inicio_prestacao");
            entity.Property(e => e.MunicipioOrigemCalcFrete)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("municipio_origem_calc_frete");
            entity.Property(e => e.NrAutorizacaoCte)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_autorizacao_cte");
            entity.Property(e => e.NrCnf).HasColumnName("nr_cnf");
            entity.Property(e => e.NrCte)
                .HasMaxLength(10)
                .HasColumnName("nr_cte");
            entity.Property(e => e.NrCteReferenciado)
                .HasMaxLength(162)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_cte_referenciado");
            entity.Property(e => e.NrFatura)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_fatura");
            entity.Property(e => e.NrProtoCancelamento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_proto_cancelamento");
            entity.Property(e => e.NrRegEstadual)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_reg_estadual");
            entity.Property(e => e.NrTaf)
                .HasMaxLength(12)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_taf");
            entity.Property(e => e.NumeroTomador)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("numero_tomador");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("obs");
            entity.Property(e => e.OrigemFluxoCaixa)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("origem_fluxo_caixa");
            entity.Property(e => e.OutrasCaractProd)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("outras_caract_prod");
            entity.Property(e => e.PorcIcmsFcpUft)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_icms_fcp_uft");
            entity.Property(e => e.PorcPartUft)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_part_uft");
            entity.Property(e => e.PorcRedBcIcms)
                .HasPrecision(6, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_red_bc_icms");
            entity.Property(e => e.PrevisaoData)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("previsao_data");
            entity.Property(e => e.PrevisaoHora)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("previsao_hora");
            entity.Property(e => e.ProdPredominante)
                .HasMaxLength(60)
                .HasColumnName("prod_predominante");
            entity.Property(e => e.QtPassageiro)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_passageiro");
            entity.Property(e => e.RetemInss)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("retem_inss");
            entity.Property(e => e.Rntcr)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("rntcr");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasDefaultValueSql("'001'::character varying")
                .HasColumnName("serie");
            entity.Property(e => e.SerieTomador)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serie_tomador");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.Subserie)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("subserie");
            entity.Property(e => e.TipoViagem)
                .HasMaxLength(1)
                .HasColumnName("tipo_viagem");
            entity.Property(e => e.TomadorCteSubst)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tomador_cte_subst");
            entity.Property(e => e.TomadorNc)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tomador_nc");
            entity.Property(e => e.TpDestinatario)
                .HasMaxLength(2)
                .HasDefaultValueSql("'C'::character varying")
                .HasColumnName("tp_destinatario");
            entity.Property(e => e.TpDocTomador)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_doc_tomador");
            entity.Property(e => e.TpExpedidor)
                .HasMaxLength(2)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("tp_expedidor");
            entity.Property(e => e.TpRecebedor)
                .HasMaxLength(2)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("tp_recebedor");
            entity.Property(e => e.TpRemetente)
                .HasMaxLength(2)
                .HasDefaultValueSql("'C'::character varying")
                .HasColumnName("tp_remetente");
            entity.Property(e => e.TpServico)
                .HasMaxLength(2)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("tp_servico");
            entity.Property(e => e.TpTomadorServico)
                .HasMaxLength(2)
                .HasDefaultValueSql("'RM'::character varying")
                .HasColumnName("tp_tomador_servico");
            entity.Property(e => e.TxtJustificativaCancelamento)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_justificativa_cancelamento");
            entity.Property(e => e.TxtdescServicoPrestado)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txtdesc_servico_prestado");
            entity.Property(e => e.VlBcIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_bc_icms");
            entity.Property(e => e.VlBcIcmsUft)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_bc_icms_uft");
            entity.Property(e => e.VlCarga)
                .HasPrecision(18, 2)
                .HasColumnName("vl_carga");
            entity.Property(e => e.VlCredPresumido)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cred_presumido");
            entity.Property(e => e.VlDescFatura)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desc_fatura");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsFcpUf)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms_fcp_uf");
            entity.Property(e => e.VlIcmsPartUfi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms_part_ufi");
            entity.Property(e => e.VlIcmsPartUft)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms_part_uft");
            entity.Property(e => e.VlLiqFatura)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_liq_fatura");
            entity.Property(e => e.VlOriginalFatura)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_original_fatura");
            entity.Property(e => e.VlPrestServico)
                .HasPrecision(18, 2)
                .HasColumnName("vl_prest_servico");
            entity.Property(e => e.VlReceberPrestServico)
                .HasPrecision(18, 2)
                .HasColumnName("vl_receber_prest_servico");
            entity.Property(e => e.VlTomador)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_tomador");
            entity.Property(e => e.VlTribtPrestServico)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_tribt_prest_servico");
            entity.Property(e => e.XmlCte)
                .HasDefaultValueSql("''::text")
                .HasColumnName("xml_cte");
        });

        modelBuilder.Entity<CteCompPrestacao>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_comp_prestacao_pkey");

            entity.ToTable("cte_comp_prestacao");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(15)
                .HasColumnName("nome");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<CteDocAnterior>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_doc_anterior_pkey");

            entity.ToTable("cte_doc_anterior");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cnpj");
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cpf");
            entity.Property(e => e.InscEstadual)
                .HasMaxLength(64)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("insc_estadual");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .HasColumnName("nome");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.TpDocumento)
                .HasMaxLength(2)
                .HasColumnName("tp_documento");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uf");
        });

        modelBuilder.Entity<CteDocAnteriorNfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("cte_doc_anterior_nfe_pkey");

            entity.ToTable("cte_doc_anterior_nfe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdChave)
                .HasMaxLength(162)
                .HasColumnName("id_chave");
            entity.Property(e => e.IdDocAnterior).HasColumnName("id_doc_anterior");

            entity.HasOne(d => d.IdDocAnteriorNavigation).WithMany(p => p.CteDocAnteriorNves)
                .HasForeignKey(d => d.IdDocAnterior)
                .HasConstraintName("cte_doc_anterior_nfe_fk");
        });

        modelBuilder.Entity<CteDuplicatum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_duplicata_pkey");

            entity.ToTable("cte_duplicata");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.DtVenc).HasColumnName("dt_venc");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Numero)
                .HasMaxLength(60)
                .HasColumnName("numero");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<CteNf>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_nf_pkey");

            entity.ToTable("cte_nf");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.BcIcms)
                .HasPrecision(18, 2)
                .HasColumnName("bc_icms");
            entity.Property(e => e.BcIcmsSt)
                .HasPrecision(18, 2)
                .HasColumnName("bc_icms_st");
            entity.Property(e => e.Cfop)
                .HasMaxLength(4)
                .HasColumnName("cfop");
            entity.Property(e => e.DtEmissao).HasColumnName("dt_emissao");
            entity.Property(e => e.DtPrevista).HasColumnName("dt_prevista");
            entity.Property(e => e.Modelo)
                .HasMaxLength(2)
                .HasColumnName("modelo");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.NrPedidoNf)
                .HasMaxLength(20)
                .HasColumnName("nr_pedido_nf");
            entity.Property(e => e.NrRomaneioNf)
                .HasMaxLength(20)
                .HasColumnName("nr_romaneio_nf");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .HasColumnName("numero");
            entity.Property(e => e.Peso)
                .HasPrecision(18, 3)
                .HasColumnName("peso");
            entity.Property(e => e.Pin).HasColumnName("pin");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.TpUnidade)
                .HasMaxLength(2)
                .HasColumnName("tp_unidade");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(18, 2)
                .HasColumnName("vl_icms_st");
            entity.Property(e => e.VlNota)
                .HasPrecision(18, 2)
                .HasColumnName("vl_nota");
            entity.Property(e => e.VlProd)
                .HasPrecision(18, 2)
                .HasColumnName("vl_prod");
        });

        modelBuilder.Entity<CteNfe>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_nfe_pkey");

            entity.ToTable("cte_nfe");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.DtPrevista).HasColumnName("dt_prevista");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Pin).HasColumnName("pin");
            entity.Property(e => e.TpUnidade)
                .HasMaxLength(2)
                .HasColumnName("tp_unidade");
        });

        modelBuilder.Entity<CteOb>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_obs_contrib_pkey");

            entity.ToTable("cte_obs");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('cte_obs_contrib_codigo_seq'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Identificador)
                .HasMaxLength(20)
                .HasColumnName("identificador");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasColumnName("obs");
            entity.Property(e => e.TpObs)
                .HasMaxLength(2)
                .HasColumnName("tp_obs");
        });

        modelBuilder.Entity<CteOrdemColetum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_ordem_coleta_pkey");

            entity.ToTable("cte_ordem_coleta");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(10)
                .HasColumnName("cd_interno");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(14)
                .HasColumnName("cnpj");
            entity.Property(e => e.DtEmissao).HasColumnName("dt_emissao");
            entity.Property(e => e.InscEstadual)
                .HasMaxLength(64)
                .HasColumnName("insc_estadual");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.NrOcc).HasColumnName("nr_occ");
            entity.Property(e => e.SerieOcc)
                .HasMaxLength(3)
                .HasColumnName("serie_occ");
            entity.Property(e => e.Telefone)
                .HasMaxLength(11)
                .HasColumnName("telefone");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<CteOutrosDoc>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_outros_doc_pkey");

            entity.ToTable("cte_outros_doc");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao");
            entity.Property(e => e.DtEmissao).HasColumnName("dt_emissao");
            entity.Property(e => e.DtPrevista).HasColumnName("dt_prevista");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Numero)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("numero");
            entity.Property(e => e.TpDocumento)
                .HasMaxLength(2)
                .HasColumnName("tp_documento");
            entity.Property(e => e.TpUnidade)
                .HasMaxLength(2)
                .HasColumnName("tp_unidade");
            entity.Property(e => e.VlDocumento)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_documento");
        });

        modelBuilder.Entity<CtePassagem>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_passagem_pkey");

            entity.ToTable("cte_passagem");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.NrPassagem)
                .HasMaxLength(15)
                .HasColumnName("nr_passagem");
        });

        modelBuilder.Entity<CteProdPerigoso>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_prod_perigoso_pkey");

            entity.ToTable("cte_prod_perigoso");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.ClasseRisco).HasColumnName("classe_risco");
            entity.Property(e => e.GrupoEmbalagem)
                .HasMaxLength(6)
                .HasColumnName("grupo_embalagem");
            entity.Property(e => e.NmEmbarqueProd)
                .HasMaxLength(16384)
                .HasColumnName("nm_embarque_prod");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.NrOnu).HasColumnName("nr_onu");
            entity.Property(e => e.PontoFulgor)
                .HasMaxLength(6)
                .HasColumnName("ponto_fulgor");
            entity.Property(e => e.QtdTipoVolume)
                .HasMaxLength(60)
                .HasColumnName("qtd_tipo_volume");
            entity.Property(e => e.QtdTotalProd)
                .HasPrecision(18, 3)
                .HasColumnName("qtd_total_prod");
        });

        modelBuilder.Entity<CteQtdCarga>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_qtd_carga_pkey");

            entity.ToTable("cte_qtd_carga");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Qtd)
                .HasPrecision(18, 3)
                .HasColumnName("qtd");
            entity.Property(e => e.TpMedida)
                .HasMaxLength(20)
                .HasColumnName("tp_medida");
            entity.Property(e => e.UnMedida)
                .HasMaxLength(2)
                .HasColumnName("un_medida");
        });

        modelBuilder.Entity<CteRodMotoristum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_rod_motorista_pkey");

            entity.ToTable("cte_rod_motorista");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .HasColumnName("cpf");
            entity.Property(e => e.Nome)
                .HasMaxLength(60)
                .HasColumnName("nome");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
        });

        modelBuilder.Entity<CteRodVeiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_rod_veiculo_pkey");

            entity.ToTable("cte_rod_veiculo");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CapacidadeKg).HasColumnName("capacidade_kg");
            entity.Property(e => e.CapacidadeM3).HasColumnName("capacidade_m3");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(10)
                .HasColumnName("cd_interno");
            entity.Property(e => e.NmSeguradora)
                .HasMaxLength(30)
                .HasColumnName("nm_seguradora");
            entity.Property(e => e.NrApolice)
                .HasMaxLength(20)
                .HasColumnName("nr_apolice");
            entity.Property(e => e.NrAverbacao)
                .HasMaxLength(20)
                .HasColumnName("nr_averbacao");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.PertenceEmitente)
                .HasMaxLength(1)
                .HasColumnName("pertence_emitente");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");
            entity.Property(e => e.PropCnpj)
                .HasMaxLength(14)
                .HasColumnName("prop_cnpj");
            entity.Property(e => e.PropCpf)
                .HasMaxLength(11)
                .HasColumnName("prop_cpf");
            entity.Property(e => e.PropInscEstadual)
                .HasMaxLength(14)
                .HasColumnName("prop_insc_estadual");
            entity.Property(e => e.PropRazaoSocial)
                .HasMaxLength(60)
                .HasColumnName("prop_razao_social");
            entity.Property(e => e.PropRntrc)
                .HasMaxLength(8)
                .HasColumnName("prop_rntrc");
            entity.Property(e => e.PropTipoDocumento)
                .HasMaxLength(2)
                .HasColumnName("prop_tipo_documento");
            entity.Property(e => e.PropTpProprietario)
                .HasMaxLength(2)
                .HasColumnName("prop_tp_proprietario");
            entity.Property(e => e.PropUf)
                .HasMaxLength(2)
                .HasColumnName("prop_uf");
            entity.Property(e => e.Renavam)
                .HasMaxLength(11)
                .HasColumnName("renavam");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(2)
                .HasColumnName("responsavel");
            entity.Property(e => e.Tara).HasColumnName("tara");
            entity.Property(e => e.TpCarroceria)
                .HasMaxLength(2)
                .HasColumnName("tp_carroceria");
            entity.Property(e => e.TpProprietario)
                .HasMaxLength(2)
                .HasColumnName("tp_proprietario");
            entity.Property(e => e.TpRodado)
                .HasMaxLength(2)
                .HasColumnName("tp_rodado");
            entity.Property(e => e.TpVeiculo)
                .HasMaxLength(2)
                .HasColumnName("tp_veiculo");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.VlMercadoria)
                .HasPrecision(18, 2)
                .HasColumnName("vl_mercadoria");
        });

        modelBuilder.Entity<CteSeguro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_seguro_pkey");

            entity.ToTable("cte_seguro");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.NmSeguradoura)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_seguradoura");
            entity.Property(e => e.NrApolice)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_apolice");
            entity.Property(e => e.NrAverbacao)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_averbacao");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(2)
                .HasColumnName("responsavel");
            entity.Property(e => e.VlMercadoria)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_mercadoria");
        });

        modelBuilder.Entity<CteValePedagio>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_vale_pedagio_pkey");

            entity.ToTable("cte_vale_pedagio");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.CnpjFornecedora)
                .HasMaxLength(14)
                .HasColumnName("cnpj_fornecedora");
            entity.Property(e => e.CnpjResponsavel)
                .HasMaxLength(14)
                .HasColumnName("cnpj_responsavel");
            entity.Property(e => e.NrComprovante)
                .HasMaxLength(20)
                .HasColumnName("nr_comprovante");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<CteVeiculo>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("cte_veiculo_pkey");

            entity.ToTable("cte_veiculo");

            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.CdMarcaModelo)
                .HasMaxLength(6)
                .HasColumnName("cd_marca_modelo");
            entity.Property(e => e.Chassi)
                .HasMaxLength(17)
                .HasColumnName("chassi");
            entity.Property(e => e.Cor)
                .HasMaxLength(3)
                .HasColumnName("cor");
            entity.Property(e => e.Frete)
                .HasPrecision(18, 2)
                .HasColumnName("frete");
            entity.Property(e => e.NmCor)
                .HasMaxLength(40)
                .HasColumnName("nm_cor");
            entity.Property(e => e.NrCte).HasColumnName("nr_cte");
            entity.Property(e => e.VlVeiculo)
                .HasPrecision(18, 2)
                .HasColumnName("vl_veiculo");
        });

        modelBuilder.Entity<CupomNfe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cupom_nfe");

            entity.Property(e => e.Coo)
                .HasMaxLength(162)
                .HasColumnName("coo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.Idsaida).HasColumnName("idsaida");
            entity.Property(e => e.ValorVenda)
                .HasPrecision(18, 4)
                .HasColumnName("valor_venda");
        });

        modelBuilder.Entity<CurvaAbc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("curva_abc");

            entity.Property(e => e.Classif).HasColumnName("classif");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(62)
                .HasColumnName("descricao");
            entity.Property(e => e.Faixa)
                .HasMaxLength(1)
                .HasColumnName("faixa");
            entity.Property(e => e.PorcFaixa)
                .HasPrecision(18, 2)
                .HasColumnName("porc_faixa");
            entity.Property(e => e.PorcQtAc)
                .HasPrecision(18, 4)
                .HasColumnName("porc_qt_ac");
            entity.Property(e => e.PorcQtTotal)
                .HasPrecision(18, 4)
                .HasColumnName("porc_qt_total");
            entity.Property(e => e.PorcVlConsAc)
                .HasPrecision(18, 4)
                .HasColumnName("porc_vl_cons_ac");
            entity.Property(e => e.QtConsumo)
                .HasPrecision(18, 4)
                .HasColumnName("qt_consumo");
            entity.Property(e => e.Unidade)
                .HasMaxLength(4)
                .HasColumnName("unidade");
            entity.Property(e => e.VlConsumo)
                .HasPrecision(18, 4)
                .HasColumnName("vl_consumo");
            entity.Property(e => e.VlConsumoAc)
                .HasPrecision(18, 4)
                .HasColumnName("vl_consumo_ac");
            entity.Property(e => e.VlUnit)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit");
        });

        modelBuilder.Entity<DadosBancFornecedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dados_banc_fornecedor_pkey");

            entity.ToTable("dados_banc_fornecedor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Agencia)
                .HasMaxLength(16)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("agencia");
            entity.Property(e => e.ChavePix)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_pix");
            entity.Property(e => e.IdConta)
                .HasMaxLength(16)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_conta");
            entity.Property(e => e.IdFornecedor).HasColumnName("id_fornecedor");
            entity.Property(e => e.NmBanco)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_banco");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.IdFornecedorNavigation).WithMany(p => p.DadosBancFornecedors)
                .HasForeignKey(d => d.IdFornecedor)
                .HasConstraintName("dados_banc_fornecedor_fk");
        });

        modelBuilder.Entity<DadosEcf>(entity =>
        {
            entity.HasKey(e => e.NrEcf).HasName("dados_ecf_pkey");

            entity.ToTable("dados_ecf");

            entity.Property(e => e.NrEcf)
                .HasMaxLength(15)
                .HasColumnName("nr_ecf");
            entity.Property(e => e.CdFrente)
                .HasMaxLength(10)
                .HasColumnName("cd_frente");
            entity.Property(e => e.Crz)
                .HasMaxLength(6)
                .HasColumnName("crz");
            entity.Property(e => e.IdFrente).HasColumnName("id_frente");
            entity.Property(e => e.NrSerieEcf)
                .HasMaxLength(62)
                .HasColumnName("nr_serie_ecf");
        });

        modelBuilder.Entity<DadosVendConsumidor>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("dados_vend_consumidor_pkey");

            entity.ToTable("dados_vend_consumidor");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_dados_vend_consumidor_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cancelada");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.Lote)
                .HasMaxLength(62)
                .HasColumnName("lote");
            entity.Property(e => e.NrCab).HasColumnName("nr_cab");
            entity.Property(e => e.PorcIbpt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ibpt");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.VlAproxImposto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_aprox_imposto");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnit)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.DadosVendConsumidors)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dados_vend_consumidor_fk1");

            entity.HasOne(d => d.NrCabNavigation).WithMany(p => p.DadosVendConsumidors)
                .HasForeignKey(d => d.NrCab)
                .HasConstraintName("dados_vend_consumidor_fk");
        });

        modelBuilder.Entity<DavCabecalho>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dav_cabecalho_pkey");

            entity.ToTable("dav_cabecalho");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("acrescimo");
            entity.Property(e => e.Ccf).HasColumnName("ccf");
            entity.Property(e => e.CodigoManipulado)
                .HasMaxLength(20)
                .HasColumnName("codigo_manipulado");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.CooDavEcf)
                .HasMaxLength(10)
                .HasColumnName("coo_dav_ecf");
            entity.Property(e => e.CpfCnpjDestinatario)
                .HasMaxLength(14)
                .HasColumnName("cpf_cnpj_destinatario");
            entity.Property(e => e.DataEmissao).HasColumnName("data_emissao");
            entity.Property(e => e.Decricao)
                .HasMaxLength(60)
                .HasColumnName("decricao");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 6)
                .HasColumnName("desconto");
            entity.Property(e => e.EcfPrint)
                .HasMaxLength(10)
                .HasColumnName("ecf_print");
            entity.Property(e => e.Hash)
                .HasMaxLength(250)
                .HasColumnName("hash");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.HoraEmissao)
                .HasMaxLength(8)
                .HasColumnName("hora_emissao");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdPessoa).HasColumnName("id_pessoa");
            entity.Property(e => e.Impresso)
                .HasMaxLength(1)
                .HasColumnName("impresso");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Ndv)
                .HasMaxLength(10)
                .HasColumnName("ndv");
            entity.Property(e => e.NomeDestinatario)
                .HasMaxLength(100)
                .HasColumnName("nome_destinatario");
            entity.Property(e => e.NumeroDav)
                .HasMaxLength(10)
                .HasColumnName("numero_dav");
            entity.Property(e => e.NumeroEcf)
                .HasMaxLength(20)
                .HasColumnName("numero_ecf");
            entity.Property(e => e.Situacao)
                .HasMaxLength(1)
                .HasColumnName("situacao");
            entity.Property(e => e.Subtotal)
                .HasPrecision(18, 6)
                .HasColumnName("subtotal");
            entity.Property(e => e.TaxaAcrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_acrescimo");
            entity.Property(e => e.TaxaDesconto)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_desconto");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 6)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<DavDetalhe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("dav_detalhe_pkey");

            entity.ToTable("dav_detalhe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasColumnName("cancelado");
            entity.Property(e => e.DataEmissao).HasColumnName("data_emissao");
            entity.Property(e => e.DataMovimento).HasColumnName("data_movimento");
            entity.Property(e => e.DescricaoPdv)
                .HasMaxLength(30)
                .HasColumnName("descricao_pdv");
            entity.Property(e => e.GtinProduto)
                .HasMaxLength(14)
                .HasColumnName("gtin_produto");
            entity.Property(e => e.Hash)
                .HasMaxLength(250)
                .HasColumnName("hash");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.IdDavCabecalho).HasColumnName("id_dav_cabecalho");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("integrador");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.MesclaProduto)
                .HasMaxLength(1)
                .HasColumnName("mescla_produto");
            entity.Property(e => e.NomeProduto)
                .HasMaxLength(100)
                .HasColumnName("nome_produto");
            entity.Property(e => e.NumeroDav)
                .HasMaxLength(10)
                .HasColumnName("numero_dav");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 6)
                .HasColumnName("quantidade");
            entity.Property(e => e.TotalizadorParcial)
                .HasMaxLength(10)
                .HasColumnName("totalizador_parcial");
            entity.Property(e => e.UnidadeProduto)
                .HasMaxLength(10)
                .HasColumnName("unidade_produto");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 6)
                .HasColumnName("valor_total");
            entity.Property(e => e.ValorUnitario)
                .HasPrecision(18, 6)
                .HasColumnName("valor_unitario");

            entity.HasOne(d => d.IdDavCabecalhoNavigation).WithMany(p => p.DavDetalhes)
                .HasForeignKey(d => d.IdDavCabecalho)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("dav_detalhe_ibfk_2");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.DavDetalhes)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("dav_detalhe_fk");
        });

        modelBuilder.Entity<Davmani>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("davmani_pkey");

            entity.ToTable("davmani");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Numdav)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("numdav");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("departamento_pkey");

            entity.ToTable("departamento");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_departamento_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<DescricaoDespesa>(entity =>
        {
            entity.HasKey(e => e.NrDescDespesa).HasName("descricao_despesa_pkey");

            entity.ToTable("descricao_despesa");

            entity.Property(e => e.NrDescDespesa)
                .HasDefaultValueSql("nextval('gen_descricao_despesa_id'::regclass)")
                .HasColumnName("nr_desc_despesa");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<DetalheVendaFarmPopular>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("detalhe_venda_farm_popular_pkey");

            entity.ToTable("detalhe_venda_farm_popular");

            entity.HasIndex(e => e.NrCabecalho, "detalhe_venda_farm_popular_idx");

            entity.HasIndex(e => e.CdMedico, "detalhe_venda_farm_popular_idx1");

            entity.HasIndex(e => e.CdProduto, "detalhe_venda_farm_popular_idx2");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_det_vd_far_pop'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdMedico).HasColumnName("cd_medico");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CodAutorizacaoSus)
                .HasMaxLength(20)
                .HasColumnName("cod_autorizacao_sus");
            entity.Property(e => e.CodConfEstorno)
                .HasMaxLength(20)
                .HasColumnName("cod_conf_estorno");
            entity.Property(e => e.CodEstornoDatasus)
                .HasMaxLength(150)
                .HasColumnName("cod_estorno_datasus");
            entity.Property(e => e.CodSolicitadoDatasus)
                .HasMaxLength(150)
                .HasColumnName("cod_solicitado_datasus");
            entity.Property(e => e.DtPrescricao).HasColumnName("dt_prescricao");
            entity.Property(e => e.Estornou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("estornou");
            entity.Property(e => e.NrCabecalho).HasColumnName("nr_cabecalho");
            entity.Property(e => e.QtAutorizadoSus)
                .HasPrecision(18, 4)
                .HasColumnName("qt_autorizado_sus");
            entity.Property(e => e.QtDiariaPrescrita)
                .HasPrecision(18, 4)
                .HasColumnName("qt_diaria_prescrita");
            entity.Property(e => e.QtSolicitado)
                .HasPrecision(18, 4)
                .HasColumnName("qt_solicitado");
            entity.Property(e => e.StatusTransmissao)
                .HasMaxLength(150)
                .HasColumnName("status_transmissao");
            entity.Property(e => e.StatusTransmissaoMed)
                .HasMaxLength(150)
                .HasColumnName("status_transmissao_med");
            entity.Property(e => e.VlTotalPacSus)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_total_pac_sus");
            entity.Property(e => e.VlTotalSus)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_total_sus");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unitario");
            entity.Property(e => e.VlVendaApres)
                .HasPrecision(18, 4)
                .HasColumnName("vl_venda_apres");

            entity.HasOne(d => d.CdMedicoNavigation).WithMany(p => p.DetalheVendaFarmPopulars)
                .HasForeignKey(d => d.CdMedico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalhe_venda_farm_popular_fk1");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.DetalheVendaFarmPopulars)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("detalhe_venda_farm_popular_fk2");

            entity.HasOne(d => d.NrCabecalhoNavigation).WithMany(p => p.DetalheVendaFarmPopulars)
                .HasForeignKey(d => d.NrCabecalho)
                .HasConstraintName("detalhe_venda_farm_popular_fk");
        });

        modelBuilder.Entity<DistribuicaoDfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("distribuicao_dfe_pkey");

            entity.ToTable("distribuicao_dfe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ChaveAcessoNfe)
                .HasMaxLength(50)
                .HasColumnName("chave_acesso_nfe");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.DtInclusao).HasColumnName("dt_inclusao");
            entity.Property(e => e.DtRecebimento).HasColumnName("dt_recebimento");
            entity.Property(e => e.Emissao)
                .HasMaxLength(20)
                .HasColumnName("emissao");
            entity.Property(e => e.Ie)
                .HasMaxLength(30)
                .HasColumnName("ie");
            entity.Property(e => e.Impresso)
                .HasMaxLength(20)
                .HasColumnName("impresso");
            entity.Property(e => e.Manifesto)
                .HasMaxLength(1)
                .HasColumnName("manifesto");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("nome");
            entity.Property(e => e.NrNotaFiscal)
                .HasMaxLength(20)
                .HasColumnName("nr_nota_fiscal");
            entity.Property(e => e.Nsu)
                .HasMaxLength(20)
                .HasColumnName("nsu");
            entity.Property(e => e.Serie)
                .HasMaxLength(3)
                .HasColumnName("serie");
            entity.Property(e => e.TpNfe)
                .HasMaxLength(20)
                .HasColumnName("tp_nfe");
            entity.Property(e => e.TpResposta)
                .HasMaxLength(1)
                .HasColumnName("tp_resposta");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasColumnName("transferiu");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Xml)
                .HasDefaultValueSql("''::text")
                .HasColumnName("xml");
        });

        modelBuilder.Entity<Diverso>(entity =>
        {
            entity.HasKey(e => e.CdDiv).HasName("diversos_pkey");

            entity.ToTable("diversos");

            entity.HasIndex(e => e.CdTipo, "diversos_idx");

            entity.HasIndex(e => e.CdChave, "diversos_idx1");

            entity.Property(e => e.CdDiv)
                .HasDefaultValueSql("nextval(('public.gen_diversos'::text)::regclass)")
                .HasColumnName("cd_div");
            entity.Property(e => e.CdChave)
                .HasMaxLength(15)
                .HasColumnName("cd_chave");
            entity.Property(e => e.CdHistorico)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_historico");
            entity.Property(e => e.CdPlanoCaixa)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_plano_caixa");
            entity.Property(e => e.CdPlanoEstoque)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_plano_estoque");
            entity.Property(e => e.CdTipo)
                .HasMaxLength(6)
                .HasColumnName("cd_tipo");
            entity.Property(e => e.NmDiv)
                .HasMaxLength(62)
                .HasColumnName("nm_div");
            entity.Property(e => e.NrConta)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_conta");
            entity.Property(e => e.Observacao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("observacao");
        });

        modelBuilder.Entity<EcfAliquota>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_aliquotas_pkey");

            entity.ToTable("ecf_aliquotas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EcfIcmsSt)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ecf_icms_st");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.PafPSt)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("paf_p_st");
            entity.Property(e => e.TotalizadorParcial)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("totalizador_parcial");
        });

        modelBuilder.Entity<EcfCaixa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_caixa_pkey");

            entity.ToTable("ecf_caixa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataCadastro).HasColumnName("data_cadastro");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Nome)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nome");
        });

        modelBuilder.Entity<EcfConfiguracao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_configuracao_pkey");

            entity.ToTable("ecf_configuracao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Arredondaqtde)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("arredondaqtde");
            entity.Property(e => e.BaixarEstoqueRetaguarda)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("baixar_estoque_retaguarda");
            entity.Property(e => e.BalancaComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("balanca_comanda");
            entity.Property(e => e.BaudBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("baud_bal_comanda");
            entity.Property(e => e.BitsPorSegundo)
                .HasDefaultValueSql("0")
                .HasColumnName("bits_por_segundo");
            entity.Property(e => e.CaminhoImagensLayout)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("caminho_imagens_layout");
            entity.Property(e => e.CaminhoImagensMarketing)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("caminho_imagens_marketing");
            entity.Property(e => e.CaminhoImagensProdutos)
                .HasMaxLength(250)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("caminho_imagens_produtos");
            entity.Property(e => e.CfopEcf)
                .HasDefaultValueSql("0")
                .HasColumnName("cfop_ecf");
            entity.Property(e => e.CfopNf2)
                .HasDefaultValueSql("0")
                .HasColumnName("cfop_nf2");
            entity.Property(e => e.ComandaAbertura)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("comanda_abertura");
            entity.Property(e => e.ConfiguracaoBalanca)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("configuracao_balanca");
            entity.Property(e => e.ControleCancItem)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("controle_canc_item");
            entity.Property(e => e.ControleComanda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("controle_comanda");
            entity.Property(e => e.CorJanelasInternas)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cor_janelas_internas");
            entity.Property(e => e.DataAtualizacaoEstoque).HasColumnName("data_atualizacao_estoque");
            entity.Property(e => e.DataBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("data_bal_comanda");
            entity.Property(e => e.DavEcf)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("dav_ecf");
            entity.Property(e => e.DecimaisQuantidade)
                .HasDefaultValueSql("0")
                .HasColumnName("decimais_quantidade");
            entity.Property(e => e.DecimaisValor)
                .HasDefaultValueSql("0")
                .HasColumnName("decimais_valor");
            entity.Property(e => e.DesabilitarLogin)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desabilitar_login");
            entity.Property(e => e.DesabilitarLoginGs)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desabilitar_login_gs");
            entity.Property(e => e.DescricaoSangria)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao_sangria");
            entity.Property(e => e.DescricaoSuprimento)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao_suprimento");
            entity.Property(e => e.DoacaoCartao)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("doacao_cartao");
            entity.Property(e => e.HandBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hand_bal_comanda");
            entity.Property(e => e.HoraAt)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hora_at");
            entity.Property(e => e.IdEcfCaixa)
                .HasDefaultValueSql("0")
                .HasColumnName("id_ecf_caixa");
            entity.Property(e => e.IdEcfEmpresa)
                .HasDefaultValueSql("0")
                .HasColumnName("id_ecf_empresa");
            entity.Property(e => e.IdEcfImpressora)
                .HasDefaultValueSql("0")
                .HasColumnName("id_ecf_impressora");
            entity.Property(e => e.IdEcfResolucao)
                .HasDefaultValueSql("0")
                .HasColumnName("id_ecf_resolucao");
            entity.Property(e => e.IdImpressoraDocumentoDia)
                .HasDefaultValueSql("0")
                .HasColumnName("id_impressora_documento_dia");
            entity.Property(e => e.Increment)
                .HasDefaultValueSql("0")
                .HasColumnName("increment");
            entity.Property(e => e.IndiceGerencial)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("indice_gerencial");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.IntervaloEcf)
                .HasDefaultValueSql("0")
                .HasColumnName("intervalo_ecf");
            entity.Property(e => e.IpServidor)
                .HasMaxLength(15)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("ip_servidor");
            entity.Property(e => e.IpSitef)
                .HasMaxLength(15)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("ip_sitef");
            entity.Property(e => e.Laudo)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("laudo");
            entity.Property(e => e.MarketingAtivo)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("marketing_ativo");
            entity.Property(e => e.MascaraLoginGerente)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("mascara_login_gerente");
            entity.Property(e => e.MensagemCupom)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mensagem_cupom");
            entity.Property(e => e.ModoFacil)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("modo_facil");
            entity.Property(e => e.Notamanual)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::bpchar")
                .HasColumnName("notamanual");
            entity.Property(e => e.ParametrosDiversos)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("parametros_diversos");
            entity.Property(e => e.PartyBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("party_bal_comanda");
            entity.Property(e => e.PesquisaParte)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("pesquisa_parte");
            entity.Property(e => e.PortaBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("porta_bal_comanda");
            entity.Property(e => e.PortaEcf)
                .HasMaxLength(10)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("porta_ecf");
            entity.Property(e => e.PortaPosto)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("porta_posto");
            entity.Property(e => e.QtdeMaximaCartoes)
                .HasDefaultValueSql("0")
                .HasColumnName("qtde_maxima_cartoes");
            entity.Property(e => e.RamoEmpresa)
                .HasDefaultValueSql("1")
                .HasColumnName("ramo_empresa");
            entity.Property(e => e.Rzautomaticamente)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("rzautomaticamente");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasDefaultValueSql("0")
                .HasColumnName("sincronizado");
            entity.Property(e => e.Ss)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ss");
            entity.Property(e => e.StopBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("stop_bal_comanda");
            entity.Property(e => e.TaxaServico)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("taxa_servico");
            entity.Property(e => e.TaxaServicoValor)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("taxa_servico_valor");
            entity.Property(e => e.Teclageral)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("teclageral");
            entity.Property(e => e.TefEsperaSts)
                .HasDefaultValueSql("0")
                .HasColumnName("tef_espera_sts");
            entity.Property(e => e.TefNumeroVias)
                .HasDefaultValueSql("0")
                .HasColumnName("tef_numero_vias");
            entity.Property(e => e.TefTempoEspera)
                .HasDefaultValueSql("0")
                .HasColumnName("tef_tempo_espera");
            entity.Property(e => e.TefTipoGp)
                .HasDefaultValueSql("0")
                .HasColumnName("tef_tipo_gp");
            entity.Property(e => e.TimeBalComanda)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("time_bal_comanda");
            entity.Property(e => e.TimeoutEcf)
                .HasDefaultValueSql("0")
                .HasColumnName("timeout_ecf");
            entity.Property(e => e.TipoTef)
                .HasMaxLength(2)
                .HasDefaultValueSql("NULL::bpchar")
                .IsFixedLength()
                .HasColumnName("tipo_tef");
            entity.Property(e => e.TituloTelaCaixa)
                .HasMaxLength(100)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("titulo_tela_caixa");
            entity.Property(e => e.Touch)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("touch");
            entity.Property(e => e.UltimaExclusao)
                .HasDefaultValueSql("0")
                .HasColumnName("ultima_exclusao");
            entity.Property(e => e.VendaEstoqueZerado)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("venda_estoque_zerado");
        });

        modelBuilder.Entity<EcfFechamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_fechamento_pkey");

            entity.ToTable("ecf_fechamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEcfMovimento).HasColumnName("id_ecf_movimento");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.TipoPagamento)
                .HasMaxLength(20)
                .HasColumnName("tipo_pagamento");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 6)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcfFuncionario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_funcionario_pkey");

            entity.ToTable("ecf_funcionario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Celular)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("celular");
            entity.Property(e => e.ComissaoPrazo)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("comissao_prazo");
            entity.Property(e => e.ComissaoVista)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("comissao_vista");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.NivelAutorizacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nivel_autorizacao");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nome");
            entity.Property(e => e.Telefone)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<EcfImpressora>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_impressora_pkey");

            entity.ToTable("ecf_impressora");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_ecf_impressora_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("codigo");
            entity.Property(e => e.DataInstalacaoSb).HasColumnName("data_instalacao_sb");
            entity.Property(e => e.Docto)
                .HasMaxLength(60)
                .HasColumnName("docto");
            entity.Property(e => e.EcfImpressora1)
                .HasMaxLength(3)
                .HasColumnName("ecf_impressora");
            entity.Property(e => e.HoraInstalacaoSb)
                .HasMaxLength(8)
                .HasColumnName("hora_instalacao_sb");
            entity.Property(e => e.Identificacao)
                .HasMaxLength(250)
                .HasColumnName("identificacao");
            entity.Property(e => e.LacreNaMfd)
                .HasMaxLength(1)
                .HasColumnName("lacre_na_mfd");
            entity.Property(e => e.Le)
                .HasMaxLength(1)
                .HasColumnName("le");
            entity.Property(e => e.Lef)
                .HasMaxLength(1)
                .HasColumnName("lef");
            entity.Property(e => e.Marca)
                .HasMaxLength(30)
                .HasColumnName("marca");
            entity.Property(e => e.Mc)
                .HasMaxLength(2)
                .HasColumnName("mc");
            entity.Property(e => e.Md)
                .HasMaxLength(2)
                .HasColumnName("md");
            entity.Property(e => e.Mfd)
                .HasMaxLength(1)
                .HasColumnName("mfd");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("modelo");
            entity.Property(e => e.ModeloAcbr)
                .HasMaxLength(30)
                .HasColumnName("modelo_acbr");
            entity.Property(e => e.ModeloDocumentoFiscal)
                .HasMaxLength(2)
                .HasColumnName("modelo_documento_fiscal");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Serie)
                .HasMaxLength(20)
                .HasColumnName("serie");
            entity.Property(e => e.Tipo)
                .HasMaxLength(7)
                .HasColumnName("tipo");
            entity.Property(e => e.Versao)
                .HasMaxLength(30)
                .HasColumnName("versao");
            entity.Property(e => e.Vr)
                .HasMaxLength(2)
                .HasColumnName("vr");
        });

        modelBuilder.Entity<EcfMovimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_movimento_pkey");

            entity.ToTable("ecf_movimento");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_ecf_movimento_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.DataAbertura).HasColumnName("data_abertura");
            entity.Property(e => e.DataFechamento).HasColumnName("data_fechamento");
            entity.Property(e => e.HoraAbertura)
                .HasMaxLength(8)
                .HasColumnName("hora_abertura");
            entity.Property(e => e.HoraFechamento)
                .HasMaxLength(8)
                .HasColumnName("hora_fechamento");
            entity.Property(e => e.IdEcfCaixa).HasColumnName("id_ecf_caixa");
            entity.Property(e => e.IdEcfEmpresa).HasColumnName("id_ecf_empresa");
            entity.Property(e => e.IdEcfImpressora).HasColumnName("id_ecf_impressora");
            entity.Property(e => e.IdEcfOperador).HasColumnName("id_ecf_operador");
            entity.Property(e => e.IdEcfTurno).HasColumnName("id_ecf_turno");
            entity.Property(e => e.IdFrente).HasColumnName("id_frente");
            entity.Property(e => e.IdGerenteSupervisor).HasColumnName("id_gerente_supervisor");
            entity.Property(e => e.StatusMovimento)
                .HasMaxLength(1)
                .HasColumnName("status_movimento");
            entity.Property(e => e.TotalAcrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("total_acrescimo");
            entity.Property(e => e.TotalCancelado)
                .HasPrecision(18, 6)
                .HasColumnName("total_cancelado");
            entity.Property(e => e.TotalDesconto)
                .HasPrecision(18, 6)
                .HasColumnName("total_desconto");
            entity.Property(e => e.TotalFinal)
                .HasPrecision(18, 6)
                .HasColumnName("total_final");
            entity.Property(e => e.TotalNaoFiscal)
                .HasPrecision(18, 6)
                .HasColumnName("total_nao_fiscal");
            entity.Property(e => e.TotalRecebido)
                .HasPrecision(18, 6)
                .HasColumnName("total_recebido");
            entity.Property(e => e.TotalSangria)
                .HasPrecision(18, 6)
                .HasColumnName("total_sangria");
            entity.Property(e => e.TotalSuprimento)
                .HasPrecision(18, 6)
                .HasColumnName("total_suprimento");
            entity.Property(e => e.TotalTroco)
                .HasPrecision(18, 6)
                .HasColumnName("total_troco");
            entity.Property(e => e.TotalVenda)
                .HasPrecision(18, 6)
                .HasColumnName("total_venda");
        });

        modelBuilder.Entity<EcfOperador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_operador_pkey");

            entity.ToTable("ecf_operador");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEcfFuncionario).HasColumnName("id_ecf_funcionario");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("login");
            entity.Property(e => e.Senha)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("senha");
        });

        modelBuilder.Entity<EcfPosicaoComponente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_posicao_componentes_pkey");

            entity.ToTable("ecf_posicao_componentes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altura)
                .HasDefaultValueSql("0")
                .HasColumnName("altura");
            entity.Property(e => e.Esquerda)
                .HasDefaultValueSql("0")
                .HasColumnName("esquerda");
            entity.Property(e => e.IdEcfResolucao).HasColumnName("id_ecf_resolucao");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Largura)
                .HasDefaultValueSql("0")
                .HasColumnName("largura");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nome");
            entity.Property(e => e.TamanhoFonte)
                .HasDefaultValueSql("0")
                .HasColumnName("tamanho_fonte");
            entity.Property(e => e.Texto)
                .HasMaxLength(250)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("texto");
            entity.Property(e => e.Topo)
                .HasDefaultValueSql("0")
                .HasColumnName("topo");
        });

        modelBuilder.Entity<EcfResolucao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_resolucao_pkey");

            entity.ToTable("ecf_resolucao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Altura)
                .HasDefaultValueSql("0")
                .HasColumnName("altura");
            entity.Property(e => e.Bobinacolor)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bobinacolor");
            entity.Property(e => e.BobinacolorFont)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bobinacolor_font");
            entity.Property(e => e.EditsColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("edits_color");
            entity.Property(e => e.EditsDisabledColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("edits_disabled_color");
            entity.Property(e => e.EditsFontColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("edits_font_color");
            entity.Property(e => e.EditsFontName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("edits_font_name");
            entity.Property(e => e.EditsFontStyle)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("edits_font_style");
            entity.Property(e => e.HottrackColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hottrack_color");
            entity.Property(e => e.ImagemMenu)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("imagem_menu");
            entity.Property(e => e.ImagemMenup)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("imagem_menup");
            entity.Property(e => e.ImagemSubmenu)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("imagem_submenu");
            entity.Property(e => e.ImagemTela)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("imagem_tela");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.ItemSelStyleColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("item_sel_style_color");
            entity.Property(e => e.ItemStyleFontColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("item_style_font_color");
            entity.Property(e => e.ItemStyleFontName)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("item_style_font_name");
            entity.Property(e => e.ItemStyleFontStyle)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("item_style_font_style");
            entity.Property(e => e.LabelTotalGeralFontColor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("label_total_geral_font_color");
            entity.Property(e => e.Largura)
                .HasDefaultValueSql("0")
                .HasColumnName("largura");
            entity.Property(e => e.ResolucaoTela)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("resolucao_tela");
        });

        modelBuilder.Entity<EcfSuprimento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_suprimento_pkey");

            entity.ToTable("ecf_suprimento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataSuprimento).HasColumnName("data_suprimento");
            entity.Property(e => e.IdEcfMovimento).HasColumnName("id_ecf_movimento");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasDefaultValueSql("0")
                .HasColumnName("sincronizado");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcfTipoPagamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_tipo_pagamento_pkey");

            entity.ToTable("ecf_tipo_pagamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codigo)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao");
            entity.Property(e => e.GeraParcelas)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("gera_parcelas");
            entity.Property(e => e.HashIncremento).HasColumnName("hash_incremento");
            entity.Property(e => e.ImprimeVinculado)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("imprime_vinculado");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.MfAdicional)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mf_adicional");
            entity.Property(e => e.ModeloEcf)
                .HasMaxLength(30)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("modelo_ecf");
            entity.Property(e => e.PermiteTroco)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("permite_troco");
            entity.Property(e => e.Tef)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tef");
            entity.Property(e => e.TefTipoGp)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tef_tipo_gp");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<EcfTotalTipoPgto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_total_tipo_pgto_pkey");

            entity.ToTable("ecf_total_tipo_pgto");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_ecf_total_tipo_pgto_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Baixou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("baixou");
            entity.Property(e => e.CartaoDc)
                .HasMaxLength(1)
                .HasColumnName("cartao_dc");
            entity.Property(e => e.Ccf).HasColumnName("ccf");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.Estorno)
                .HasMaxLength(1)
                .HasColumnName("estorno");
            entity.Property(e => e.Gnf).HasColumnName("gnf");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.IdEcfTipoPagamento).HasColumnName("id_ecf_tipo_pagamento");
            entity.Property(e => e.IdEcfVendaCabecalho).HasColumnName("id_ecf_venda_cabecalho");
            entity.Property(e => e.MfAdicional)
                .HasMaxLength(1)
                .HasColumnName("mf_adicional");
            entity.Property(e => e.ModeloEcf)
                .HasMaxLength(30)
                .HasColumnName("modelo_ecf");
            entity.Property(e => e.Nsu)
                .HasMaxLength(30)
                .HasColumnName("nsu");
            entity.Property(e => e.Rede)
                .HasMaxLength(10)
                .HasColumnName("rede");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.TpPagt)
                .HasMaxLength(4)
                .HasColumnName("tp_pagt");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 6)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcfTotalTipoPgtoSalve>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_total_tipo_pgto_salve_pkey");

            entity.ToTable("ecf_total_tipo_pgto_salve");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CartaoDc)
                .HasMaxLength(1)
                .HasColumnName("cartao_dc");
            entity.Property(e => e.Ccf).HasColumnName("ccf");
            entity.Property(e => e.Codpagamento)
                .HasMaxLength(10)
                .HasColumnName("codpagamento");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.Estorno)
                .HasMaxLength(1)
                .HasColumnName("estorno");
            entity.Property(e => e.Gnf).HasColumnName("gnf");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.IdEcfTipoPagamento).HasColumnName("id_ecf_tipo_pagamento");
            entity.Property(e => e.IdEcfVendaCabecalho).HasColumnName("id_ecf_venda_cabecalho");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Nsu)
                .HasMaxLength(30)
                .HasColumnName("nsu");
            entity.Property(e => e.Rede)
                .HasMaxLength(10)
                .HasColumnName("rede");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.T)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("t");
            entity.Property(e => e.Temtef)
                .HasMaxLength(3)
                .HasColumnName("temtef");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 6)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<EcfTurno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ecf_turno_pkey");

            entity.ToTable("ecf_turno");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao");
            entity.Property(e => e.HoraFim)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hora_fim");
            entity.Property(e => e.HoraInicio)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hora_inicio");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
        });

        modelBuilder.Entity<EcfVendaCabecalho>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SerieEcf }).HasName("pk_cliente");

            entity.ToTable("ecf_venda_cabecalho");

            entity.HasIndex(e => e.DataVenda, "ecf_venda_cabecalho_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("acrescimo");
            entity.Property(e => e.AcrescimoItens)
                .HasPrecision(18, 6)
                .HasColumnName("acrescimo_itens");
            entity.Property(e => e.Baixou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("baixou");
            entity.Property(e => e.BaseIcms)
                .HasPrecision(18, 6)
                .HasColumnName("base_icms");
            entity.Property(e => e.Ccf).HasColumnName("ccf");
            entity.Property(e => e.Cfop).HasColumnName("cfop");
            entity.Property(e => e.Cofins)
                .HasPrecision(18, 6)
                .HasColumnName("cofins");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.CpfCnpjCliente)
                .HasMaxLength(20)
                .HasColumnName("cpf_cnpj_cliente");
            entity.Property(e => e.CupomCancelado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cupom_cancelado");
            entity.Property(e => e.DataVenda).HasColumnName("data_venda");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 6)
                .HasColumnName("desconto");
            entity.Property(e => e.DescontoItens)
                .HasPrecision(18, 6)
                .HasColumnName("desconto_itens");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.HoraVenda)
                .HasMaxLength(8)
                .HasColumnName("hora_venda");
            entity.Property(e => e.Icms)
                .HasPrecision(18, 6)
                .HasColumnName("icms");
            entity.Property(e => e.IcmsIsento)
                .HasPrecision(18, 6)
                .HasColumnName("icms_isento");
            entity.Property(e => e.IcmsNaoTributado)
                .HasPrecision(18, 6)
                .HasColumnName("icms_nao_tributado");
            entity.Property(e => e.IcmsOutras)
                .HasPrecision(18, 6)
                .HasColumnName("icms_outras");
            entity.Property(e => e.IcmsSubstituicao)
                .HasPrecision(18, 6)
                .HasColumnName("icms_substituicao");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEcfDav).HasColumnName("id_ecf_dav");
            entity.Property(e => e.IdEcfFuncionario).HasColumnName("id_ecf_funcionario");
            entity.Property(e => e.IdEcfMovimento).HasColumnName("id_ecf_movimento");
            entity.Property(e => e.IdEcfPreVendaCabecalho).HasColumnName("id_ecf_pre_venda_cabecalho");
            entity.Property(e => e.Issqn)
                .HasPrecision(18, 6)
                .HasColumnName("issqn");
            entity.Property(e => e.Mfd)
                .HasMaxLength(1)
                .HasColumnName("mfd");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("modelo");
            entity.Property(e => e.NomeCliente)
                .HasMaxLength(100)
                .HasColumnName("nome_cliente");
            entity.Property(e => e.NotaManual)
                .HasMaxLength(30)
                .HasColumnName("nota_manual");
            entity.Property(e => e.Pis)
                .HasPrecision(18, 6)
                .HasColumnName("pis");
            entity.Property(e => e.StatusVenda)
                .HasMaxLength(1)
                .HasColumnName("status_venda");
            entity.Property(e => e.TaxaAcrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_acrescimo");
            entity.Property(e => e.TaxaDesconto)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_desconto");
            entity.Property(e => e.TotalDocumento)
                .HasPrecision(18, 6)
                .HasColumnName("total_documento");
            entity.Property(e => e.TotalProdutos)
                .HasPrecision(18, 6)
                .HasColumnName("total_produtos");
            entity.Property(e => e.TpAcres)
                .HasMaxLength(1)
                .HasColumnName("tp_acres");
            entity.Property(e => e.TpDescto)
                .HasMaxLength(1)
                .HasColumnName("tp_descto");
            entity.Property(e => e.Troco)
                .HasPrecision(18, 6)
                .HasColumnName("troco");
            entity.Property(e => e.ValorCancelado)
                .HasPrecision(18, 6)
                .HasColumnName("valor_cancelado");
            entity.Property(e => e.ValorFinal)
                .HasPrecision(18, 6)
                .HasColumnName("valor_final");
            entity.Property(e => e.ValorRecebido)
                .HasPrecision(18, 6)
                .HasColumnName("valor_recebido");
            entity.Property(e => e.ValorVenda)
                .HasPrecision(18, 6)
                .HasColumnName("valor_venda");
        });

        modelBuilder.Entity<EcfVendaDetalhe>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SerieEcf }).HasName("pk_ecf_venda_detalhe");

            entity.ToTable("ecf_venda_detalhe");

            entity.HasIndex(e => e.IdEcfVendaCabecalho, "ecf_venda_detalhe_idx");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Acrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("acrescimo");
            entity.Property(e => e.AcrescimoRateio)
                .HasPrecision(18, 6)
                .HasColumnName("acrescimo_rateio");
            entity.Property(e => e.Baixou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("baixou");
            entity.Property(e => e.BaseIcms)
                .HasPrecision(18, 6)
                .HasColumnName("base_icms");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(1)
                .HasColumnName("cancelado");
            entity.Property(e => e.Cancelaitem)
                .HasMaxLength(1)
                .HasColumnName("cancelaitem");
            entity.Property(e => e.Ccf).HasColumnName("ccf");
            entity.Property(e => e.CdPlano)
                .HasDefaultValueSql("1")
                .HasColumnName("cd_plano");
            entity.Property(e => e.Cfop).HasColumnName("cfop");
            entity.Property(e => e.Cofins)
                .HasPrecision(18, 6)
                .HasColumnName("cofins");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.Cooo).HasColumnName("cooo");
            entity.Property(e => e.Cst)
                .HasMaxLength(3)
                .HasColumnName("cst");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 6)
                .HasColumnName("desconto");
            entity.Property(e => e.DescontoRateio)
                .HasPrecision(18, 6)
                .HasColumnName("desconto_rateio");
            entity.Property(e => e.EcfIcmsSt)
                .HasMaxLength(4)
                .HasColumnName("ecf_icms_st");
            entity.Property(e => e.Gtin)
                .HasMaxLength(14)
                .HasColumnName("gtin");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.Icms)
                .HasPrecision(18, 6)
                .HasColumnName("icms");
            entity.Property(e => e.IcmsIsento)
                .HasPrecision(18, 6)
                .HasColumnName("icms_isento");
            entity.Property(e => e.IcmsNaoTributado)
                .HasPrecision(18, 6)
                .HasColumnName("icms_nao_tributado");
            entity.Property(e => e.IcmsSubstituicao)
                .HasPrecision(18, 6)
                .HasColumnName("icms_substituicao");
            entity.Property(e => e.IdEcfProduto).HasColumnName("id_ecf_produto");
            entity.Property(e => e.IdEcfVendaCabecalho).HasColumnName("id_ecf_venda_cabecalho");
            entity.Property(e => e.Issqn)
                .HasPrecision(18, 6)
                .HasColumnName("issqn");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Mfd)
                .HasMaxLength(1)
                .HasColumnName("mfd");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("modelo");
            entity.Property(e => e.MovimentaEstoque)
                .HasMaxLength(1)
                .HasColumnName("movimenta_estoque");
            entity.Property(e => e.Pis)
                .HasPrecision(18, 6)
                .HasColumnName("pis");
            entity.Property(e => e.PorcIbpt)
                .HasPrecision(18, 2)
                .HasColumnName("porc_ibpt");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 6)
                .HasColumnName("quantidade");
            entity.Property(e => e.TaxaAcrescimo)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_acrescimo");
            entity.Property(e => e.TaxaCofins)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_cofins");
            entity.Property(e => e.TaxaDesconto)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_desconto");
            entity.Property(e => e.TaxaIcms)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_icms");
            entity.Property(e => e.TaxaIssqn)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_issqn");
            entity.Property(e => e.TaxaPis)
                .HasPrecision(18, 6)
                .HasColumnName("taxa_pis");
            entity.Property(e => e.TotalItem)
                .HasPrecision(18, 6)
                .HasColumnName("total_item");
            entity.Property(e => e.TotalizadorParcial)
                .HasMaxLength(10)
                .HasColumnName("totalizador_parcial");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 6)
                .HasColumnName("valor_total");
            entity.Property(e => e.ValorUnitario)
                .HasPrecision(18, 6)
                .HasColumnName("valor_unitario");
            entity.Property(e => e.VlAproxImposto)
                .HasPrecision(18, 4)
                .HasColumnName("vl_aprox_imposto");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.CdEmpresa).HasName("empresa_pkey");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.CdCidade, "empresa_idx");

            entity.Property(e => e.CdEmpresa)
                .HasDefaultValueSql("nextval('gen_empresa_id'::regclass)")
                .HasColumnName("cd_empresa");
            entity.Property(e => e.AliquotaCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquota_cofins");
            entity.Property(e => e.AliquotaPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquota_pis");
            entity.Property(e => e.AutorizoXml)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("autorizo_xml");
            entity.Property(e => e.BlocoGeracaoSpeedFiscal)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bloco_geracao_speed_fiscal");
            entity.Property(e => e.CdCep)
                .HasMaxLength(9)
                .HasColumnName("cd_cep");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.CdCnpj)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_cnpj");
            entity.Property(e => e.ChavePix)
                .HasMaxLength(500)
                .HasColumnName("chave_pix");
            entity.Property(e => e.Cnae)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cnae");
            entity.Property(e => e.CodIncTrib)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("cod_inc_trib");
            entity.Property(e => e.CodRecCofins)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cod_rec_cofins");
            entity.Property(e => e.CodRecPis)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cod_rec_pis");
            entity.Property(e => e.CodTipoCont)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("cod_tipo_cont");
            entity.Property(e => e.Complemento)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("complemento");
            entity.Property(e => e.ContaAnaSpedInv)
                .HasMaxLength(32)
                .HasColumnName("conta_ana_sped_inv");
            entity.Property(e => e.Contato)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("contato");
            entity.Property(e => e.CpfcnpfAutorizado)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cpfcnpf_autorizado");
            entity.Property(e => e.Csc)
                .HasMaxLength(36)
                .HasColumnName("csc");
            entity.Property(e => e.DataRegistro)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data_registro");
            entity.Property(e => e.EMail)
                .HasMaxLength(100)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("e_mail");
            entity.Property(e => e.IdVendaMobile)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_venda_mobile");
            entity.Property(e => e.Idcsc)
                .HasMaxLength(6)
                .HasColumnName("idcsc");
            entity.Property(e => e.ImgDanfeCab).HasColumnName("img_danfe_cab");
            entity.Property(e => e.IndAproCred)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("ind_apro_cred");
            entity.Property(e => e.IndRegCum)
                .HasMaxLength(1)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("ind_reg_cum");
            entity.Property(e => e.InfSaidaSpeedFiscal)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("inf_saida_speed_fiscal");
            entity.Property(e => e.InscrSubTrib)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("inscr_sub_trib");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.LoginFarmaciaPopular)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("login_farmacia_popular");
            entity.Property(e => e.Logo).HasColumnName("logo");
            entity.Property(e => e.NatRec)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nat_rec");
            entity.Property(e => e.NmBairro)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_bairro");
            entity.Property(e => e.NmCidade)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_cidade");
            entity.Property(e => e.NmEmpresa)
                .HasMaxLength(256)
                .HasColumnName("nm_empresa");
            entity.Property(e => e.NmEndereco)
                .HasMaxLength(62)
                .HasColumnName("nm_endereco");
            entity.Property(e => e.NomeFantasia)
                .HasMaxLength(128)
                .HasColumnName("nome_fantasia");
            entity.Property(e => e.NrInscrEstadual)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_inscr_estadual");
            entity.Property(e => e.NrInscrMunicipal)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_inscr_municipal");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.OrgaoRegistro)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("orgao_registro");
            entity.Property(e => e.PathLogo)
                .HasMaxLength(255)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("path_logo");
            entity.Property(e => e.PerfilPaf)
                .HasMaxLength(5)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("perfil_paf");
            entity.Property(e => e.PorcContsocial)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_contsocial");
            entity.Property(e => e.PorcIrpj)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_irpj");
            entity.Property(e => e.PorcIrrf)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_irrf");
            entity.Property(e => e.PorcIss)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_iss");
            entity.Property(e => e.PorcLucroPresumido)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_lucro_presumido");
            entity.Property(e => e.Registro)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("registro");
            entity.Property(e => e.SenhaFarmaciaPopular)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("senha_farmacia_popular");
            entity.Property(e => e.SenhaSngpc)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("senha_sngpc");
            entity.Property(e => e.Suframa)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("suframa");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone");
            entity.Property(e => e.Telefone2)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone2");
            entity.Property(e => e.TipoRegime).HasColumnName("tipo_regime");
            entity.Property(e => e.TpAtividadeFiscal)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_atividade_fiscal");
            entity.Property(e => e.TpNotaFiscal).HasColumnName("tp_nota_fiscal");
            entity.Property(e => e.TpPerfilSpeedFiscal)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_perfil_speed_fiscal");
            entity.Property(e => e.TpQuali)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_quali");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("uf");
            entity.Property(e => e.UsaGaveta)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("usa_gaveta");

            entity.HasOne(d => d.CdCidadeNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.CdCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("empresa_fk");
        });

        modelBuilder.Entity<Emprestimo>(entity =>
        {
            entity.HasKey(e => e.NrEmprestimo).HasName("emprestimo_pkey");

            entity.ToTable("emprestimo");

            entity.Property(e => e.NrEmprestimo)
                .HasDefaultValueSql("nextval('gen_emprestimo_id'::regclass)")
                .HasColumnName("nr_emprestimo");
            entity.Property(e => e.DataDevol).HasColumnName("data_devol");
            entity.Property(e => e.DataEmp).HasColumnName("data_emp");
            entity.Property(e => e.Requerente).HasColumnName("requerente");
            entity.Property(e => e.TipoRequerente).HasColumnName("tipo_requerente");
        });

        modelBuilder.Entity<EmprestimoPeca>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("emprestimo_pecas_pkey");

            entity.ToTable("emprestimo_pecas");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_ep_pecas_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdFunc).HasColumnName("cd_func");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DtDevol).HasColumnName("dt_devol");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.EmprestimoPecas)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emprestimo_pecas_fk1");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.EmprestimoPecas)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("emprestimo_pecas_fk");

            entity.HasOne(d => d.CdFuncNavigation).WithMany(p => p.EmprestimoPecas)
                .HasForeignKey(d => d.CdFunc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emprestimo_pecas_fk3");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.EmprestimoPecas)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("emprestimo_pecas_fk2");
        });

        modelBuilder.Entity<Entrada>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("entradas_pkey");

            entity.ToTable("entradas");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_entrada_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdCfop)
                .HasMaxLength(4)
                .HasColumnName("cd_cfop");
            entity.Property(e => e.CdChaveNfe)
                .HasMaxLength(62)
                .HasColumnName("cd_chave_nfe");
            entity.Property(e => e.CdClienteDevolucao)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_cliente_devolucao");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdForn).HasColumnName("cd_forn");
            entity.Property(e => e.CdGrupoEstoque).HasColumnName("cd_grupo_estoque");
            entity.Property(e => e.CdSituacao)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("cd_situacao");
            entity.Property(e => e.CdTipoNf)
                .HasMaxLength(4)
                .HasColumnName("cd_tipo_nf");
            entity.Property(e => e.CodModDocArrec)
                .HasMaxLength(50)
                .HasColumnName("cod_mod_doc_arrec");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DtEmissao).HasColumnName("dt_emissao");
            entity.Property(e => e.DtSaida).HasColumnName("dt_saida");
            entity.Property(e => e.EmitendeNf)
                .HasMaxLength(1)
                .HasColumnName("emitende_nf");
            entity.Property(e => e.HrChegada).HasColumnName("hr_chegada");
            entity.Property(e => e.HrSaida).HasColumnName("hr_saida");
            entity.Property(e => e.ModeloNf)
                .HasMaxLength(6)
                .HasColumnName("modelo_nf");
            entity.Property(e => e.NrNf)
                .HasMaxLength(25)
                .HasColumnName("nr_nf");
            entity.Property(e => e.NrPedidoCompra).HasColumnName("nr_pedido_compra");
            entity.Property(e => e.NumDocArrec)
                .HasMaxLength(20)
                .HasColumnName("num_doc_arrec");
            entity.Property(e => e.PorcDifAlig)
                .HasPrecision(18, 4)
                .HasColumnName("porc_dif_alig");
            entity.Property(e => e.RespRetIcmsSt)
                .HasMaxLength(30)
                .HasColumnName("resp_ret_icms_st");
            entity.Property(e => e.SerieNf)
                .HasMaxLength(4)
                .HasColumnName("serie_nf");
            entity.Property(e => e.TpEntrada)
                .HasMaxLength(2)
                .HasColumnName("tp_entrada");
            entity.Property(e => e.TpFrete).HasColumnName("tp_frete");
            entity.Property(e => e.TpPagt)
                .HasMaxLength(1)
                .HasColumnName("tp_pagt");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasColumnName("transferiu");
            entity.Property(e => e.Transp).HasColumnName("transp");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlAcrescimoNf)
                .HasPrecision(18, 4)
                .HasColumnName("vl_acrescimo_nf");
            entity.Property(e => e.VlDescontoNf)
                .HasPrecision(18, 4)
                .HasColumnName("vl_desconto_nf");
            entity.Property(e => e.VlFrete)
                .HasPrecision(18, 4)
                .HasColumnName("vl_frete");
            entity.Property(e => e.VlGuiaSt)
                .HasPrecision(18, 4)
                .HasColumnName("vl_guia_st");
            entity.Property(e => e.VlOutras)
                .HasPrecision(18, 4)
                .HasColumnName("vl_outras");
            entity.Property(e => e.VlSeguro)
                .HasPrecision(18, 4)
                .HasColumnName("vl_seguro");
            entity.Property(e => e.VlStNf)
                .HasPrecision(18, 4)
                .HasColumnName("vl_st_nf");
            entity.Property(e => e.XmlNf).HasColumnName("xml_nf");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("entradas_fk1");

            entity.HasOne(d => d.CdFornNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.CdForn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("entradas_fk");

            entity.HasOne(d => d.CdGrupoEstoqueNavigation).WithMany(p => p.Entrada)
                .HasForeignKey(d => d.CdGrupoEstoque)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("entradas_fk2");
        });

        modelBuilder.Entity<EntradaOutrasDesp>(entity =>
        {
            entity.HasKey(e => e.NrEntrada).HasName("entrada_outras_desp_pkey");

            entity.ToTable("entrada_outras_desp");

            entity.Property(e => e.NrEntrada)
                .HasDefaultValueSql("nextval('gen_ent_out_desp_id'::regclass)")
                .HasColumnName("nr_entrada");
            entity.Property(e => e.BaseIcms)
                .HasPrecision(18, 4)
                .HasColumnName("base_icms");
            entity.Property(e => e.CdCidadeDestino)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade_destino");
            entity.Property(e => e.CdCidadeOrigem)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade_origem");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");
            entity.Property(e => e.CdTipoNf)
                .HasMaxLength(4)
                .HasColumnName("cd_tipo_nf");
            entity.Property(e => e.Cfop)
                .HasMaxLength(4)
                .HasColumnName("cfop");
            entity.Property(e => e.ChaveCte)
                .HasMaxLength(44)
                .HasColumnName("chave_cte");
            entity.Property(e => e.DtEntrada).HasColumnName("dt_entrada");
            entity.Property(e => e.ModeloNf)
                .HasMaxLength(2)
                .HasColumnName("modelo_nf");
            entity.Property(e => e.NrNotaFiscal)
                .HasMaxLength(25)
                .HasColumnName("nr_nota_fiscal");
            entity.Property(e => e.NrNotaFiscalEntrada)
                .HasMaxLength(25)
                .HasColumnName("nr_nota_fiscal_entrada");
            entity.Property(e => e.PorcIcms)
                .HasPrecision(18, 2)
                .HasColumnName("porc_icms");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .HasColumnName("serie");
            entity.Property(e => e.Subserie)
                .HasMaxLength(2)
                .HasColumnName("subserie");
            entity.Property(e => e.TpFrete).HasColumnName("tp_frete");
            entity.Property(e => e.ValorIcms)
                .HasPrecision(18, 4)
                .HasColumnName("valor_icms");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 4)
                .HasColumnName("valor_total");
            entity.Property(e => e.VlIsentaNTrib)
                .HasPrecision(18, 4)
                .HasColumnName("vl_isenta_n_trib");
            entity.Property(e => e.VlOutras)
                .HasPrecision(18, 4)
                .HasColumnName("vl_outras");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.EntradaOutrasDesps)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("entrada_outras_desp_fk1");

            entity.HasOne(d => d.CdFornecedorNavigation).WithMany(p => p.EntradaOutrasDesps)
                .HasForeignKey(d => d.CdFornecedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("entrada_outras_desp_fk");
        });

        modelBuilder.Entity<Estado>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("estados_pkey");

            entity.ToTable("estados");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Abrev)
                .HasMaxLength(2)
                .HasColumnName("abrev");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<FechamentoTerra>(entity =>
        {
            entity.HasKey(e => e.NrFechamento).HasName("fechamento_terra_pkey");

            entity.ToTable("fechamento_terra");

            entity.Property(e => e.NrFechamento)
                .HasDefaultValueSql("nextval('gen_fec_terra_id'::regclass)")
                .HasColumnName("nr_fechamento");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.DtFechamento).HasColumnName("dt_fechamento");
            entity.Property(e => e.NrRecibo).HasColumnName("nr_recibo");
            entity.Property(e => e.QtDeslocamentoMaq)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_deslocamento_maq");
            entity.Property(e => e.QtDeslocamentoVeic)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_deslocamento_veic");
            entity.Property(e => e.QtDiariaMaq)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_diaria_maq");
            entity.Property(e => e.QtDiariaVeic)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_diaria_veic");
            entity.Property(e => e.QtViageMaq)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_viage_maq");
            entity.Property(e => e.QtViageVeic)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_viage_veic");
            entity.Property(e => e.TotalHorimetro)
                .HasPrecision(18, 2)
                .HasColumnName("total_horimetro");
            entity.Property(e => e.TotalHrMaq)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("total_hr_maq");
            entity.Property(e => e.TotalHrs)
                .HasMaxLength(10)
                .HasDefaultValueSql("'0'::character varying")
                .HasColumnName("total_hrs");
            entity.Property(e => e.TotalKm)
                .HasPrecision(18, 4)
                .HasColumnName("total_km");
            entity.Property(e => e.TotalKmMaq)
                .HasPrecision(18, 4)
                .HasColumnName("total_km_maq");
            entity.Property(e => e.ValorDescMaq)
                .HasPrecision(18, 4)
                .HasColumnName("valor_desc_maq");
            entity.Property(e => e.ValorDescVeic)
                .HasPrecision(18, 4)
                .HasColumnName("valor_desc_veic");
            entity.Property(e => e.ValorDiariaMaq)
                .HasPrecision(18, 4)
                .HasColumnName("valor_diaria_maq");
            entity.Property(e => e.ValorDiariaVeic)
                .HasPrecision(18, 4)
                .HasColumnName("valor_diaria_veic");
            entity.Property(e => e.ValorViageMaq)
                .HasPrecision(18, 4)
                .HasColumnName("valor_viage_maq");
            entity.Property(e => e.ValorViageVeic)
                .HasPrecision(18, 4)
                .HasColumnName("valor_viage_veic");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlFreteMaq)
                .HasPrecision(18, 4)
                .HasColumnName("vl_frete_maq");
            entity.Property(e => e.VlFreteVeic)
                .HasPrecision(18, 4)
                .HasColumnName("vl_frete_veic");
            entity.Property(e => e.VlPedagioMaq)
                .HasPrecision(18, 4)
                .HasColumnName("vl_pedagio_maq");
            entity.Property(e => e.VlPedagioVei)
                .HasPrecision(18, 4)
                .HasColumnName("vl_pedagio_vei");
            entity.Property(e => e.VlTotalHor)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total_hor");
            entity.Property(e => e.VlTotalHrMaq)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total_hr_maq");
            entity.Property(e => e.VlTotalHrs)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total_hrs");
            entity.Property(e => e.VlTotalKm)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total_km");
            entity.Property(e => e.VlTotalKmMaq)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total_km_maq");
            entity.Property(e => e.VlUnitHor)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit_hor");
            entity.Property(e => e.VlUnitHrMaq)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit_hr_maq");
            entity.Property(e => e.VlUnitHrs)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit_hrs");
            entity.Property(e => e.VlUnitKm)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit_km");
            entity.Property(e => e.VlUnitKmMaq)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit_km_maq");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.FechamentoTerras)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fechamento_terra_fk");
        });

        modelBuilder.Entity<FichaTecnica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ficha_tecnica_pkey");

            entity.ToTable("ficha_tecnica");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(50)
                .HasColumnName("descricao");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdProdutoFilho).HasColumnName("id_produto_filho");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 6)
                .HasColumnName("quantidade");
        });

        modelBuilder.Entity<FmAnimal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("animal_pkey");

            entity.ToTable("fm_animal");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('animal_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Cor)
                .HasMaxLength(50)
                .HasColumnName("cor");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEspecie).HasColumnName("id_especie");
            entity.Property(e => e.IdRaca).HasColumnName("id_raca");
            entity.Property(e => e.Idade)
                .HasMaxLength(30)
                .HasColumnName("idade");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasColumnName("obs");
            entity.Property(e => e.Peso)
                .HasMaxLength(30)
                .HasColumnName("peso");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasColumnName("sexo");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.FmAnimals)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("animal_fk");

            entity.HasOne(d => d.IdEspecieNavigation).WithMany(p => p.FmAnimals)
                .HasForeignKey(d => d.IdEspecie)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("animal_fk2");

            entity.HasOne(d => d.IdRacaNavigation).WithMany(p => p.FmAnimals)
                .HasForeignKey(d => d.IdRaca)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("animal_fk1");
        });

        modelBuilder.Entity<FmComplexo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_complexos_pkey");

            entity.ToTable("fm_complexos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(64)
                .HasColumnName("descricao");
            entity.Property(e => e.IdEmbalagem).HasColumnName("id_embalagem");
            entity.Property(e => e.IdForma).HasColumnName("id_forma");
            entity.Property(e => e.IdTamanho).HasColumnName("id_tamanho");
            entity.Property(e => e.Posologia)
                .HasMaxLength(128)
                .HasColumnName("posologia");
            entity.Property(e => e.Quantidade)
                .HasPrecision(10, 2)
                .HasColumnName("quantidade");
        });

        modelBuilder.Entity<FmComponente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_componente_pkey");

            entity.ToTable("fm_componente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Densidade)
                .HasPrecision(8, 4)
                .HasColumnName("densidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.Diluicao)
                .HasPrecision(8, 4)
                .HasColumnName("diluicao");
            entity.Property(e => e.DosagemMaxima)
                .HasPrecision(8, 4)
                .HasColumnName("dosagem_maxima");
            entity.Property(e => e.DosagemMinima)
                .HasPrecision(8, 4)
                .HasColumnName("dosagem_minima");
            entity.Property(e => e.Excluido)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("excluido");
            entity.Property(e => e.FatorCorrecao)
                .HasPrecision(8, 4)
                .HasColumnName("fator_correcao");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.PesoMolarBase)
                .HasPrecision(8, 4)
                .HasColumnName("peso_molar_base");
            entity.Property(e => e.PesoMolarSal)
                .HasPrecision(8, 4)
                .HasColumnName("peso_molar_sal");
            entity.Property(e => e.UiMg)
                .HasPrecision(8, 4)
                .HasColumnName("ui_mg");
            entity.Property(e => e.UnidadePeso)
                .HasMaxLength(2)
                .HasColumnName("unidade_peso");
            entity.Property(e => e.UnidadeVolume)
                .HasMaxLength(2)
                .HasColumnName("unidade_volume");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.FmComponentes)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_componente_fk");
        });

        modelBuilder.Entity<FmEmbalagem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_embalagem_pkey");

            entity.ToTable("fm_embalagem");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.IdEmbAuxiliar).HasColumnName("id_emb_auxiliar");
            entity.Property(e => e.IdEmbAuxiliar2).HasColumnName("id_emb_auxiliar2");
            entity.Property(e => e.IdEmbAuxiliar3).HasColumnName("id_emb_auxiliar3");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.FmEmbalagems)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_embalagem_fk");
        });

        modelBuilder.Entity<FmEmbalagemRelacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_embalagem_relacao_pkey");

            entity.ToTable("fm_embalagem_relacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEmbalagem).HasColumnName("id_embalagem");
            entity.Property(e => e.IdFormaFarmaceutica).HasColumnName("id_forma_farmaceutica");
            entity.Property(e => e.IdTamanho).HasColumnName("id_tamanho");
            entity.Property(e => e.QtdMaxima)
                .HasPrecision(18, 4)
                .HasColumnName("qtd_maxima");
            entity.Property(e => e.QtdMinima)
                .HasPrecision(18, 4)
                .HasColumnName("qtd_minima");

            entity.HasOne(d => d.IdEmbalagemNavigation).WithMany(p => p.FmEmbalagemRelacaos)
                .HasForeignKey(d => d.IdEmbalagem)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_embalagem_relacao_fk");

            entity.HasOne(d => d.IdFormaFarmaceuticaNavigation).WithMany(p => p.FmEmbalagemRelacaos)
                .HasForeignKey(d => d.IdFormaFarmaceutica)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_embalagem_relacao_fk1");

            entity.HasOne(d => d.IdTamanhoNavigation).WithMany(p => p.FmEmbalagemRelacaos)
                .HasForeignKey(d => d.IdTamanho)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_embalagem_relacao_fk2");
        });

        modelBuilder.Entity<FmEspecie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("especie_pkey");

            entity.ToTable("fm_especie");

            entity.HasIndex(e => e.Descricao, "especie_descricao_key").IsUnique();

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval(('public.especie_id_seq'::text)::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<FmFormaFarmaceutica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("forma_farmaceutica_pkey");

            entity.ToTable("fm_forma_farmaceutica");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('forma_farmaceutica_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(16384)
                .HasColumnName("descricao");
            entity.Property(e => e.DiasValidade).HasColumnName("dias_validade");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Peso)
                .HasPrecision(7, 3)
                .HasColumnName("peso");
            entity.Property(e => e.QtdeOm)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("qtde_om");
            entity.Property(e => e.Uso)
                .HasMaxLength(20)
                .HasColumnName("uso");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.FmFormaFarmaceuticas)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_forma_farmaceutica_fk");
        });

        modelBuilder.Entity<FmFormaTamDosComponenteFk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_forma_tam_dos_componente_fk_pkey");

            entity.ToTable("fm_forma_tam_dos_componente_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentracao)
                .HasMaxLength(20)
                .HasColumnName("concentracao");
            entity.Property(e => e.IdComponente).HasColumnName("id_componente");
            entity.Property(e => e.IdFormaTamanho).HasColumnName("id_forma_tamanho");
            entity.Property(e => e.PesoMaximo)
                .HasPrecision(8, 4)
                .HasColumnName("peso_maximo");
            entity.Property(e => e.PesoMinimo)
                .HasPrecision(8, 4)
                .HasColumnName("peso_minimo");
            entity.Property(e => e.PesoTotal)
                .HasPrecision(8, 4)
                .HasColumnName("peso_total");
            entity.Property(e => e.UiMaximo)
                .HasPrecision(8, 4)
                .HasColumnName("ui_maximo");
            entity.Property(e => e.UiMinimo)
                .HasPrecision(8, 4)
                .HasColumnName("ui_minimo");
            entity.Property(e => e.VolumeMaximo)
                .HasPrecision(8, 4)
                .HasColumnName("volume_maximo");
            entity.Property(e => e.VolumeMinimo)
                .HasPrecision(8, 4)
                .HasColumnName("volume_minimo");

            entity.HasOne(d => d.IdComponenteNavigation).WithMany(p => p.FmFormaTamDosComponenteFks)
                .HasForeignKey(d => d.IdComponente)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_forma_tam_dos_componente_fk_fk");

            entity.HasOne(d => d.IdFormaTamanhoNavigation).WithMany(p => p.FmFormaTamDosComponenteFks)
                .HasForeignKey(d => d.IdFormaTamanho)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_forma_tam_dos_componente_fk_fk1");
        });

        modelBuilder.Entity<FmFormaTamanhoFk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_forma_tamanho_fk_pkey");

            entity.ToTable("fm_forma_tamanho_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DosagemMax)
                .HasPrecision(18, 2)
                .HasColumnName("dosagem_max");
            entity.Property(e => e.DosagemMin)
                .HasPrecision(18, 2)
                .HasColumnName("dosagem_min");
            entity.Property(e => e.IdMedicamentoForma).HasColumnName("id_medicamento_forma");
            entity.Property(e => e.IdTamanho).HasColumnName("id_tamanho");
            entity.Property(e => e.Peso)
                .HasPrecision(18, 3)
                .HasColumnName("peso");

            entity.HasOne(d => d.IdTamanhoNavigation).WithMany(p => p.FmFormaTamanhoFks)
                .HasForeignKey(d => d.IdTamanho)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_forma_tamanho_fk_fk1");
        });

        modelBuilder.Entity<FmHistEstoque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_hist_estoque_pkey");

            entity.ToTable("fm_hist_estoque");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataMov).HasColumnName("data_mov");
            entity.Property(e => e.EstoqueFinal)
                .HasPrecision(18, 4)
                .HasColumnName("estoque_final");
            entity.Property(e => e.EstoqueInicial)
                .HasPrecision(18, 4)
                .HasColumnName("estoque_inicial");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Observacao)
                .HasMaxLength(128)
                .HasColumnName("observacao");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<FmIncompatibilidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_incompatibilidade_pkey");

            entity.ToTable("fm_incompatibilidade");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Idmedicamento).HasColumnName("idmedicamento");
            entity.Property(e => e.Incompativel).HasColumnName("incompativel");
            entity.Property(e => e.Observacao)
                .HasMaxLength(16535)
                .HasColumnName("observacao");
        });

        modelBuilder.Entity<FmItemComplexo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_item_complexos_pkey");

            entity.ToTable("fm_item_complexos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentracao)
                .HasMaxLength(10)
                .HasColumnName("concentracao");
            entity.Property(e => e.Dosagem)
                .HasMaxLength(10)
                .HasColumnName("dosagem");
            entity.Property(e => e.IdComplexo).HasColumnName("id_complexo");
            entity.Property(e => e.IdMedicamento).HasColumnName("id_medicamento");
            entity.Property(e => e.Porcentagem)
                .HasMaxLength(10)
                .HasColumnName("porcentagem");
            entity.Property(e => e.Potencia)
                .HasMaxLength(10)
                .HasColumnName("potencia");
            entity.Property(e => e.UnConcentracao)
                .HasMaxLength(10)
                .HasColumnName("un_concentracao");
            entity.Property(e => e.UnDosagem)
                .HasMaxLength(10)
                .HasColumnName("un_dosagem");
        });

        modelBuilder.Entity<FmItemForma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_item_forma_pkey");

            entity.ToTable("fm_item_forma");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentracao)
                .HasMaxLength(20)
                .HasColumnName("concentracao");
            entity.Property(e => e.IdComponente).HasColumnName("id_componente");
            entity.Property(e => e.IdForma).HasColumnName("id_forma");
            entity.Property(e => e.PesoMaximo)
                .HasPrecision(8, 4)
                .HasColumnName("peso_maximo");
            entity.Property(e => e.PesoMinimo)
                .HasPrecision(8, 4)
                .HasColumnName("peso_minimo");
            entity.Property(e => e.PesoTotal)
                .HasPrecision(8, 4)
                .HasColumnName("peso_total");
            entity.Property(e => e.UiMaximo)
                .HasPrecision(8, 4)
                .HasColumnName("ui_maximo");
            entity.Property(e => e.UiMinimo)
                .HasPrecision(8, 4)
                .HasColumnName("ui_minimo");
            entity.Property(e => e.VolumeMaximo)
                .HasPrecision(8, 4)
                .HasColumnName("volume_maximo");
            entity.Property(e => e.VolumeMinimo)
                .HasPrecision(8, 4)
                .HasColumnName("volume_minimo");
        });

        modelBuilder.Entity<FmItemFormaTam>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_item_forma_tam_pkey");

            entity.ToTable("fm_item_forma_tam");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdForma).HasColumnName("id_forma");
            entity.Property(e => e.IdTamanho).HasColumnName("id_tamanho");
        });

        modelBuilder.Entity<FmItemOm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_item_om_pkey");

            entity.ToTable("fm_item_om");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentracao)
                .HasMaxLength(10)
                .HasColumnName("concentracao");
            entity.Property(e => e.Dosagem)
                .HasMaxLength(30)
                .HasColumnName("dosagem");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.IdEmbalagem).HasColumnName("id_embalagem");
            entity.Property(e => e.IdFormaFarm).HasColumnName("id_forma_farm");
            entity.Property(e => e.IdMedicamento).HasColumnName("id_medicamento");
            entity.Property(e => e.IdOm).HasColumnName("id_om");
            entity.Property(e => e.IdTamanho).HasColumnName("id_tamanho");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .HasColumnName("lote");
            entity.Property(e => e.Peso)
                .HasPrecision(18, 4)
                .HasColumnName("peso");
            entity.Property(e => e.Porcenteagem)
                .HasMaxLength(10)
                .HasColumnName("porcenteagem");
            entity.Property(e => e.Posologia)
                .HasMaxLength(128)
                .HasColumnName("posologia");
            entity.Property(e => e.Potencia)
                .HasMaxLength(10)
                .HasColumnName("potencia");
            entity.Property(e => e.QtdeLib)
                .HasMaxLength(30)
                .HasColumnName("qtde_lib");
            entity.Property(e => e.TamanhoLote)
                .HasMaxLength(50)
                .HasColumnName("tamanho_lote");
            entity.Property(e => e.TipoMed)
                .HasMaxLength(1)
                .HasColumnName("tipo_med");
            entity.Property(e => e.UnConcentracao)
                .HasMaxLength(6)
                .HasColumnName("UN_Concentracao");
            entity.Property(e => e.UnDosagem)
                .HasMaxLength(6)
                .HasColumnName("UN_Dosagem");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasColumnName("valor");
            entity.Property(e => e.Volume)
                .HasPrecision(18, 4)
                .HasColumnName("volume");
        });

        modelBuilder.Entity<FmMedContraindicaco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_med_contraindicacoes_pkey");

            entity.ToTable("fm_med_contraindicacoes");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdEspecie).HasColumnName("id_especie");
            entity.Property(e => e.IdMedicamento).HasColumnName("id_medicamento");
            entity.Property(e => e.IdRaca).HasColumnName("id_raca");

            entity.HasOne(d => d.IdEspecieNavigation).WithMany(p => p.FmMedContraindicacos)
                .HasForeignKey(d => d.IdEspecie)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_med_contraindicacoes_fk1");

            entity.HasOne(d => d.IdMedicamentoNavigation).WithMany(p => p.FmMedContraindicacos)
                .HasForeignKey(d => d.IdMedicamento)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_med_contraindicacoes_fk");
        });

        modelBuilder.Entity<FmMedOm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_med_om_pkey");

            entity.ToTable("fm_med_om");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Concentracao)
                .HasMaxLength(10)
                .HasColumnName("concentracao");
            entity.Property(e => e.Dosagem)
                .HasMaxLength(30)
                .HasColumnName("dosagem");
            entity.Property(e => e.IdMed).HasColumnName("id_med");
            entity.Property(e => e.IdOm).HasColumnName("id_om");
            entity.Property(e => e.Porcentagem)
                .HasMaxLength(10)
                .HasColumnName("porcentagem");
            entity.Property(e => e.Potencia)
                .HasMaxLength(10)
                .HasColumnName("potencia");
            entity.Property(e => e.UnConcentracao)
                .HasMaxLength(6)
                .HasColumnName("un_concentracao");
            entity.Property(e => e.UnDosagem)
                .HasMaxLength(6)
                .HasColumnName("un_dosagem");
        });

        modelBuilder.Entity<FmMedicamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_medicamento_pkey");

            entity.ToTable("fm_medicamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ControleEspecial)
                .HasMaxLength(1)
                .HasColumnName("controle_especial");
            entity.Property(e => e.Densidade)
                .HasPrecision(18, 4)
                .HasColumnName("densidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(165)
                .HasColumnName("descricao");
            entity.Property(e => e.Diluicao).HasColumnName("diluicao");
            entity.Property(e => e.DosagemMaxima)
                .HasPrecision(18, 4)
                .HasColumnName("dosagem_maxima");
            entity.Property(e => e.DosagemMinima)
                .HasPrecision(18, 4)
                .HasColumnName("dosagem_minima");
            entity.Property(e => e.FatorCorrecao)
                .HasPrecision(18, 4)
                .HasColumnName("fator_correcao");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasColumnName("obs");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.UiMg)
                .HasPrecision(18, 4)
                .HasColumnName("ui_mg");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.FmMedicamentos)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_medicamento_fk");
        });

        modelBuilder.Entity<FmMedicamentoFfarmaceuticaFk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_medicamento_ffarmaceutica_fk_pkey");

            entity.ToTable("fm_medicamento_ffarmaceutica_fk");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataValidade).HasColumnName("data_validade");
            entity.Property(e => e.DiasValidade).HasColumnName("dias_validade");
            entity.Property(e => e.IdFormaFarmaceutica).HasColumnName("id_forma_farmaceutica");
            entity.Property(e => e.IdMedicamento).HasColumnName("id_medicamento");
            entity.Property(e => e.Observacao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("observacao");
            entity.Property(e => e.Ph)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ph");

            entity.HasOne(d => d.IdFormaFarmaceuticaNavigation).WithMany(p => p.FmMedicamentoFfarmaceuticaFks)
                .HasForeignKey(d => d.IdFormaFarmaceutica)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_medicamento_ffarmaceutica_fk_fk1");

            entity.HasOne(d => d.IdMedicamentoNavigation).WithMany(p => p.FmMedicamentoFfarmaceuticaFks)
                .HasForeignKey(d => d.IdMedicamento)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_medicamento_ffarmaceutica_fk_fk");
        });

        modelBuilder.Entity<FmOmBaixa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_rm_baixas_pkey");

            entity.ToTable("fm_om_baixas");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('fm_rm_baixas_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Correcao)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("correcao");
            entity.Property(e => e.Diluido)
                .HasPrecision(18)
                .HasDefaultValueSql("0")
                .HasColumnName("diluido");
            entity.Property(e => e.Dosagem)
                .HasPrecision(16, 4)
                .HasColumnName("dosagem");
            entity.Property(e => e.DtValidade)
                .HasDefaultValueSql("'9999-01-01'::date")
                .HasColumnName("dt_validade");
            entity.Property(e => e.IdFormaTamanho).HasColumnName("id_forma_tamanho");
            entity.Property(e => e.IdItem).HasColumnName("id_item");
            entity.Property(e => e.IdOm).HasColumnName("id_om");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("lote");
            entity.Property(e => e.Quant)
                .HasPrecision(16, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("quant");
            entity.Property(e => e.QuantUnidade)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("quant_unidade");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
            entity.Property(e => e.Unidade)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("unidade");
            entity.Property(e => e.VlTotal)
                .HasPrecision(16, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(16, 4)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.IdOmNavigation).WithMany(p => p.FmOmBaixas)
                .HasForeignKey(d => d.IdOm)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_rm_baixas_fk");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.FmOmBaixas)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_rm_baixas_fk1");
        });

        modelBuilder.Entity<FmOrdemManipulacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_ordem_manipulacao_pkey");

            entity.ToTable("fm_ordem_manipulacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Documento)
                .HasMaxLength(32)
                .HasColumnName("documento");
            entity.Property(e => e.DtPedido).HasColumnName("dt_pedido");
            entity.Property(e => e.DtPreparacao).HasColumnName("dt_preparacao");
            entity.Property(e => e.DtRetirada).HasColumnName("dt_retirada");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.HrPedido).HasColumnName("hr_pedido");
            entity.Property(e => e.HrRetirada)
                .HasPrecision(0)
                .HasColumnName("hr_retirada");
            entity.Property(e => e.IdAnimal)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_animal");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdFarmaceuticoQualidade)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_farmaceutico_qualidade");
            entity.Property(e => e.IdVeterinario)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_veterinario");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(62)
                .HasColumnName("nm_usuario");
            entity.Property(e => e.NrOrdemReceita)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_ordem_receita");
            entity.Property(e => e.NrReceitaControlada)
                .HasMaxLength(50)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_receita_controlada");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("obs");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("status");
            entity.Property(e => e.TipoMed)
                .HasMaxLength(1)
                .HasColumnName("tipo_med");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");

            entity.HasOne(d => d.IdAnimalNavigation).WithMany(p => p.FmOrdemManipulacaos)
                .HasForeignKey(d => d.IdAnimal)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_ordem_manipulacao_fk6");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.FmOrdemManipulacaos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_ordem_manipulacao_fk5");

            entity.HasOne(d => d.IdVeterinarioNavigation).WithMany(p => p.FmOrdemManipulacaos)
                .HasForeignKey(d => d.IdVeterinario)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_ordem_manipulacao_fk1");

            entity.HasOne(d => d.NmUsuarioNavigation).WithMany(p => p.FmOrdemManipulacaos)
                .HasForeignKey(d => d.NmUsuario)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fm_ordem_manipulacao_fk4");
        });

        modelBuilder.Entity<FmPerda>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_perdas_pkey");

            entity.ToTable("fm_perdas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Idproduto).HasColumnName("idproduto");
            entity.Property(e => e.Lote)
                .HasMaxLength(20)
                .HasColumnName("lote");
            entity.Property(e => e.Motivo)
                .HasMaxLength(512)
                .HasColumnName("motivo");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
        });

        modelBuilder.Entity<FmPosologium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("posologia_pkey");

            entity.ToTable("fm_posologia");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('posologia_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(16384)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<FmRaca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("raca_pkey");

            entity.ToTable("fm_raca");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('raca_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.IdEspecie).HasColumnName("id_especie");

            entity.HasOne(d => d.IdEspecieNavigation).WithMany(p => p.FmRacas)
                .HasForeignKey(d => d.IdEspecie)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("raca_fk");
        });

        modelBuilder.Entity<FmTamanhoFormaFarmaceutica>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tamanho_forma_farmaceutica_pkey");

            entity.ToTable("fm_tamanho_forma_farmaceutica");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('tamanho_forma_farmaceutica_id_seq'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(15)
                .HasColumnName("descricao");
            entity.Property(e => e.DosagemMax).HasColumnName("dosagem_max");
            entity.Property(e => e.DosagemMin).HasColumnName("dosagem_min");
            entity.Property(e => e.Excluido)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("excluido");
            entity.Property(e => e.Peso)
                .HasPrecision(5, 2)
                .HasColumnName("peso");
        });

        modelBuilder.Entity<FmVeterinario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("fm_veterinario_pkey");

            entity.ToTable("fm_veterinario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Bairro)
                .HasMaxLength(32)
                .HasColumnName("bairro");
            entity.Property(e => e.Cep)
                .HasMaxLength(12)
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(64)
                .HasColumnName("cidade");
            entity.Property(e => e.Crmv)
                .HasMaxLength(10)
                .HasColumnName("crmv");
            entity.Property(e => e.Endereco)
                .HasMaxLength(64)
                .HasColumnName("endereco");
            entity.Property(e => e.NregSipeagro)
                .HasMaxLength(32)
                .HasColumnName("nreg_sipeagro");
            entity.Property(e => e.Numero)
                .HasMaxLength(6)
                .HasColumnName("numero");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .HasColumnName("telefone");
            entity.Property(e => e.Veterinario)
                .HasMaxLength(150)
                .HasColumnName("veterinario");
        });

        modelBuilder.Entity<FormaPagt>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("forma_pagt_pkey");

            entity.ToTable("forma_pagt");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_forma_pagt_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdHistoricoCaixa)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_historico_caixa");
            entity.Property(e => e.CdHistoricoCaixaD)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_historico_caixa_d");
            entity.Property(e => e.CdPlanoCaixa)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_plano_caixa");
            entity.Property(e => e.CdPlanoCaixaD)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_plano_caixa_d");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.NmForma)
                .HasMaxLength(150)
                .HasColumnName("nm_forma");
            entity.Property(e => e.Prz01).HasColumnName("prz01");
            entity.Property(e => e.Prz02)
                .HasDefaultValueSql("0")
                .HasColumnName("prz02");
            entity.Property(e => e.Prz03)
                .HasDefaultValueSql("0")
                .HasColumnName("prz03");
            entity.Property(e => e.Prz04)
                .HasDefaultValueSql("0")
                .HasColumnName("prz04");
            entity.Property(e => e.Prz05)
                .HasDefaultValueSql("0")
                .HasColumnName("prz05");
            entity.Property(e => e.Prz06)
                .HasDefaultValueSql("0")
                .HasColumnName("prz06");
            entity.Property(e => e.Prz07)
                .HasDefaultValueSql("0")
                .HasColumnName("prz07");
            entity.Property(e => e.Prz08)
                .HasDefaultValueSql("0")
                .HasColumnName("prz08");
            entity.Property(e => e.Prz09)
                .HasDefaultValueSql("0")
                .HasColumnName("prz09");
            entity.Property(e => e.Prz10)
                .HasDefaultValueSql("0")
                .HasColumnName("prz10");
            entity.Property(e => e.TipoPrazo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'D'::character varying")
                .HasColumnName("tipo_prazo");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
        });

        modelBuilder.Entity<Fornecedor>(entity =>
        {
            entity.HasKey(e => e.CdForn).HasName("fornecedor_pkey");

            entity.ToTable("fornecedor");

            entity.HasIndex(e => e.NmForn, "fornecedor_idx");

            entity.Property(e => e.CdForn)
                .HasDefaultValueSql("nextval('gen_fornecedor_id'::regclass)")
                .HasColumnName("cd_forn");
            entity.Property(e => e.Bairro)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bairro");
            entity.Property(e => e.CdCep)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_cep");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cnpj");
            entity.Property(e => e.Complemento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("complemento");
            entity.Property(e => e.Cpf)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cpf");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("email");
            entity.Property(e => e.IdCliente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.NmEndereco)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_endereco");
            entity.Property(e => e.NmFantasia)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_fantasia");
            entity.Property(e => e.NmForn)
                .HasMaxLength(150)
                .HasColumnName("nm_forn");
            entity.Property(e => e.NmRepresentante)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_representante");
            entity.Property(e => e.NrInscrEstadual)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_inscr_estadual");
            entity.Property(e => e.Numero)
                .HasDefaultValueSql("0")
                .HasColumnName("numero");
            entity.Property(e => e.Parceiro)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("parceiro");
            entity.Property(e => e.Ramo)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ramo");
            entity.Property(e => e.TelefoneEmpresa)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone_empresa");
            entity.Property(e => e.TelefoneRepresentante)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("telefone_representante");
        });

        modelBuilder.Entity<Frete>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("frete_pkey");

            entity.ToTable("frete");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_frete_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdTransp).HasColumnName("cd_transp");
            entity.Property(e => e.Especie)
                .HasMaxLength(62)
                .HasColumnName("especie");
            entity.Property(e => e.FretePorConta).HasColumnName("frete_por_conta");
            entity.Property(e => e.Marca)
                .HasMaxLength(62)
                .HasColumnName("marca");
            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.Numeracao)
                .HasMaxLength(62)
                .HasColumnName("numeracao");
            entity.Property(e => e.Pbruto)
                .HasPrecision(18, 4)
                .HasColumnName("pbruto");
            entity.Property(e => e.Pliq)
                .HasPrecision(18, 4)
                .HasColumnName("pliq");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant");
            entity.Property(e => e.VlFrete)
                .HasPrecision(18, 4)
                .HasColumnName("vl_frete");

            entity.HasOne(d => d.CdTranspNavigation).WithMany(p => p.Fretes)
                .HasForeignKey(d => d.CdTransp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frete_fk1");

            entity.HasOne(d => d.NrSaidaNavigation).WithMany(p => p.Fretes)
                .HasForeignKey(d => d.NrSaida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frete_fk");
        });

        modelBuilder.Entity<FrotaEmpresa>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("frota_empresa_pkey");

            entity.ToTable("frota_empresa");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_frota_empresa_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdMarca).HasColumnName("cd_marca");
            entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");
            entity.Property(e => e.NmVeiculo)
                .HasMaxLength(150)
                .HasColumnName("nm_veiculo");
            entity.Property(e => e.Placa)
                .HasMaxLength(10)
                .HasColumnName("placa");
            entity.Property(e => e.TpCombustivel)
                .HasMaxLength(1)
                .HasColumnName("tp_combustivel");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");

            entity.HasOne(d => d.CdMarcaNavigation).WithMany(p => p.FrotaEmpresas)
                .HasForeignKey(d => d.CdMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frota_empresa_fk");

            entity.HasOne(d => d.CdModeloNavigation).WithMany(p => p.FrotaEmpresas)
                .HasForeignKey(d => d.CdModelo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("frota_empresa_fk1");
        });

        modelBuilder.Entity<Funcionario>(entity =>
        {
            entity.HasKey(e => e.CdFuncionario).HasName("funcionario_pkey");

            entity.ToTable("funcionario");

            entity.Property(e => e.CdFuncionario)
                .HasDefaultValueSql("nextval('gen_funcionario_id'::regclass)")
                .HasColumnName("cd_funcionario");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("bairro");
            entity.Property(e => e.Cargo)
                .HasMaxLength(62)
                .HasColumnName("cargo");
            entity.Property(e => e.CdCbo)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_cbo");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("cd_interno");
            entity.Property(e => e.Cep)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cep");
            entity.Property(e => e.Cidade)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cidade");
            entity.Property(e => e.Color)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("color");
            entity.Property(e => e.DataRescisao).HasColumnName("data_rescisao");
            entity.Property(e => e.DtAdmissao).HasColumnName("dt_admissao");
            entity.Property(e => e.DtNascimento)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_nascimento");
            entity.Property(e => e.Endereco)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("endereco");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("estado_civil");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.Mecanico)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("mecanico");
            entity.Property(e => e.NmFuncionario)
                .HasMaxLength(62)
                .HasColumnName("nm_funcionario");
            entity.Property(e => e.NrCarteira)
                .HasMaxLength(20)
                .HasColumnName("nr_carteira");
            entity.Property(e => e.NrCpf)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_cpf");
            entity.Property(e => e.NrRg)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_rg");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_telefone");
            entity.Property(e => e.NrTelefone2)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_telefone2");
            entity.Property(e => e.Numero)
                .HasDefaultValueSql("0")
                .HasColumnName("numero");
            entity.Property(e => e.Pasep)
                .HasMaxLength(20)
                .HasColumnName("pasep");
            entity.Property(e => e.Registrado)
                .HasMaxLength(1)
                .HasColumnName("registrado");
            entity.Property(e => e.Salario)
                .HasPrecision(18, 2)
                .HasColumnName("salario");
            entity.Property(e => e.SalarioCarteira).HasColumnName("salario_carteira");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sexo");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.Vendedor)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("vendedor");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.Funcionarios)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("funcionario_fk");

            entity.HasOne(d => d.CidadeNavigation).WithMany(p => p.Funcionarios)
                .HasForeignKey(d => d.Cidade)
                .HasConstraintName("funcionario_fk1");

            entity.HasMany(d => d.NmUsuarios).WithMany(p => p.CdFuncionarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioFuncionario",
                    r => r.HasOne<Usuario>().WithMany()
                        .HasForeignKey("NmUsuario")
                        .HasConstraintName("usuario_funcionario_fk1"),
                    l => l.HasOne<Funcionario>().WithMany()
                        .HasForeignKey("CdFuncionario")
                        .HasConstraintName("usuario_funcionario_fk"),
                    j =>
                    {
                        j.HasKey("CdFuncionario", "NmUsuario").HasName("usuario_funcionario_idx");
                        j.ToTable("usuario_funcionario");
                        j.IndexerProperty<int>("CdFuncionario").HasColumnName("cd_funcionario");
                        j.IndexerProperty<string>("NmUsuario")
                            .HasMaxLength(62)
                            .HasColumnName("nm_usuario");
                    });
        });

        modelBuilder.Entity<GeneroFisal>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("genero_fisal_pkey");

            entity.ToTable("genero_fisal");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("grupo");

            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<GrupoEstoque>(entity =>
        {
            entity.HasKey(e => e.CdGrupo).HasName("grupo_estoque_pkey");

            entity.ToTable("grupo_estoque");

            entity.HasIndex(e => e.NmGrupo, "grupo_estoque_idx");

            entity.Property(e => e.CdGrupo)
                .HasDefaultValueSql("nextval('gen_grupo_estoque'::regclass)")
                .HasColumnName("cd_grupo");
            entity.Property(e => e.Acai)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("acai");
            entity.Property(e => e.Comanda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("comanda");
            entity.Property(e => e.NmGrupo)
                .HasMaxLength(62)
                .HasColumnName("nm_grupo");
            entity.Property(e => e.NrOrdem)
                .HasDefaultValueSql("1")
                .HasColumnName("nr_ordem");
            entity.Property(e => e.Pizza)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pizza");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<HistoricoCaixa>(entity =>
        {
            entity.HasKey(e => new { e.CdSubPlano, e.CdPlano }).HasName("historico_caixa_pkey");

            entity.ToTable("historico_caixa");

            entity.Property(e => e.CdSubPlano)
                .HasMaxLength(25)
                .HasColumnName("cd_sub_plano");
            entity.Property(e => e.CdPlano)
                .HasMaxLength(25)
                .HasColumnName("cd_plano");
            entity.Property(e => e.Descricao)
                .HasMaxLength(62)
                .HasColumnName("descricao");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");

            entity.HasOne(d => d.CdPlanoNavigation).WithMany(p => p.HistoricoCaixas)
                .HasForeignKey(d => d.CdPlano)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("historico_caixa_fk");
        });

        modelBuilder.Entity<HoraAlunoMatricula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("hora_aluno_matricula_pkey");

            entity.ToTable("hora_aluno_matricula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DiaSemana)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("dia_semana");
            entity.Property(e => e.HoraFinal)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora_final");
            entity.Property(e => e.HoraInicial)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora_inicial");
            entity.Property(e => e.IdAluno).HasColumnName("id_aluno");

            entity.HasOne(d => d.IdAlunoNavigation).WithMany(p => p.HoraAlunoMatriculas)
                .HasForeignKey(d => d.IdAluno)
                .HasConstraintName("hora_aluno_matricula_fk");
        });

        modelBuilder.Entity<Ibpt>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("ibpt_pkey");

            entity.ToTable("ibpt");

            entity.HasIndex(e => e.Codigo, "ibpt_idx");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval(('public.gen_ibpt_id'::text)::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Aliqestadual)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliqestadual");
            entity.Property(e => e.Aliqimp)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliqimp");
            entity.Property(e => e.Aliqmunicipal)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliqmunicipal");
            entity.Property(e => e.Aliqnac)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliqnac");
            entity.Property(e => e.Codigo)
                .HasMaxLength(8)
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao");
            entity.Property(e => e.Ex)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ex");
            entity.Property(e => e.Tabela)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tabela");
        });

        modelBuilder.Entity<Icm>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("icms_pkey");

            entity.ToTable("icms");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval(('public.gen_icms_id'::text)::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Ac)
                .HasPrecision(18, 2)
                .HasColumnName("ac");
            entity.Property(e => e.Al)
                .HasPrecision(18, 2)
                .HasColumnName("al");
            entity.Property(e => e.Am)
                .HasPrecision(18, 2)
                .HasColumnName("am");
            entity.Property(e => e.Ap)
                .HasPrecision(18, 2)
                .HasColumnName("ap");
            entity.Property(e => e.Ba)
                .HasPrecision(18, 2)
                .HasColumnName("ba");
            entity.Property(e => e.Ce)
                .HasPrecision(18, 2)
                .HasColumnName("ce");
            entity.Property(e => e.Df)
                .HasPrecision(18, 2)
                .HasColumnName("df");
            entity.Property(e => e.Es)
                .HasPrecision(18, 2)
                .HasColumnName("es");
            entity.Property(e => e.Ex)
                .HasPrecision(18, 2)
                .HasColumnName("ex");
            entity.Property(e => e.Go)
                .HasPrecision(18, 2)
                .HasColumnName("go");
            entity.Property(e => e.Ma)
                .HasPrecision(18, 2)
                .HasColumnName("ma");
            entity.Property(e => e.Mg)
                .HasPrecision(18, 2)
                .HasColumnName("mg");
            entity.Property(e => e.Ms)
                .HasPrecision(18, 2)
                .HasColumnName("ms");
            entity.Property(e => e.Mt)
                .HasPrecision(18, 2)
                .HasColumnName("mt");
            entity.Property(e => e.Pa)
                .HasPrecision(18, 2)
                .HasColumnName("pa");
            entity.Property(e => e.Pb)
                .HasPrecision(18, 2)
                .HasColumnName("pb");
            entity.Property(e => e.Pi)
                .HasPrecision(18, 2)
                .HasColumnName("pi");
            entity.Property(e => e.Pr)
                .HasPrecision(18, 2)
                .HasColumnName("pr");
            entity.Property(e => e.Rj)
                .HasPrecision(18, 2)
                .HasColumnName("rj");
            entity.Property(e => e.Rn)
                .HasPrecision(18, 2)
                .HasColumnName("rn");
            entity.Property(e => e.Ro)
                .HasPrecision(18, 2)
                .HasColumnName("ro");
            entity.Property(e => e.Rr)
                .HasPrecision(18, 2)
                .HasColumnName("rr");
            entity.Property(e => e.Rs)
                .HasPrecision(18, 2)
                .HasColumnName("rs");
            entity.Property(e => e.Sc)
                .HasPrecision(18, 2)
                .HasColumnName("sc");
            entity.Property(e => e.Se)
                .HasPrecision(18, 2)
                .HasColumnName("se");
            entity.Property(e => e.Sp)
                .HasPrecision(18, 2)
                .HasColumnName("sp");
            entity.Property(e => e.To)
                .HasPrecision(18, 2)
                .HasColumnName("to");
        });

        modelBuilder.Entity<IcmsCsosn>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("icms_csosn_pkey");

            entity.ToTable("icms_csosn");

            entity.Property(e => e.Codigo)
                .HasMaxLength(10)
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<InformacaoTecnicaProduto>(entity =>
        {
            entity.HasKey(e => new { e.IdProduto, e.IdInfTecnica }).HasName("informacao_tecnica_produto_pkey");

            entity.ToTable("informacao_tecnica_produto");

            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdInfTecnica).HasColumnName("id_inf_tecnica");
            entity.Property(e => e.Texto)
                .HasMaxLength(16384)
                .HasColumnName("texto");

            entity.HasOne(d => d.IdInfTecnicaNavigation).WithMany(p => p.InformacaoTecnicaProdutos)
                .HasForeignKey(d => d.IdInfTecnica)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("informacao_tecnica_produto_fk1");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.InformacaoTecnicaProdutos)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("informacao_tecnica_produto_fk");
        });

        modelBuilder.Entity<InventarioCabecalho>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("inventario_cabecalho");

            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Descricao)
                .HasMaxLength(64)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<InventarioDetalhe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("inventario_detalhe");

            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Descricao)
                .HasMaxLength(256)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdCabecalho).HasColumnName("id_cabecalho");
            entity.Property(e => e.Saldo)
                .HasPrecision(18, 4)
                .HasColumnName("saldo");
            entity.Property(e => e.Tributacao)
                .HasMaxLength(2)
                .HasColumnName("tributacao");
            entity.Property(e => e.Unidade)
                .HasMaxLength(2)
                .HasColumnName("unidade");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnit)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit");
        });

        modelBuilder.Entity<ItensApontamentoCaminhao>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("itens_apontamento_caminhao_pkey");

            entity.ToTable("itens_apontamento_caminhao");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_it_ap_cam'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdMaterial).HasColumnName("cd_material");
            entity.Property(e => e.DtLanc).HasColumnName("dt_lanc");
            entity.Property(e => e.HrDescanso).HasColumnName("hr_descanso");
            entity.Property(e => e.HrFinal).HasColumnName("hr_final");
            entity.Property(e => e.HrInicial).HasColumnName("hr_inicial");
            entity.Property(e => e.KmFinal)
                .HasPrecision(18, 4)
                .HasColumnName("km_final");
            entity.Property(e => e.KmInicial)
                .HasPrecision(18, 4)
                .HasColumnName("km_inicial");
            entity.Property(e => e.Local)
                .HasMaxLength(150)
                .HasColumnName("local");
            entity.Property(e => e.NrCab).HasColumnName("nr_cab");
            entity.Property(e => e.QtdViagem).HasColumnName("qtd_viagem");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");

            entity.HasOne(d => d.CdMaterialNavigation).WithMany(p => p.ItensApontamentoCaminhaos)
                .HasForeignKey(d => d.CdMaterial)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("itens_apontamento_caminhao_fk1");

            entity.HasOne(d => d.NrCabNavigation).WithMany(p => p.ItensApontamentoCaminhaos)
                .HasForeignKey(d => d.NrCab)
                .HasConstraintName("itens_apontamento_caminhao_fk");
        });

        modelBuilder.Entity<ItensBalanco>(entity =>
        {
            entity.HasKey(e => e.Iditem).HasName("itens_balanco_pkey");

            entity.ToTable("itens_balanco");

            entity.Property(e => e.Iditem)
                .HasDefaultValueSql("nextval('gen_id_itens_balanco'::regclass)")
                .HasColumnName("iditem");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Codbalanco).HasColumnName("codbalanco");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(62)
                .HasColumnName("nm_produto");
            entity.Property(e => e.SaldoAtual)
                .HasPrecision(18, 4)
                .HasColumnName("saldo_atual");
            entity.Property(e => e.SaldoBalanco)
                .HasPrecision(18, 4)
                .HasColumnName("saldo_balanco");
            entity.Property(e => e.SaldoDiferenca)
                .HasPrecision(18, 4)
                .HasColumnName("saldo_diferenca");
            entity.Property(e => e.Validade).HasColumnName("validade");

            entity.HasOne(d => d.CodbalancoNavigation).WithMany(p => p.ItensBalancos)
                .HasForeignKey(d => d.Codbalanco)
                .HasConstraintName("itens_balanco_fk");
        });

        modelBuilder.Entity<ItensCotacaoPreco>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("itens_cotacao_preco_pkey");

            entity.ToTable("itens_cotacao_preco");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_it_ct_pc_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdFornecedor).HasColumnName("cd_fornecedor");
            entity.Property(e => e.NrCab).HasColumnName("nr_cab");
            entity.Property(e => e.Posicao).HasColumnName("posicao");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");

            entity.HasOne(d => d.CdFornecedorNavigation).WithMany(p => p.ItensCotacaoPrecos)
                .HasForeignKey(d => d.CdFornecedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("itens_cotacao_preco_fk1");

            entity.HasOne(d => d.NrCabNavigation).WithMany(p => p.ItensCotacaoPrecos)
                .HasForeignKey(d => d.NrCab)
                .HasConstraintName("itens_cotacao_preco_fk");
        });

        modelBuilder.Entity<ItensOrcamento>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("itens_orcamento_pkey");

            entity.ToTable("itens_orcamento");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_itens_orcamento_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdPlano)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.IdSerieConstrutor)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_serie_construtor");
            entity.Property(e => e.IdSerieProduto)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_serie_produto");
            entity.Property(e => e.IdTipoTabelaPreco)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_tipo_tabela_preco");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("lote");
            entity.Property(e => e.NrOr).HasColumnName("nr_or");
            entity.Property(e => e.ObsProduto)
                .HasMaxLength(16384)
                .HasColumnName("obs_produto");
            entity.Property(e => e.QtEntrega)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_entrega");
            entity.Property(e => e.QtRecolhimento)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_recolhimento");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comissao");
            entity.Property(e => e.VlCusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo");
            entity.Property(e => e.VlDesc)
                .HasPrecision(18, 4)
                .HasColumnName("vl_desc");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ItensOrcamentos)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("itens_orcamento_fk1");

            entity.HasOne(d => d.NrOrNavigation).WithMany(p => p.ItensOrcamentos)
                .HasForeignKey(d => d.NrOr)
                .HasConstraintName("itens_orcamento_fk");
        });

        modelBuilder.Entity<ItensVendaControlado>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("itens_venda_controlado_pkey");

            entity.ToTable("itens_venda_controlado");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_itens_venda_con_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.NrCab).HasColumnName("nr_cab");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
            entity.Property(e => e.UsoProlongado)
                .HasMaxLength(1)
                .HasColumnName("uso_prolongado");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ItensVendaControlados)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("itens_venda_controlado_fk1");

            entity.HasOne(d => d.NrCabNavigation).WithMany(p => p.ItensVendaControlados)
                .HasForeignKey(d => d.NrCab)
                .HasConstraintName("itens_venda_controlado_fk");
        });

        modelBuilder.Entity<KitItensOrcamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("kit_itens_orcamento_pkey");

            entity.ToTable("kit_itens_orcamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.IdItemOs).HasColumnName("id_item_os");
            entity.Property(e => e.IdKit).HasColumnName("id_kit");
            entity.Property(e => e.IdProdKit).HasColumnName("id_prod_kit");
            entity.Property(e => e.IdProdutoPai).HasColumnName("id_produto_pai");
            entity.Property(e => e.IdSerieKitOrc)
                .HasMaxLength(62)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_serie_kit_orc");
            entity.Property(e => e.NmKit)
                .HasMaxLength(255)
                .HasColumnName("nm_kit");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(255)
                .HasColumnName("nm_produto");
            entity.Property(e => e.Qtde)
                .HasPrecision(18, 4)
                .HasColumnName("qtde");
            entity.Property(e => e.Sequencia).HasColumnName("sequencia");
            entity.Property(e => e.Somado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("somado");
            entity.Property(e => e.Valor)
                .HasPrecision(15, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdItemOsNavigation).WithMany(p => p.KitItensOrcamentos)
                .HasForeignKey(d => d.IdItemOs)
                .HasConstraintName("kit_itens_orcamento_fk");
        });

        modelBuilder.Entity<KitProduto>(entity =>
        {
            entity.HasKey(e => e.NrKit).HasName("kit_produto_pkey");

            entity.ToTable("kit_produto");

            entity.HasIndex(e => e.NmKit, "kit_produto_idx");

            entity.Property(e => e.NrKit)
                .HasDefaultValueSql("nextval('gen_kit_produto_id'::regclass)")
                .HasColumnName("nr_kit");
            entity.Property(e => e.IdTipoKit)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_tipo_kit");
            entity.Property(e => e.NmKit)
                .HasMaxLength(150)
                .HasColumnName("nm_kit");
            entity.Property(e => e.Obrigatorio)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("obrigatorio");
            entity.Property(e => e.SelAutomatico)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("sel_automatico");
        });

        modelBuilder.Entity<LancCarga>(entity =>
        {
            entity.HasKey(e => e.NrCarga).HasName("lanc_carga_pkey");

            entity.ToTable("lanc_carga");

            entity.Property(e => e.NrCarga)
                .HasDefaultValueSql("nextval('gen_lanc_carga_id'::regclass)")
                .HasColumnName("nr_carga");
            entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");
            entity.Property(e => e.DtFinal).HasColumnName("dt_final");
            entity.Property(e => e.DtInicial).HasColumnName("dt_inicial");
            entity.Property(e => e.DtSaidaCarga).HasColumnName("dt_saida_carga");
            entity.Property(e => e.Fechou)
                .HasMaxLength(1)
                .HasColumnName("fechou");
        });

        modelBuilder.Entity<LivroCaixa>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("livro_caixa_pkey");

            entity.ToTable("livro_caixa");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_livro_caixa_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdHistorico)
                .HasMaxLength(25)
                .HasColumnName("cd_historico");
            entity.Property(e => e.CdPlanoCaixa)
                .HasMaxLength(25)
                .HasColumnName("cd_plano_caixa");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.IdBandeira).HasColumnName("id_bandeira");
            entity.Property(e => e.IdCliente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_cliente");
            entity.Property(e => e.NrCentroCusto).HasColumnName("nr_centro_custo");
            entity.Property(e => e.NrCheque)
                .HasMaxLength(10)
                .HasColumnName("nr_cheque");
            entity.Property(e => e.NrConta).HasColumnName("nr_conta");
            entity.Property(e => e.NrCp).HasColumnName("nr_cp");
            entity.Property(e => e.NrCr).HasColumnName("nr_cr");
            entity.Property(e => e.NrDoc)
                .HasMaxLength(25)
                .HasColumnName("nr_doc");
            entity.Property(e => e.NrFinalEcf).HasColumnName("nr_final_ecf");
            entity.Property(e => e.NrIdComanda).HasColumnName("nr_id_comanda");
            entity.Property(e => e.NrSaidaEstoque)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_saida_estoque");
            entity.Property(e => e.NrSangria).HasColumnName("nr_sangria");
            entity.Property(e => e.NrValeFunc).HasColumnName("nr_vale_func");
            entity.Property(e => e.NrVendaBalcao)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_venda_balcao");
            entity.Property(e => e.NrVendaC).HasColumnName("nr_venda_c");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlLancamento)
                .HasPrecision(18, 4)
                .HasColumnName("vl_lancamento");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.LivroCaixas)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("livro_caixa_fk");

            entity.HasOne(d => d.NrContaNavigation).WithMany(p => p.LivroCaixas)
                .HasForeignKey(d => d.NrConta)
                .HasConstraintName("livro_caixa_fk1");

            entity.HasOne(d => d.Cd).WithMany(p => p.LivroCaixas)
                .HasForeignKey(d => new { d.CdHistorico, d.CdPlanoCaixa })
                .HasConstraintName("livro_caixa_fk2");
        });

        modelBuilder.Entity<LocacaoOrcamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("locacao_orcamento");

            entity.Property(e => e.CdMecanico).HasColumnName("cd_mecanico");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.DiasPermanencia).HasColumnName("dias_permanencia");
            entity.Property(e => e.DtEntrega).HasColumnName("dt_entrega");
            entity.Property(e => e.DtRetirada).HasColumnName("dt_retirada");
            entity.Property(e => e.FormaPgto)
                .HasMaxLength(20)
                .HasColumnName("forma_pgto");
            entity.Property(e => e.HorasPermanencia)
                .HasMaxLength(30)
                .HasColumnName("horas_permanencia");
            entity.Property(e => e.HrEntrega)
                .HasMaxLength(30)
                .HasColumnName("hr_entrega");
            entity.Property(e => e.HrRetirada)
                .HasMaxLength(30)
                .HasColumnName("hr_retirada");
            entity.Property(e => e.IdEnderecoEntrega)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_endereco_entrega");
            entity.Property(e => e.IdLoc)
                .HasDefaultValueSql("nextval('gen_locacao_orcamento_id'::regclass)")
                .HasColumnName("id_loc");
            entity.Property(e => e.IdOrcamento).HasColumnName("id_orcamento");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasColumnName("obs");
            entity.Property(e => e.Pagou)
                .HasMaxLength(3)
                .HasDefaultValueSql("'Nao'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.Qtd)
                .HasPrecision(18, 4)
                .HasColumnName("qtd");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .HasDefaultValueSql("'LOCADA'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TaxaDiaExcedente)
                .HasPrecision(18, 4)
                .HasColumnName("taxa_dia_excedente");
            entity.Property(e => e.Tipo)
                .HasMaxLength(10)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoUtilizacao)
                .HasMaxLength(50)
                .HasColumnName("tipo_utilizacao");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
            entity.Property(e => e.ValorHora)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_hora");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_total");
        });

        modelBuilder.Entity<LogContaDoCaixa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("log_conta_do_caixa_pkey");

            entity.ToTable("log_conta_do_caixa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Datahora)
                .HasColumnType("timestamp(0) without time zone")
                .HasColumnName("datahora");
            entity.Property(e => e.Descricao)
                .HasMaxLength(512)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<LogImportacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("log_importacao_pkey");

            entity.ToTable("log_importacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataImportacao).HasColumnName("data_importacao");
            entity.Property(e => e.HoraImportacao)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hora_importacao");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.LogErro)
                .HasMaxLength(250)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("log_erro");
        });

        modelBuilder.Entity<LubrificanteFrotaEmp>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("lubrificante_frota_emp_pkey");

            entity.ToTable("lubrificante_frota_emp");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_lubr_fr_emp_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdEquipamento)
                .HasMaxLength(15)
                .HasColumnName("cd_equipamento");
            entity.Property(e => e.CdFunc).HasColumnName("cd_func");
            entity.Property(e => e.CdLubrificante).HasColumnName("cd_lubrificante");
            entity.Property(e => e.CdPosto).HasColumnName("cd_posto");
            entity.Property(e => e.CdVeiculo).HasColumnName("cd_veiculo");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DataLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data_lanc");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.Km)
                .HasPrecision(18, 2)
                .HasColumnName("km");
            entity.Property(e => e.Local)
                .HasMaxLength(150)
                .HasColumnName("local");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 2)
                .HasColumnName("quantidade");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");

            entity.HasOne(d => d.CdFuncNavigation).WithMany(p => p.LubrificanteFrotaEmps)
                .HasForeignKey(d => d.CdFunc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lubrificante_frota_emp_fk");

            entity.HasOne(d => d.CdVeiculoNavigation).WithMany(p => p.LubrificanteFrotaEmps)
                .HasForeignKey(d => d.CdVeiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("lubrificante_frota_emp_fk1");
        });

        modelBuilder.Entity<MPagamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("m_pagamentos");

            entity.Property(e => e.DataAcumulado).HasColumnName("data_acumulado");
            entity.Property(e => e.Descricao)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao");
            entity.Property(e => e.Hash)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("hash");
            entity.Property(e => e.HashIncremento).HasColumnName("hash_incremento");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Tipodoc)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tipodoc");
            entity.Property(e => e.Total)
                .HasPrecision(18, 6)
                .HasColumnName("total");
        });

        modelBuilder.Entity<MarcaAutomovel>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("marca_automovel_pkey");

            entity.ToTable("marca_automovel");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_marca_automovel_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<MarcaProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("marca_produto_pkey");

            entity.ToTable("marca_produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<MaterialTerraplenagem>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("material_terraplenagem_pkey");

            entity.ToTable("material_terraplenagem");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_mat_ter_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Mdfe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mdfe_pkey");

            entity.ToTable("mdfe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Chnfe)
                .HasMaxLength(44)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chnfe");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.Modal)
                .HasMaxLength(2)
                .HasColumnName("modal");
            entity.Property(e => e.Modelo)
                .HasMaxLength(2)
                .HasColumnName("modelo");
            entity.Property(e => e.NrAutorizacaoMdfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_autorizacao_mdfe");
            entity.Property(e => e.NrCmdf)
                .HasDefaultValueSql("0")
                .HasColumnName("nr_cmdf");
            entity.Property(e => e.NrDmfe)
                .HasMaxLength(10)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("nr_dmfe");
            entity.Property(e => e.NrProtoCancelamento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_proto_cancelamento");
            entity.Property(e => e.NrProtoEncerramento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_proto_encerramento");
            entity.Property(e => e.Obs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("obs");
            entity.Property(e => e.ProdCean)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prod_cean");
            entity.Property(e => e.ProdCepcar)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prod_cepcar");
            entity.Property(e => e.ProdCepdes)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prod_cepdes");
            entity.Property(e => e.ProdDescricao)
                .HasMaxLength(128)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prod_descricao");
            entity.Property(e => e.ProdNcm)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prod_ncm");
            entity.Property(e => e.ProdTpCarga)
                .HasDefaultValueSql("0")
                .HasColumnName("prod_tp_carga");
            entity.Property(e => e.Serie)
                .HasMaxLength(2)
                .HasColumnName("serie");
            entity.Property(e => e.Status)
                .HasMaxLength(3)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.Tpemis)
                .HasMaxLength(2)
                .HasColumnName("tpemis");
            entity.Property(e => e.Tpemit)
                .HasMaxLength(2)
                .HasColumnName("tpemit");
            entity.Property(e => e.Tptransp)
                .HasMaxLength(2)
                .HasDefaultValueSql("'2'::character varying")
                .HasColumnName("tptransp");
            entity.Property(e => e.TxtJustificativaCancelamento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_justificativa_cancelamento");
            entity.Property(e => e.UfFinal)
                .HasMaxLength(2)
                .HasColumnName("uf_final");
            entity.Property(e => e.UfSaida)
                .HasMaxLength(2)
                .HasColumnName("uf_saida");
            entity.Property(e => e.XmlMdfe)
                .HasDefaultValueSql("''::text")
                .HasColumnName("xml_mdfe");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Mdves)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("mdfe_fk");
        });

        modelBuilder.Entity<MdfeChafe>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mdfe_chaves");

            entity.Property(e => e.Chave)
                .HasMaxLength(128)
                .HasColumnName("chave");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(32)
                .HasColumnName("cnpj");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");
            entity.Property(e => e.IdMunicipio)
                .HasMaxLength(10)
                .HasColumnName("id_municipio");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<MdfeCondutor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mdfe_condutor_pkey");

            entity.ToTable("mdfe_condutor");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cpf)
                .HasMaxLength(18)
                .HasColumnName("cpf");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");
            entity.Property(e => e.Xnome)
                .HasMaxLength(60)
                .HasColumnName("xnome");

            entity.HasOne(d => d.IdMdfeNavigation).WithMany(p => p.MdfeCondutors)
                .HasForeignKey(d => d.IdMdfe)
                .HasConstraintName("mdfe_condutor_fk");
        });

        modelBuilder.Entity<MdfeInfcarregamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mdfe_infcarregamento_pkey");

            entity.ToTable("mdfe_infcarregamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cmuncarrega)
                .HasMaxLength(10)
                .HasColumnName("cmuncarrega");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");

            entity.HasOne(d => d.CmuncarregaNavigation).WithMany(p => p.MdfeInfcarregamentos)
                .HasForeignKey(d => d.Cmuncarrega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mdfe_infcarregamento_fk1");

            entity.HasOne(d => d.IdMdfeNavigation).WithMany(p => p.MdfeInfcarregamentos)
                .HasForeignKey(d => d.IdMdfe)
                .HasConstraintName("mdfe_infcarregamento_fk");
        });

        modelBuilder.Entity<MdfePercurso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mdfe_percurso");

            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .HasColumnName("estado");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");
        });

        modelBuilder.Entity<MdfeReboque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mdfe_reboque_pkey");

            entity.ToTable("mdfe_reboque");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capkg)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("capkg");
            entity.Property(e => e.Capm3)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("capm3");
            entity.Property(e => e.Cint)
                .HasMaxLength(10)
                .HasColumnName("cint");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");
            entity.Property(e => e.Renavam)
                .HasMaxLength(11)
                .HasColumnName("renavam");
            entity.Property(e => e.Tara)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("tara");
            entity.Property(e => e.Tpcar)
                .HasMaxLength(2)
                .HasDefaultValueSql("'00'::character varying")
                .HasColumnName("tpcar");
            entity.Property(e => e.Tprod)
                .HasMaxLength(2)
                .HasColumnName("tprod");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");

            entity.HasOne(d => d.IdMdfeNavigation).WithMany(p => p.MdfeReboques)
                .HasForeignKey(d => d.IdMdfe)
                .HasConstraintName("mdfe_reboque_fk");
        });

        modelBuilder.Entity<MdfeRodoviario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("mdfe_rodoviario_pkey");

            entity.ToTable("mdfe_rodoviario");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Capkg)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("capkg");
            entity.Property(e => e.Capm3)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("capm3");
            entity.Property(e => e.Cint)
                .HasMaxLength(10)
                .HasColumnName("cint");
            entity.Property(e => e.Ciot)
                .HasMaxLength(12)
                .HasColumnName("ciot");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");
            entity.Property(e => e.PesoTotal)
                .HasPrecision(18, 2)
                .HasColumnName("peso_total");
            entity.Property(e => e.Placa)
                .HasMaxLength(7)
                .HasColumnName("placa");
            entity.Property(e => e.PropCpfcnpj)
                .HasMaxLength(14)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prop_cpfcnpj");
            entity.Property(e => e.PropIe)
                .HasMaxLength(14)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prop_ie");
            entity.Property(e => e.PropNome)
                .HasMaxLength(40)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prop_nome");
            entity.Property(e => e.PropRntrc)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prop_rntrc");
            entity.Property(e => e.PropTipo)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prop_tipo");
            entity.Property(e => e.PropUf)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prop_uf");
            entity.Property(e => e.Renavam)
                .HasMaxLength(11)
                .HasColumnName("renavam");
            entity.Property(e => e.Rntrc)
                .HasMaxLength(8)
                .HasColumnName("rntrc");
            entity.Property(e => e.Tara)
                .HasPrecision(15, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("tara");
            entity.Property(e => e.Tpcar)
                .HasMaxLength(2)
                .HasDefaultValueSql("'00'::character varying")
                .HasColumnName("tpcar");
            entity.Property(e => e.Tprod)
                .HasMaxLength(2)
                .HasColumnName("tprod");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
            entity.Property(e => e.ValorCarga)
                .HasPrecision(18, 2)
                .HasColumnName("valor_carga");

            entity.HasOne(d => d.IdMdfeNavigation).WithMany(p => p.MdfeRodoviarios)
                .HasForeignKey(d => d.IdMdfe)
                .HasConstraintName("mdfe_rodoviario_fk");
        });

        modelBuilder.Entity<MdfeSeguro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mdfe_seguro");

            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdMdfe).HasColumnName("id_mdfe");
            entity.Property(e => e.NmSeguradora)
                .HasMaxLength(64)
                .HasColumnName("nm_seguradora");
            entity.Property(e => e.NrApolice)
                .HasMaxLength(32)
                .HasColumnName("nr_apolice");
            entity.Property(e => e.NrAverbacao)
                .HasMaxLength(32)
                .HasColumnName("nr_averbacao");
            entity.Property(e => e.Responsavel)
                .HasMaxLength(64)
                .HasColumnName("responsavel");
            entity.Property(e => e.VlMercadoria)
                .HasPrecision(18, 2)
                .HasColumnName("vl_mercadoria");
        });

        modelBuilder.Entity<Medico>(entity =>
        {
            entity.HasKey(e => e.CdMedico).HasName("medicos_pkey");

            entity.ToTable("medicos");

            entity.Property(e => e.CdMedico)
                .HasDefaultValueSql("nextval('gen_medicos_id'::regclass)")
                .HasColumnName("cd_medico");
            entity.Property(e => e.Bairro)
                .HasMaxLength(62)
                .HasColumnName("bairro");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.CdCrm)
                .HasMaxLength(15)
                .HasColumnName("cd_crm");
            entity.Property(e => e.Cep)
                .HasMaxLength(9)
                .HasColumnName("cep");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.NmMedico)
                .HasMaxLength(150)
                .HasColumnName("nm_medico");
            entity.Property(e => e.Telefone)
                .HasMaxLength(18)
                .HasColumnName("telefone");
            entity.Property(e => e.TpConselho)
                .HasMaxLength(10)
                .HasColumnName("tp_conselho");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasColumnName("txt_obs");
            entity.Property(e => e.UfCrm)
                .HasMaxLength(2)
                .HasColumnName("uf_crm");
        });

        modelBuilder.Entity<Medico1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("medico_pkey");

            entity.ToTable("medico");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdInterno)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_interno");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<MenuSistema>(entity =>
        {
            entity.HasKey(e => e.NrMenu).HasName("menu_sistema_pkey");

            entity.ToTable("menu_sistema");

            entity.Property(e => e.NrMenu)
                .HasDefaultValueSql("nextval(('public.gen_menu_sistema_id'::text)::regclass)")
                .HasColumnName("nr_menu");
            entity.Property(e => e.CdModulo)
                .HasMaxLength(2)
                .HasColumnName("cd_modulo");
            entity.Property(e => e.NmFormulario)
                .HasMaxLength(62)
                .HasColumnName("nm_formulario");
            entity.Property(e => e.NmMenu)
                .HasMaxLength(62)
                .HasColumnName("nm_menu");

            entity.HasOne(d => d.CdModuloNavigation).WithMany(p => p.MenuSistemas)
                .HasForeignKey(d => d.CdModulo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_menu_sistema_1");
        });

        modelBuilder.Entity<MenuUsuario>(entity =>
        {
            entity.HasKey(e => new { e.NmUsuario, e.NrMenu }).HasName("menu_usuario_pkey");

            entity.ToTable("menu_usuario");

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(62)
                .HasColumnName("nm_usuario");
            entity.Property(e => e.NrMenu).HasColumnName("nr_menu");
            entity.Property(e => e.Alterar)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("alterar");
            entity.Property(e => e.Excluir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("excluir");
            entity.Property(e => e.Incluir)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("incluir");

            entity.HasOne(d => d.NmUsuarioNavigation).WithMany(p => p.MenuUsuarios)
                .HasForeignKey(d => d.NmUsuario)
                .HasConstraintName("menu_usuario_fk");

            entity.HasOne(d => d.NrMenuNavigation).WithMany(p => p.MenuUsuarios)
                .HasForeignKey(d => d.NrMenu)
                .HasConstraintName("menu_usuario_fk1");
        });

        modelBuilder.Entity<Mesa>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("mesa_pkey");

            entity.ToTable("mesa");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_mesa_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Ativa)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativa");
            entity.Property(e => e.NomeMesa)
                .HasMaxLength(40)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nome_mesa");
            entity.Property(e => e.NumeroMesa).HasColumnName("numero_mesa");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("status");
        });

        modelBuilder.Entity<ModeloAutomovel>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("modelo_automovel_pkey");

            entity.ToTable("modelo_automovel");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_md_automovel_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.CdMarca).HasColumnName("cd_marca");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");

            entity.HasOne(d => d.CdMarcaNavigation).WithMany(p => p.ModeloAutomovels)
                .HasForeignKey(d => d.CdMarca)
                .HasConstraintName("modelo_automovel_fk");
        });

        modelBuilder.Entity<ModeloVeicProduto>(entity =>
        {
            entity.HasKey(e => new { e.CdProduto, e.CdMarca, e.CdModelo }).HasName("modelo_veic_produto_pkey");

            entity.ToTable("modelo_veic_produto");

            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdMarca).HasColumnName("cd_marca");
            entity.Property(e => e.CdModelo).HasColumnName("cd_modelo");

            entity.HasOne(d => d.CdMarcaNavigation).WithMany(p => p.ModeloVeicProdutos)
                .HasForeignKey(d => d.CdMarca)
                .HasConstraintName("modelo_veic_produto_fk2");

            entity.HasOne(d => d.CdModeloNavigation).WithMany(p => p.ModeloVeicProdutos)
                .HasForeignKey(d => d.CdModelo)
                .HasConstraintName("modelo_veic_produto_fk1");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ModeloVeicProdutos)
                .HasForeignKey(d => d.CdProduto)
                .HasConstraintName("modelo_veic_produto_fk");
        });

        modelBuilder.Entity<Modulo>(entity =>
        {
            entity.HasKey(e => e.CdModulo).HasName("modulo_pkey");

            entity.ToTable("modulo");

            entity.Property(e => e.CdModulo)
                .HasMaxLength(4)
                .HasColumnName("cd_modulo");
            entity.Property(e => e.NmModulo)
                .HasMaxLength(62)
                .HasColumnName("nm_modulo");
        });

        modelBuilder.Entity<MrepNfceVr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mrep_nfce_vr");

            entity.Property(e => e.CancItem)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("canc_item");
            entity.Property(e => e.CancVenda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("canc_venda");
            entity.Property(e => e.Desc)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("desc");
            entity.Property(e => e.Usr).HasColumnName("usr");
            entity.Property(e => e.VlItem)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("vl_item");

            entity.HasOne(d => d.UsrNavigation).WithMany()
                .HasPrincipalKey(p => p.Id)
                .HasForeignKey(d => d.Usr)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("mrep_nfce_fk");
        });

        modelBuilder.Entity<Ncm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ncm_pkey");

            entity.ToTable("ncm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .HasColumnName("descricao");
            entity.Property(e => e.DtVigencia).HasColumnName("dt_vigencia");
            entity.Property(e => e.Ncm1)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.Unidade)
                .HasMaxLength(10)
                .HasColumnName("unidade");
        });

        modelBuilder.Entity<NcmProtocoloEstado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ncm_protocolo_estado_pkey");

            entity.ToTable("ncm_protocolo_estado");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCabProtocolo).HasColumnName("id_cab_protocolo");
            entity.Property(e => e.IdNcm)
                .HasMaxLength(8)
                .HasColumnName("id_ncm");

            entity.HasOne(d => d.IdCabProtocoloNavigation).WithMany(p => p.NcmProtocoloEstados)
                .HasForeignKey(d => d.IdCabProtocolo)
                .HasConstraintName("ncm_protocolo_estado_fk");
        });

        modelBuilder.Entity<NfceAberturaCaixa>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("nfce_abertura_caixa_pkey");

            entity.ToTable("nfce_abertura_caixa");

            entity.Property(e => e.NrLanc).HasColumnName("nr_lanc");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdGerente)
                .HasMaxLength(62)
                .HasColumnName("cd_gerente");
            entity.Property(e => e.CdOperador)
                .HasMaxLength(62)
                .HasColumnName("cd_operador");
            entity.Property(e => e.DataAbertura).HasColumnName("data_abertura");
            entity.Property(e => e.DataEncerramento).HasColumnName("data_encerramento");
            entity.Property(e => e.DataLanc)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_lanc");
            entity.Property(e => e.HoraAbertura).HasColumnName("hora_abertura");
            entity.Property(e => e.HoraEncerramento).HasColumnName("hora_encerramento");
            entity.Property(e => e.Status)
                .HasMaxLength(4)
                .HasColumnName("status");
            entity.Property(e => e.VlMoedas)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_moedas");
            entity.Property(e => e.VlSangria)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_sangria");
            entity.Property(e => e.VlSuprimento)
                .HasPrecision(18, 4)
                .HasColumnName("vl_suprimento");
            entity.Property(e => e.VlVendaFinal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final");
            entity.Property(e => e.VlVendaFinalCart)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_cart");
            entity.Property(e => e.VlVendaFinalCartDeb)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_cart_deb");
            entity.Property(e => e.VlVendaFinalChq)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_chq");
            entity.Property(e => e.VlVendaFinalPix)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_pix");
            entity.Property(e => e.VlVendaFinalPrazo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_final_prazo");
            entity.Property(e => e.VlVendaTicket)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_venda_ticket");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.NfceAberturaCaixas)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("nfce_abertura_caixa_fk");
        });

        modelBuilder.Entity<NfceCartaoBandeira>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nfce_cartao_bandeira");

            entity.Property(e => e.Descricao)
                .HasMaxLength(30)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<NfceCartaoEmpresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nfce_cartao_empresa");

            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Descricao)
                .HasMaxLength(60)
                .HasColumnName("descricao");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<NfceFormaPgt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nfce_forma_pgt");

            entity.Property(e => e.Bandeira)
                .HasMaxLength(30)
                .HasColumnName("bandeira");
            entity.Property(e => e.Caixa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("caixa");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Forma)
                .HasMaxLength(30)
                .HasColumnName("forma");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdSaida).HasColumnName("id_saida");
            entity.Property(e => e.NrAberturaCaixa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_abertura_caixa");
            entity.Property(e => e.Nsu)
                .HasMaxLength(20)
                .HasColumnName("nsu");
            entity.Property(e => e.Troco)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("troco");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<NfceLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nfce_log");

            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Evento)
                .HasMaxLength(512)
                .HasColumnName("evento");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Nfce).HasColumnName("nfce");
            entity.Property(e => e.Serie).HasColumnName("serie");
        });

        modelBuilder.Entity<NfceProdutoSaidum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("nfce_produto_saida_pkey");

            entity.ToTable("nfce_produto_saida");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cancelou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cancelou");
            entity.Property(e => e.CdContSocialApCofins)
                .HasMaxLength(4)
                .HasColumnName("cd_cont_social_ap_cofins");
            entity.Property(e => e.CdContSocialApPis)
                .HasMaxLength(4)
                .HasColumnName("cd_cont_social_ap_pis");
            entity.Property(e => e.CdCsosn)
                .HasMaxLength(10)
                .HasColumnName("cd_csosn");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdEnquadraIpi)
                .HasMaxLength(4)
                .HasColumnName("cd_enquadra_ipi");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_interno");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdSeloIpi)
                .HasMaxLength(4)
                .HasColumnName("cd_selo_ipi");
            entity.Property(e => e.CdTipSt)
                .HasMaxLength(2)
                .HasColumnName("cd_tip_st");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasColumnName("cest");
            entity.Property(e => e.Cfop)
                .HasMaxLength(6)
                .HasColumnName("cfop");
            entity.Property(e => e.CnpjProd)
                .HasMaxLength(18)
                .HasColumnName("cnpj_prod");
            entity.Property(e => e.Cst)
                .HasMaxLength(6)
                .HasColumnName("cst");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(6)
                .HasDefaultValueSql("0")
                .HasColumnName("cst_cofins");
            entity.Property(e => e.CstPis)
                .HasMaxLength(6)
                .HasDefaultValueSql("0")
                .HasColumnName("cst_pis");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.EOrOs)
                .HasMaxLength(1)
                .HasColumnName("e_or_os");
            entity.Property(e => e.IcmsSubstituto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_substituto");
            entity.Property(e => e.IdSaida).HasColumnName("id_saida");
            entity.Property(e => e.IpiClasEnqua)
                .HasMaxLength(4)
                .HasColumnName("ipi_clas_enqua");
            entity.Property(e => e.IpiSiTribut)
                .HasMaxLength(4)
                .HasColumnName("ipi_si_tribut");
            entity.Property(e => e.Lote)
                .HasMaxLength(16635)
                .HasColumnName("lote");
            entity.Property(e => e.MvaSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("mva_st");
            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.NrItem).HasColumnName("nr_item");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.PcreditoIcms)
                .HasPrecision(18, 2)
                .HasColumnName("pcredito_icms");
            entity.Property(e => e.Pfcpufdest)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("pfcpufdest");
            entity.Property(e => e.Picmsinter)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsinter");
            entity.Property(e => e.Picmsinterpart)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsinterpart");
            entity.Property(e => e.Picmsufdest)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsufdest");
            entity.Property(e => e.PocIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("poc_icms");
            entity.Property(e => e.PocReducao)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("poc_reducao");
            entity.Property(e => e.PorcCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_cofins");
            entity.Property(e => e.PorcCofinsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_cofins_st");
            entity.Property(e => e.PorcIbpt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ibpt");
            entity.Property(e => e.PorcIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ipi");
            entity.Property(e => e.PorcPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_pis");
            entity.Property(e => e.PorcPisSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_pis_st");
            entity.Property(e => e.PorcSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_st");
            entity.Property(e => e.QtTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("qt_total");
            entity.Property(e => e.QtdeSeloIpi).HasColumnName("qtde_selo_ipi");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("quant");
            entity.Property(e => e.QuantEstorno)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_estorno");
            entity.Property(e => e.SequenciaItem)
                .HasDefaultValueSql("0")
                .HasColumnName("sequencia_item");
            entity.Property(e => e.St)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("st");
            entity.Property(e => e.Un)
                .HasMaxLength(4)
                .HasDefaultValueSql("'UN'::character varying")
                .HasColumnName("un");
            entity.Property(e => e.Vbcfcpufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vbcfcpufdest");
            entity.Property(e => e.Vbcufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vbcufdest");
            entity.Property(e => e.Vfcpufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vfcpufdest");
            entity.Property(e => e.Vicmsufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vicmsufdest");
            entity.Property(e => e.Vicmsufremt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vicmsufremt");
            entity.Property(e => e.VlAproxImposto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_aprox_imposto");
            entity.Property(e => e.VlBaseCofins)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_cofins");
            entity.Property(e => e.VlBaseCofinsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_cofins_st");
            entity.Property(e => e.VlBaseIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_icms");
            entity.Property(e => e.VlBaseIpi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_ipi");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_pis");
            entity.Property(e => e.VlBasePisSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_pis_st");
            entity.Property(e => e.VlBaseRetido)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_retido");
            entity.Property(e => e.VlBaseSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_st");
            entity.Property(e => e.VlCofins)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cofins");
            entity.Property(e => e.VlCofinsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cofins_st");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comissao");
            entity.Property(e => e.VlCreditoIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_credito_icms");
            entity.Property(e => e.VlCusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsRet)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms_ret");
            entity.Property(e => e.VlIpi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_ipi");
            entity.Property(e => e.VlPis)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pis");
            entity.Property(e => e.VlPisSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pis_st");
            entity.Property(e => e.VlSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_st");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnid)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_unid");
            entity.Property(e => e.VlVenda)
                .HasPrecision(18, 4)
                .HasColumnName("vl_venda");

            entity.HasOne(d => d.IdSaidaNavigation).WithMany(p => p.NfceProdutoSaida)
                .HasForeignKey(d => d.IdSaida)
                .HasConstraintName("nfce_produto_saida_fk");
        });

        modelBuilder.Entity<NfceSaida>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("nfce_saidas_pkey");

            entity.ToTable("nfce_saidas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alterado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("alterado");
            entity.Property(e => e.Caixa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("caixa");
            entity.Property(e => e.CdCarga)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_carga");
            entity.Property(e => e.CdSituacao)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("cd_situacao");
            entity.Property(e => e.CdUf)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_uf");
            entity.Property(e => e.CdVendedor)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_vendedor");
            entity.Property(e => e.Cfop)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfop");
            entity.Property(e => e.ChaveAcessoNfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_acesso_nfe");
            entity.Property(e => e.ChaveNfeSaida)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_nfe_saida");
            entity.Property(e => e.Cliente).HasColumnName("cliente");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.Delivery)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("delivery");
            entity.Property(e => e.DescontoClassificacao)
                .HasMaxLength(1)
                .HasColumnName("desconto_classificacao");
            entity.Property(e => e.DtCirugia).HasColumnName("dt_cirugia");
            entity.Property(e => e.DtPagouComis).HasColumnName("dt_pagou_comis");
            entity.Property(e => e.DtPedido).HasColumnName("dt_pedido");
            entity.Property(e => e.DtSaida).HasColumnName("dt_saida");
            entity.Property(e => e.Empresa).HasColumnName("empresa");
            entity.Property(e => e.Frete)
                .HasPrecision(8, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("frete");
            entity.Property(e => e.HrSaida)
                .HasPrecision(0)
                .HasColumnName("hr_saida");
            entity.Property(e => e.IdConvenio)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_convenio");
            entity.Property(e => e.IdMedico)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_medico");
            entity.Property(e => e.IdPaciente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_paciente");
            entity.Property(e => e.IdPontoVenda)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_ponto_venda");
            entity.Property(e => e.LocalSalvoNota)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("local_salvo_nota");
            entity.Property(e => e.NmOperador)
                .HasMaxLength(40)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_operador");
            entity.Property(e => e.NmVendedor)
                .HasMaxLength(64)
                .HasColumnName("nm_vendedor");
            entity.Property(e => e.NrAberturaCaixa)
                .HasMaxLength(16)
                .HasColumnName("nr_abertura_caixa");
            entity.Property(e => e.NrAutorizacaoNfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_autorizacao_nfe");
            entity.Property(e => e.NrCnf).HasColumnName("nr_cnf");
            entity.Property(e => e.NrNotaFiscal)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_nota_fiscal");
            entity.Property(e => e.NrProtoCancelamento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_proto_cancelamento");
            entity.Property(e => e.NrProtocoloInutilizacao)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_protocolo_inutilizacao");
            entity.Property(e => e.Observacao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("observacao");
            entity.Property(e => e.PagaComissao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("paga_comissao");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.Requisicao)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("requisicao");
            entity.Property(e => e.Serie).HasColumnName("serie");
            entity.Property(e => e.TabelaVenda)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tabela_venda");
            entity.Property(e => e.TpPagt)
                .HasMaxLength(1)
                .HasColumnName("tp_pagt");
            entity.Property(e => e.TpSaida)
                .HasMaxLength(2)
                .HasColumnName("tp_saida");
            entity.Property(e => e.TxtJustificativaCancelamento)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_justificativa_cancelamento");
            entity.Property(e => e.TxtObsNf)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs_nf");
            entity.Property(e => e.VlDescGlobal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desc_global");
            entity.Property(e => e.VlDescontoClassificacao)
                .HasPrecision(18, 2)
                .HasColumnName("vl_desconto_classificacao");
            entity.Property(e => e.VlOutro)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_outro");
            entity.Property(e => e.XmNf)
                .HasDefaultValueSql("''::text")
                .HasColumnName("xm_nf");
        });

        modelBuilder.Entity<NfeCartaCorrecao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nfe_carta_correcao");

            entity.Property(e => e.Chave)
                .HasMaxLength(44)
                .HasColumnName("chave");
            entity.Property(e => e.Cnpj)
                .HasMaxLength(20)
                .HasColumnName("cnpj");
            entity.Property(e => e.Correcao)
                .HasMaxLength(256)
                .HasColumnName("correcao");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Lote)
                .HasMaxLength(10)
                .HasColumnName("lote");
            entity.Property(e => e.Nfe)
                .HasMaxLength(12)
                .HasColumnName("nfe");
            entity.Property(e => e.Numerosequencia)
                .HasMaxLength(3)
                .HasColumnName("numerosequencia");
            entity.Property(e => e.Protocolo)
                .HasMaxLength(50)
                .HasColumnName("protocolo");
        });

        modelBuilder.Entity<NfeInulizada>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("nfe_inulizadas_pkey");

            entity.ToTable("nfe_inulizadas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ano)
                .HasMaxLength(4)
                .HasColumnName("ano");
            entity.Property(e => e.DataInutilizacao).HasColumnName("data_inutilizacao");
            entity.Property(e => e.Justificativa)
                .HasMaxLength(512)
                .HasColumnName("justificativa");
            entity.Property(e => e.Modelo)
                .HasMaxLength(4)
                .HasColumnName("modelo");
            entity.Property(e => e.NumeroFim)
                .HasMaxLength(4)
                .HasColumnName("numero_fim");
            entity.Property(e => e.NumeroInicio)
                .HasMaxLength(4)
                .HasColumnName("numero_inicio");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .HasColumnName("serie");
        });

        modelBuilder.Entity<NutricionalProduto>(entity =>
        {
            entity.HasKey(e => e.CdProduto).HasName("nutricional_produto_pkey");

            entity.ToTable("nutricional_produto");

            entity.Property(e => e.CdProduto)
                .ValueGeneratedNever()
                .HasColumnName("cd_produto");
            entity.Property(e => e.Carboidrato)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("carboidrato");
            entity.Property(e => e.Fibra)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("fibra");
            entity.Property(e => e.Gordurasaturada)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("gordurasaturada");
            entity.Property(e => e.Gorduratotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("gorduratotal");
            entity.Property(e => e.Gorduratrans)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("gorduratrans");
            entity.Property(e => e.MedCaseira).HasColumnName("med_caseira");
            entity.Property(e => e.ParteDecimal).HasColumnName("parte_decimal");
            entity.Property(e => e.Proteina)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("proteina");
            entity.Property(e => e.Qtde)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("qtde");
            entity.Property(e => e.Sodio)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("sodio");
            entity.Property(e => e.TpUnidPorcao).HasColumnName("tp_unid_porcao");
            entity.Property(e => e.Valorenergetico)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valorenergetico");
        });

        modelBuilder.Entity<ObsComandaProduto>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("obs_comanda_produto_pkey");

            entity.ToTable("obs_comanda_produto");

            entity.HasIndex(e => e.NmObs, "obs_comanda_produto_idx");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_obs_com_pro_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Cor)
                .HasMaxLength(20)
                .HasColumnName("cor");
            entity.Property(e => e.IdImp).HasColumnName("id_imp");
            entity.Property(e => e.NmObs)
                .HasMaxLength(150)
                .HasColumnName("nm_obs");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlAcrescimo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_acrescimo");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ObsComandaProdutos)
                .HasForeignKey(d => d.CdProduto)
                .HasConstraintName("obs_comanda_produto_fk");
        });

        modelBuilder.Entity<ObsItemComandum>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("obs_item_comanda_pkey");

            entity.ToTable("obs_item_comanda");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_obs_item_comanda_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdObs).HasColumnName("cd_obs");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.NrComanda).HasColumnName("nr_comanda");
            entity.Property(e => e.NrItemComanda).HasColumnName("nr_item_comanda");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlAcrescimo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_acrescimo");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ObsItemComanda)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("obs_item_comanda_fk1");

            entity.HasOne(d => d.NrComandaNavigation).WithMany(p => p.ObsItemComanda)
                .HasForeignKey(d => d.NrComanda)
                .HasConstraintName("obs_item_comanda_fk");
        });

        modelBuilder.Entity<ObsNf>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("obs_nf_pkey");

            entity.ToTable("obs_nf");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_obs_nf_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.NmObs)
                .HasMaxLength(150)
                .HasColumnName("nm_obs");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
        });

        modelBuilder.Entity<ObsPadraoContasReceber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("obs_padrao_contas_receber_pkey");

            entity.ToTable("obs_padrao_contas_receber");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
        });

        modelBuilder.Entity<OperacaoTerra>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("operacao_terra_pkey");

            entity.ToTable("operacao_terra");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_op_ter_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Orcamento>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("orcamento_pkey");

            entity.ToTable("orcamento");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_orcamento_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.AprovOsDtAvisado).HasColumnName("aprov_os_dt_avisado");
            entity.Property(e => e.AprovOsFunc).HasColumnName("aprov_os_func");
            entity.Property(e => e.AprovOsNmClienteAvisa)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("aprov_os_nm_cliente_avisa");
            entity.Property(e => e.AprovOsStatus)
                .HasMaxLength(4)
                .HasColumnName("aprov_os_status");
            entity.Property(e => e.AtivaAlerta)
                .HasMaxLength(1)
                .HasColumnName("ativa_alerta");
            entity.Property(e => e.AvalTecnicaDtFim).HasColumnName("aval_tecnica_dt_fim");
            entity.Property(e => e.AvalTecnicaDtIniico).HasColumnName("aval_tecnica_dt_iniico");
            entity.Property(e => e.AvalTecnicaResponsavel).HasColumnName("aval_tecnica_responsavel");
            entity.Property(e => e.AvalTecnicaStatus)
                .HasMaxLength(4)
                .HasColumnName("aval_tecnica_status");
            entity.Property(e => e.CdAutomovel).HasColumnName("cd_automovel");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdParceiro).HasColumnName("cd_parceiro");
            entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DataAlerta).HasColumnName("data_alerta");
            entity.Property(e => e.Devolucao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("devolucao");
            entity.Property(e => e.DtCirugia).HasColumnName("dt_cirugia");
            entity.Property(e => e.DtGerouOs).HasColumnName("dt_gerou_os");
            entity.Property(e => e.DtPagParc).HasColumnName("dt_pag_parc");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.EntregEqFunc).HasColumnName("entreg_eq_func");
            entity.Property(e => e.EntregEqRecDtEntreg).HasColumnName("entreg_eq_rec_dt_entreg");
            entity.Property(e => e.EntregEqRecPor)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("entreg_eq_rec_por");
            entity.Property(e => e.GerouOs)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("gerou_os");
            entity.Property(e => e.GerouSaida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("gerou_saida");
            entity.Property(e => e.IdComoAchou)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_como_achou");
            entity.Property(e => e.IdConvenio)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_convenio");
            entity.Property(e => e.IdDepartamento)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_departamento");
            entity.Property(e => e.IdEnderecoEntrega)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_endereco_entrega");
            entity.Property(e => e.IdMedico)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_medico");
            entity.Property(e => e.IdPaciente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_paciente");
            entity.Property(e => e.IdStatusOs)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_status_os");
            entity.Property(e => e.JeitoPagamento)
                .HasMaxLength(1)
                .HasColumnName("jeito_pagamento");
            entity.Property(e => e.KmAtual)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("km_atual");
            entity.Property(e => e.MarcaEquip)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("marca_equip");
            entity.Property(e => e.NmSolicitante)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_solicitante");
            entity.Property(e => e.NrFormaPagt).HasColumnName("nr_forma_pagt");
            entity.Property(e => e.NrInterno)
                .HasMaxLength(15)
                .HasColumnName("nr_interno");
            entity.Property(e => e.NrOrcamentoAnt).HasColumnName("nr_orcamento_ant");
            entity.Property(e => e.ObsFecham)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("obs_fecham");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.QtParcela).HasColumnName("qt_parcela");
            entity.Property(e => e.SituacaoAlerta)
                .HasMaxLength(1)
                .HasColumnName("situacao_alerta");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TpCirugia)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_cirugia");
            entity.Property(e => e.TpEntrada)
                .HasMaxLength(4)
                .HasDefaultValueSql("'B'::character varying")
                .HasColumnName("tp_entrada");
            entity.Property(e => e.TpOrcamento)
                .HasMaxLength(1)
                .HasColumnName("tp_orcamento");
            entity.Property(e => e.TpPagt)
                .HasMaxLength(1)
                .HasColumnName("tp_pagt");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("txt_obs");
            entity.Property(e => e.TxtObsAdicional)
                .HasMaxLength(16384)
                .HasColumnName("txt_obs_adicional");
            entity.Property(e => e.ValorDesconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_desconto");
            entity.Property(e => e.ValorPago)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_pago");
            entity.Property(e => e.ValorRestante)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_restante");
            entity.Property(e => e.ValorTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_total");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comissao");
        });

        modelBuilder.Entity<OrigemCst>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("origem_cst_pkey");

            entity.ToTable("origem_cst");

            entity.Property(e => e.Codigo)
                .HasMaxLength(1)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(256)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<OsDevolucao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("os_devolucao_pkey");

            entity.ToTable("os_devolucao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CdBarra)
                .HasMaxLength(13)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_barra");
            entity.Property(e => e.CdClassFiscal)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_class_fiscal");
            entity.Property(e => e.CdUni)
                .HasMaxLength(4)
                .HasDefaultValueSql("'UN'::character varying")
                .HasColumnName("cd_uni");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.IdItem).HasColumnName("id_item");
            entity.Property(e => e.IdOs).HasColumnName("id_os");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(162)
                .HasColumnName("nm_produto");
            entity.Property(e => e.Qtde)
                .HasPrecision(15, 4)
                .HasColumnName("qtde");
            entity.Property(e => e.QtdeRetorno)
                .HasPrecision(15, 4)
                .HasColumnName("qtde_retorno");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(15, 4)
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlTotal)
                .HasPrecision(15, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(15, 4)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.IdOsNavigation).WithMany(p => p.OsDevolucaos)
                .HasForeignKey(d => d.IdOs)
                .HasConstraintName("os_devolucao_fk");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("paciente_pkey");

            entity.ToTable("paciente");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtNascimento)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_nascimento");
            entity.Property(e => e.IdInterno)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_interno");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<PagtosParciaisCr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pagtos_parciais_cr_pkey");

            entity.ToTable("pagtos_parciais_cr");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtPagto).HasColumnName("dt_pagto");
            entity.Property(e => e.NrConta).HasColumnName("nr_conta");
            entity.Property(e => e.ValorPago)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_pago");
            entity.Property(e => e.ValorRestante)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_restante");
        });

        modelBuilder.Entity<Parceiro>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("parceiros_pkey");

            entity.ToTable("parceiros");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_parceiros_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.Bairro)
                .HasMaxLength(62)
                .HasColumnName("bairro");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.Celular)
                .HasMaxLength(15)
                .HasColumnName("celular");
            entity.Property(e => e.Cep)
                .HasMaxLength(9)
                .HasColumnName("cep");
            entity.Property(e => e.CnpjCpf)
                .HasMaxLength(18)
                .HasColumnName("cnpj_cpf");
            entity.Property(e => e.DiaPagt)
                .HasMaxLength(2)
                .HasColumnName("dia_pagt");
            entity.Property(e => e.DtCadastro)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_cadastro");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.NumeroAgencia)
                .HasMaxLength(10)
                .HasColumnName("numero_agencia");
            entity.Property(e => e.NumeroBanco)
                .HasMaxLength(10)
                .HasColumnName("numero_banco");
            entity.Property(e => e.NumeroConta)
                .HasMaxLength(15)
                .HasColumnName("numero_conta");
            entity.Property(e => e.Telefone)
                .HasMaxLength(15)
                .HasColumnName("telefone");

            entity.HasOne(d => d.CdCidadeNavigation).WithMany(p => p.Parceiros)
                .HasForeignKey(d => d.CdCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("parceiros_fk");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("pedidos_pkey");

            entity.ToTable("pedidos", "mobile");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DtVenda).HasColumnName("dt_venda");
            entity.Property(e => e.Enviou)
                .HasMaxLength(1)
                .HasColumnName("enviou");
            entity.Property(e => e.Fechou)
                .HasMaxLength(1)
                .HasColumnName("fechou");
            entity.Property(e => e.HrVenda).HasColumnName("hr_venda");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdFormaPagt).HasColumnName("id_forma_pagt");
            entity.Property(e => e.IdGlobal)
                .HasComment("id do cliente")
                .HasColumnName("id_global");
            entity.Property(e => e.IdMobile).HasColumnName("id_mobile");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.Qtde)
                .HasPrecision(18, 2)
                .HasColumnName("qtde");
            entity.Property(e => e.TipoValor).HasColumnName("tipo_valor");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasColumnName("txt_obs");
            entity.Property(e => e.TxtObsProduto)
                .HasMaxLength(16384)
                .HasColumnName("txt_obs_produto");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 2)
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlDescontoGeral)
                .HasPrecision(18, 2)
                .HasColumnName("vl_desconto_geral");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 2)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 2)
                .HasColumnName("vl_unitario");
        });

        modelBuilder.Entity<PerdaMedControlado>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("perda_med_controlados_pkey");

            entity.ToTable("perda_med_controlados");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_p_med_cont'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdEmrpesa).HasColumnName("cd_emrpesa");
            entity.Property(e => e.CdMotivo).HasColumnName("cd_motivo");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.HrLanc)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_lanc");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasColumnName("quantidade");
            entity.Property(e => e.Unidade)
                .HasMaxLength(4)
                .HasColumnName("unidade");

            entity.HasOne(d => d.CdEmrpesaNavigation).WithMany(p => p.PerdaMedControlados)
                .HasForeignKey(d => d.CdEmrpesa)
                .HasConstraintName("perda_med_controlados_fk");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.PerdaMedControlados)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("perda_med_controlados_fk1");
        });

        modelBuilder.Entity<PlanoDeCaixa>(entity =>
        {
            entity.HasKey(e => e.CdClassificacao).HasName("plano_de_caixa_pkey");

            entity.ToTable("plano_de_caixa");

            entity.Property(e => e.CdClassificacao)
                .HasMaxLength(25)
                .HasColumnName("cd_classificacao");
            entity.Property(e => e.Descricao)
                .HasMaxLength(62)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<PlanoEstoque>(entity =>
        {
            entity.HasKey(e => e.CdPlano).HasName("plano_estoque_pkey");

            entity.ToTable("plano_estoque");

            entity.Property(e => e.CdPlano)
                .HasDefaultValueSql("nextval('gen_plano_estoque'::regclass)")
                .HasColumnName("cd_plano");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CdEmpresa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_empresa");
            entity.Property(e => e.NmPlano)
                .HasMaxLength(62)
                .HasColumnName("nm_plano");
        });

        modelBuilder.Entity<PontoVendum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ponto_venda_pkey");

            entity.ToTable("ponto_venda");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.Endereco)
                .HasMaxLength(150)
                .HasColumnName("endereco");
            entity.Property(e => e.IdFuncionario)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_funcionario");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.NmPonto)
                .HasMaxLength(150)
                .HasColumnName("nm_ponto");
            entity.Property(e => e.Numero)
                .HasMaxLength(6)
                .HasDefaultValueSql("'S/N'::character varying")
                .HasColumnName("numero");
            entity.Property(e => e.TpValor)
                .HasMaxLength(1)
                .HasDefaultValueSql("'V'::character varying")
                .HasColumnName("tp_valor");

            entity.HasOne(d => d.CdCidadeNavigation).WithMany(p => p.PontoVenda)
                .HasForeignKey(d => d.CdCidade)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("ponto_venda_fk");

            entity.HasMany(d => d.IdPlanoEstoques).WithMany(p => p.IdPontoVenda)
                .UsingEntity<Dictionary<string, object>>(
                    "PontoVendaXPlanoEstoque",
                    r => r.HasOne<PlanoEstoque>().WithMany()
                        .HasForeignKey("IdPlanoEstoque")
                        .HasConstraintName("ponto_venda_x_plano_estoque_fk1"),
                    l => l.HasOne<PontoVendum>().WithMany()
                        .HasForeignKey("IdPontoVenda")
                        .HasConstraintName("ponto_venda_x_plano_estoque_fk"),
                    j =>
                    {
                        j.HasKey("IdPontoVenda", "IdPlanoEstoque").HasName("ponto_venda_x_plano_estoque_pkey");
                        j.ToTable("ponto_venda_x_plano_estoque");
                        j.IndexerProperty<int>("IdPontoVenda").HasColumnName("id_ponto_venda");
                        j.IndexerProperty<int>("IdPlanoEstoque").HasColumnName("id_plano_estoque");
                    });
        });

        modelBuilder.Entity<PostoAbastecimento>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("posto_abastecimento_pkey");

            entity.ToTable("posto_abastecimento");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_posto_abastecimento_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.VlDiesel)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_diesel");
            entity.Property(e => e.VlEtanol)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_etanol");
            entity.Property(e => e.VlGas)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_gas");
            entity.Property(e => e.VlGasolina)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_gasolina");
        });

        modelBuilder.Entity<PrecoProduto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("preco_produto");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdTabela).HasColumnName("id_tabela");
            entity.Property(e => e.Preco)
                .HasPrecision(18, 4)
                .HasColumnName("preco");

            entity.HasOne(d => d.IdTabelaNavigation).WithMany()
                .HasForeignKey(d => d.IdTabela)
                .HasConstraintName("preco_produto_fk");
        });

        modelBuilder.Entity<ProdAdcAcai>(entity =>
        {
            entity.HasKey(e => e.IdProduto).HasName("prod_adc_acai_pkey");

            entity.ToTable("prod_adc_acai");

            entity.Property(e => e.IdProduto)
                .ValueGeneratedNever()
                .HasColumnName("id_produto");
            entity.Property(e => e.IdTpAdc).HasColumnName("id_tp_adc");
            entity.Property(e => e.Valor)
                .HasPrecision(15, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.IdProdutoNavigation).WithOne(p => p.ProdAdcAcai)
                .HasForeignKey<ProdAdcAcai>(d => d.IdProduto)
                .HasConstraintName("prod_adc_acai_fk");

            entity.HasOne(d => d.IdTpAdcNavigation).WithMany(p => p.ProdAdcAcais)
                .HasForeignKey(d => d.IdTpAdc)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prod_adc_acai_fk1");
        });

        modelBuilder.Entity<ProdAgendaEntrega>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("prod_agenda_entrega_pkey");

            entity.ToTable("prod_agenda_entrega");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_prod_ag_entrega_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdUnidade)
                .HasMaxLength(4)
                .HasDefaultValueSql("'UN'::character varying")
                .HasColumnName("cd_unidade");
            entity.Property(e => e.NrAgendamento).HasColumnName("nr_agendamento");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.NrAgendamentoNavigation).WithMany(p => p.ProdAgendaEntregas)
                .HasForeignKey(d => d.NrAgendamento)
                .HasConstraintName("prod_agenda_entrega_fk");
        });

        modelBuilder.Entity<ProdEntrMatAcabado>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("prod_entr_mat_acabado_pkey");

            entity.ToTable("prod_entr_mat_acabado");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_prod_entr_mat_acabado_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdForn).HasColumnName("cd_forn");
            entity.Property(e => e.CdGrupoEntrada).HasColumnName("cd_grupo_entrada");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtValid).HasColumnName("dt_valid");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transferiu");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.CdGrupoEntradaNavigation).WithMany(p => p.ProdEntrMatAcabados)
                .HasForeignKey(d => d.CdGrupoEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prod_entr_mat_acabado_fk2");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ProdEntrMatAcabados)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("prod_entr_mat_acabado_fk1");
        });

        modelBuilder.Entity<ProdKit>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("prod_kit_pkey");

            entity.ToTable("prod_kit");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_prod_kit_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.NrKit).HasColumnName("nr_kit");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Sequencia)
                .HasDefaultValueSql("1")
                .HasColumnName("sequencia");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ProdKits)
                .HasForeignKey(d => d.CdProduto)
                .HasConstraintName("prod_kit_fk");

            entity.HasOne(d => d.NrKitNavigation).WithMany(p => p.ProdKits)
                .HasForeignKey(d => d.NrKit)
                .HasConstraintName("prod_kit_fk1");
        });

        modelBuilder.Entity<ProdSaidaMatPrima>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("prod_saida_mat_prima_pkey");

            entity.ToTable("prod_saida_mat_prima");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_prod_saida_mat_prima_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtValid).HasColumnName("dt_valid");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasColumnName("transferiu");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnit)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unit");
        });

        modelBuilder.Entity<ProdutoEntradum>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("produto_entrada_pkey");

            entity.ToTable("produto_entrada");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_produto_entrada_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.AnoFabVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ano_fab_veic");
            entity.Property(e => e.AnoVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ano_veic");
            entity.Property(e => e.BIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("b_icms");
            entity.Property(e => e.BaseIpi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("base_ipi");
            entity.Property(e => e.CapcMaxLotVeic)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("capc_max_lot_veic");
            entity.Property(e => e.CapcMaxTracVeic)
                .HasPrecision(12, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("capc_max_trac_veic");
            entity.Property(e => e.CdBarra)
                .HasMaxLength(16)
                .HasColumnName("cd_barra");
            entity.Property(e => e.CdCfop)
                .HasMaxLength(4)
                .HasColumnName("cd_cfop");
            entity.Property(e => e.CdClassFiscal)
                .HasMaxLength(8)
                .HasColumnName("cd_class_fiscal");
            entity.Property(e => e.CdContSocialApCofins)
                .HasMaxLength(4)
                .HasColumnName("cd_cont_social_ap_cofins");
            entity.Property(e => e.CdContSocialApPis)
                .HasMaxLength(4)
                .HasColumnName("cd_cont_social_ap_pis");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdEnquadraIpi)
                .HasMaxLength(2)
                .HasColumnName("cd_enquadra_ipi");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdTipSt)
                .HasMaxLength(2)
                .HasColumnName("cd_tip_st");
            entity.Property(e => e.ChasiVeic)
                .HasMaxLength(17)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chasi_veic");
            entity.Property(e => e.CilindradasVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cilindradas_veic");
            entity.Property(e => e.CodSubTrib)
                .HasMaxLength(6)
                .HasColumnName("cod_sub_trib");
            entity.Property(e => e.CondVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cond_veic");
            entity.Property(e => e.CorVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cor_veic");
            entity.Property(e => e.Cst)
                .HasMaxLength(6)
                .HasColumnName("cst");
            entity.Property(e => e.CstConfins)
                .HasMaxLength(6)
                .HasColumnName("cst_confins");
            entity.Property(e => e.CstIpi)
                .HasMaxLength(6)
                .HasColumnName("cst_ipi");
            entity.Property(e => e.CstPis)
                .HasMaxLength(6)
                .HasColumnName("cst_pis");
            entity.Property(e => e.DescCorVeic)
                .HasMaxLength(40)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desc_cor_veic");
            entity.Property(e => e.DistEixosVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("dist_eixos_veic");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.EspecVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("espec_veic");
            entity.Property(e => e.FcpBase)
                .HasPrecision(18, 2)
                .HasColumnName("fcp_base");
            entity.Property(e => e.FcpPorc)
                .HasPrecision(18, 2)
                .HasColumnName("fcp_porc");
            entity.Property(e => e.FcpValor)
                .HasPrecision(18, 2)
                .HasColumnName("fcp_valor");
            entity.Property(e => e.FreteProduto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("frete_produto");
            entity.Property(e => e.FreteRateio)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("frete_rateio");
            entity.Property(e => e.IdCorVeic)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_cor_veic");
            entity.Property(e => e.IdMarcaVeic)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_marca_veic");
            entity.Property(e => e.IdVinVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_vin_veic");
            entity.Property(e => e.ImpBaseIcmsStRet)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("imp_base_icms_st_ret");
            entity.Property(e => e.ImpBaseStRet)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("imp_base_st_ret");
            entity.Property(e => e.ImpIcmsPropSubs)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("imp_icms_prop_subs");
            entity.Property(e => e.ImpPst)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("imp_pst");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.MovEstoque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("mov_estoque");
            entity.Property(e => e.NrEntrada).HasColumnName("nr_entrada");
            entity.Property(e => e.NrItem).HasColumnName("nr_item");
            entity.Property(e => e.NrMotorVeic)
                .HasMaxLength(21)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_motor_veic");
            entity.Property(e => e.PesoBrutoVeic)
                .HasPrecision(12, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("peso_bruto_veic");
            entity.Property(e => e.PesoLiquidoVeic)
                .HasPrecision(12, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("peso_liquido_veic");
            entity.Property(e => e.PorcCofinsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_cofins_st");
            entity.Property(e => e.PorcConfins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_confins");
            entity.Property(e => e.PorcIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_icms");
            entity.Property(e => e.PorcIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ipi");
            entity.Property(e => e.PorcPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_pis");
            entity.Property(e => e.PorcPisSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_pis_st");
            entity.Property(e => e.PorcSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_st");
            entity.Property(e => e.PotenciaMotorVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("potencia_motor_veic");
            entity.Property(e => e.QtTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_total");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.RestricaoVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("restricao_veic");
            entity.Property(e => e.SerialVeic)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serial_veic");
            entity.Property(e => e.TpCombustVeic)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_combust_veic");
            entity.Property(e => e.TpOperacaoVeic)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("tp_operacao_veic");
            entity.Property(e => e.TpPinturaVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_pintura_veic");
            entity.Property(e => e.TpVeic)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_veic");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transferiu");
            entity.Property(e => e.Unidade)
                .HasMaxLength(4)
                .HasDefaultValueSql("'UN'::character varying")
                .HasColumnName("unidade");
            entity.Property(e => e.VlBaseCofinsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_cofins_st");
            entity.Property(e => e.VlBaseConfins)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_confins");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_pis");
            entity.Property(e => e.VlBasePisSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_pis_st");
            entity.Property(e => e.VlBaseSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_st");
            entity.Property(e => e.VlCofinsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cofins_st");
            entity.Property(e => e.VlConfins)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_confins");
            entity.Property(e => e.VlDespAcess)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desp_acess");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 4)
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms_st");
            entity.Property(e => e.VlIpi)
                .HasPrecision(18, 4)
                .HasColumnName("vl_ipi");
            entity.Property(e => e.VlOutras)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_outras");
            entity.Property(e => e.VlPis)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pis");
            entity.Property(e => e.VlPisSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pis_st");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ProdutoEntrada)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("produto_entrada_fk1");
        });

        modelBuilder.Entity<ProdutoEstoque>(entity =>
        {
            entity.HasKey(e => e.CdProduto).HasName("produto_estoque_pkey");

            entity.ToTable("produto_estoque");

            entity.HasIndex(e => e.NmProduto, "produto_estoque_idx");

            entity.Property(e => e.CdProduto)
                .HasDefaultValueSql("nextval('gen_produto_estoque'::regclass)")
                .HasColumnName("cd_produto");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.Balanca)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("balanca");
            entity.Property(e => e.BandejaGaveta)
                .HasMaxLength(128)
                .HasColumnName("bandeja_gaveta");
            entity.Property(e => e.Capacidade)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("capacidade");
            entity.Property(e => e.CdAnp).HasColumnName("cd_anp");
            entity.Property(e => e.CdBarra)
                .HasMaxLength(14)
                .HasColumnName("cd_barra");
            entity.Property(e => e.CdClassFiscal)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_class_fiscal");
            entity.Property(e => e.CdCsosn)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_csosn");
            entity.Property(e => e.CdGenero)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_genero");
            entity.Property(e => e.CdGrupo).HasColumnName("cd_grupo");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_interno");
            entity.Property(e => e.CdPlanoEst).HasColumnName("cd_plano_est");
            entity.Property(e => e.CdRef).HasColumnName("cd_ref");
            entity.Property(e => e.CdSeq)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_seq");
            entity.Property(e => e.CdTribt).HasColumnName("cd_tribt");
            entity.Property(e => e.CdTribtFe).HasColumnName("cd_tribt_fe");
            entity.Property(e => e.CdUni)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_uni");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cest");
            entity.Property(e => e.CfoDentro)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfo_dentro");
            entity.Property(e => e.CfoFora)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfo_fora");
            entity.Property(e => e.ClasseTerapeutica)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("classe_terapeutica");
            entity.Property(e => e.CodEspecie)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cod_especie");
            entity.Property(e => e.CodMargem)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cod_margem");
            entity.Property(e => e.CodigoBalanca)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("codigo_balanca");
            entity.Property(e => e.CodigoDcb)
                .HasMaxLength(5)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("codigo_dcb");
            entity.Property(e => e.ControlaEstoque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("controla_estoque");
            entity.Property(e => e.Corredor)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("corredor");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_cofins");
            entity.Property(e => e.CstDentro1)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_dentro1");
            entity.Property(e => e.CstDentro2)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_dentro2");
            entity.Property(e => e.CstFora1)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_fora1");
            entity.Property(e => e.CstFora2)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_fora2");
            entity.Property(e => e.CstIpi)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_ipi");
            entity.Property(e => e.CstPis)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cst_pis");
            entity.Property(e => e.DescRef)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desc_ref");
            entity.Property(e => e.DescricaoProduto)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("descricao_produto");
            entity.Property(e => e.DtAtivacao).HasColumnName("dt_ativacao");
            entity.Property(e => e.DtAtivoLivro).HasColumnName("dt_ativo_livro");
            entity.Property(e => e.DtSuspLivro).HasColumnName("dt_susp_livro");
            entity.Property(e => e.DtSuspenso).HasColumnName("dt_suspenso");
            entity.Property(e => e.EcfIcmSt)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ecf_icm_st");
            entity.Property(e => e.Embalagem)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("embalagem");
            entity.Property(e => e.EntBcSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ent_bc_st");
            entity.Property(e => e.EntIcmsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ent_icms_st");
            entity.Property(e => e.EntMva)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ent_mva");
            entity.Property(e => e.EntPorcSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ent_porc_st");
            entity.Property(e => e.EntReducaoBc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("ent_reducao_bc");
            entity.Property(e => e.ExTipi)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ex_tipi");
            entity.Property(e => e.Foto).HasColumnName("foto");
            entity.Property(e => e.Frete)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("frete");
            entity.Property(e => e.HrAtivacao).HasColumnName("hr_ativacao");
            entity.Property(e => e.HrAtivoLivro).HasColumnName("hr_ativo_livro");
            entity.Property(e => e.HrSuspLivro).HasColumnName("hr_susp_livro");
            entity.Property(e => e.HrSuspenso).HasColumnName("hr_suspenso");
            entity.Property(e => e.Iat)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("iat");
            entity.Property(e => e.IcmsDentro)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_dentro");
            entity.Property(e => e.IcmsFora)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_fora");
            entity.Property(e => e.IcmsSubsAliq)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_subs_aliq");
            entity.Property(e => e.IcmsSubsReducao)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_subs_reducao");
            entity.Property(e => e.IcmsSubsReducaoAliq)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_subs_reducao_aliq");
            entity.Property(e => e.IdMarca)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_marca");
            entity.Property(e => e.Ippt)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ippt");
            entity.Property(e => e.LancLivro)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("lanc_livro");
            entity.Property(e => e.LetraCurvaabc)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("letra_curvaabc");
            entity.Property(e => e.Local)
                .HasMaxLength(128)
                .HasColumnName("local");
            entity.Property(e => e.LucroPor)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("lucro_por");
            entity.Property(e => e.Mva)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("mva");
            entity.Property(e => e.Mvaajustado)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("mvaajustado");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.NomeImagem)
                .HasMaxLength(162)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nome_imagem");
            entity.Property(e => e.OperacionalPor)
                .HasPrecision(5, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("operacional_por");
            entity.Property(e => e.PesoBruto)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("peso_bruto");
            entity.Property(e => e.PesoLiquido)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("0")
                .HasColumnName("peso_liquido");
            entity.Property(e => e.PorcAliqInterna)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_aliq_interna");
            entity.Property(e => e.PorcIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ipi");
            entity.Property(e => e.PorcSaida)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_saida");
            entity.Property(e => e.PorcSubst)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_subst");
            entity.Property(e => e.PorcVendaAPrazo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_a_prazo");
            entity.Property(e => e.PorcVendaCc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_cc");
            entity.Property(e => e.PorcVendaCd)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_cd");
            entity.Property(e => e.PorcVendedor)
                .HasPrecision(18, 2)
                .HasColumnName("porc_vendedor");
            entity.Property(e => e.Prateleira)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("prateleira");
            entity.Property(e => e.Principal)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("principal");
            entity.Property(e => e.QtDiasVenc)
                .HasDefaultValueSql("0")
                .HasColumnName("qt_dias_venc");
            entity.Property(e => e.QtTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("qt_total");
            entity.Property(e => e.QtUnitario)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("qt_unitario");
            entity.Property(e => e.QtdeMax)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("qtde_max");
            entity.Property(e => e.QuantMinima)
                .HasPrecision(18, 4)
                .HasColumnName("quant_minima");
            entity.Property(e => e.RegMs)
                .HasMaxLength(13)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("reg_ms");
            entity.Property(e => e.StEcf)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("st_ecf");
            entity.Property(e => e.Suspenso)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("suspenso");
            entity.Property(e => e.TaxaCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("taxa_cofins");
            entity.Property(e => e.TaxaIssqn)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("taxa_issqn");
            entity.Property(e => e.TaxaPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("taxa_pis");
            entity.Property(e => e.TipoItemSped)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tipo_item_sped");
            entity.Property(e => e.TotalizadorParcial)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("totalizador_parcial");
            entity.Property(e => e.TpCdBalanca).HasColumnName("tp_cd_balanca");
            entity.Property(e => e.TpItem)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_item");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transferiu");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlAVista)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_a_vista");
            entity.Property(e => e.VlAtacado)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_atacado");
            entity.Property(e => e.VlCc)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cc");
            entity.Property(e => e.VlComanda)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comanda");
            entity.Property(e => e.VlCusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo");
            entity.Property(e => e.VlCustoVariavel)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo_variavel");
            entity.Property(e => e.VlDeb)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_deb");
            entity.Property(e => e.VlMedia)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_media");
            entity.Property(e => e.VlPequena)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pequena");
            entity.Property(e => e.VlPrazo)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_prazo");
            entity.Property(e => e.VlTabelaGov)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_tabela_gov");

            entity.HasOne(d => d.CdGrupoNavigation).WithMany(p => p.ProdutoEstoques)
                .HasForeignKey(d => d.CdGrupo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("produto_estoque_fk");

            entity.HasOne(d => d.CdRefNavigation).WithMany(p => p.ProdutoEstoques)
                .HasForeignKey(d => d.CdRef)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("produto_estoque_fk1");

            entity.HasMany(d => d.CdProduto1s).WithMany(p => p.CdProduto2s)
                .UsingEntity<Dictionary<string, object>>(
                    "ProdutosMesmoCodigo",
                    r => r.HasOne<ProdutoEstoque>().WithMany()
                        .HasForeignKey("CdProduto1")
                        .HasConstraintName("produtos_mesmo_codigo_fk"),
                    l => l.HasOne<ProdutoEstoque>().WithMany()
                        .HasForeignKey("CdProduto2")
                        .HasConstraintName("produtos_mesmo_codigo_fk1"),
                    j =>
                    {
                        j.HasKey("CdProduto1", "CdProduto2").HasName("produtos_mesmo_codigo_pkey");
                        j.ToTable("produtos_mesmo_codigo");
                        j.IndexerProperty<int>("CdProduto1").HasColumnName("cd_produto_1");
                        j.IndexerProperty<int>("CdProduto2").HasColumnName("cd_produto_2");
                    });

            entity.HasMany(d => d.CdProduto2s).WithMany(p => p.CdProduto1s)
                .UsingEntity<Dictionary<string, object>>(
                    "ProdutosMesmoCodigo",
                    r => r.HasOne<ProdutoEstoque>().WithMany()
                        .HasForeignKey("CdProduto2")
                        .HasConstraintName("produtos_mesmo_codigo_fk1"),
                    l => l.HasOne<ProdutoEstoque>().WithMany()
                        .HasForeignKey("CdProduto1")
                        .HasConstraintName("produtos_mesmo_codigo_fk"),
                    j =>
                    {
                        j.HasKey("CdProduto1", "CdProduto2").HasName("produtos_mesmo_codigo_pkey");
                        j.ToTable("produtos_mesmo_codigo");
                        j.IndexerProperty<int>("CdProduto1").HasColumnName("cd_produto_1");
                        j.IndexerProperty<int>("CdProduto2").HasColumnName("cd_produto_2");
                    });
        });

        modelBuilder.Entity<ProdutoSaidum>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("produto_saida_pkey");

            entity.ToTable("produto_saida");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_produto_saida_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.AnoFabVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ano_fab_veic");
            entity.Property(e => e.AnoVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("ano_veic");
            entity.Property(e => e.BaixaEstoque)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("baixa_estoque");
            entity.Property(e => e.Cancelou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cancelou");
            entity.Property(e => e.CapcMaxLotVeic)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("capc_max_lot_veic");
            entity.Property(e => e.CapcMaxTracVeic)
                .HasPrecision(12, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("capc_max_trac_veic");
            entity.Property(e => e.CdContSocialApCofins)
                .HasMaxLength(4)
                .HasColumnName("cd_cont_social_ap_cofins");
            entity.Property(e => e.CdContSocialApPis)
                .HasMaxLength(4)
                .HasColumnName("cd_cont_social_ap_pis");
            entity.Property(e => e.CdCsosn)
                .HasMaxLength(10)
                .HasColumnName("cd_csosn");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdEnquadraIpi)
                .HasMaxLength(4)
                .HasColumnName("cd_enquadra_ipi");
            entity.Property(e => e.CdInterno)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_interno");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdSeloIpi)
                .HasMaxLength(4)
                .HasColumnName("cd_selo_ipi");
            entity.Property(e => e.CdTipSt)
                .HasMaxLength(2)
                .HasColumnName("cd_tip_st");
            entity.Property(e => e.Cest)
                .HasMaxLength(7)
                .HasColumnName("cest");
            entity.Property(e => e.Cfop)
                .HasMaxLength(6)
                .HasColumnName("cfop");
            entity.Property(e => e.ChasiVeic)
                .HasMaxLength(17)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chasi_veic");
            entity.Property(e => e.CilindradasVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cilindradas_veic");
            entity.Property(e => e.CnpjProd)
                .HasMaxLength(18)
                .HasColumnName("cnpj_prod");
            entity.Property(e => e.CondVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cond_veic");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.CorVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cor_veic");
            entity.Property(e => e.Cst)
                .HasMaxLength(6)
                .HasColumnName("cst");
            entity.Property(e => e.CstCofins)
                .HasMaxLength(6)
                .HasDefaultValueSql("0")
                .HasColumnName("cst_cofins");
            entity.Property(e => e.CstPis)
                .HasMaxLength(6)
                .HasDefaultValueSql("0")
                .HasColumnName("cst_pis");
            entity.Property(e => e.DescComplementoNome)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desc_complemento_nome");
            entity.Property(e => e.DescCorVeic)
                .HasMaxLength(40)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("desc_cor_veic");
            entity.Property(e => e.DescRateio)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desc_rateio");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 4)
                .HasColumnName("desconto");
            entity.Property(e => e.DistEixosVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("dist_eixos_veic");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.EOrOs)
                .HasMaxLength(1)
                .HasColumnName("e_or_os");
            entity.Property(e => e.EspecVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("espec_veic");
            entity.Property(e => e.IcmsSubstituto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("icms_substituto");
            entity.Property(e => e.IdCorVeic)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_cor_veic");
            entity.Property(e => e.IdMarcaVeic)
                .HasMaxLength(6)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_marca_veic");
            entity.Property(e => e.IdSerieKit)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_serie_kit");
            entity.Property(e => e.IdSerieProduto)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_serie_produto");
            entity.Property(e => e.IdVinVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_vin_veic");
            entity.Property(e => e.IpiClasEnqua)
                .HasMaxLength(4)
                .HasColumnName("ipi_clas_enqua");
            entity.Property(e => e.IpiSiTribut)
                .HasMaxLength(4)
                .HasColumnName("ipi_si_tribut");
            entity.Property(e => e.ItemPedido)
                .HasMaxLength(20)
                .HasColumnName("item_pedido");
            entity.Property(e => e.Lote)
                .HasMaxLength(16635)
                .HasColumnName("lote");
            entity.Property(e => e.MvaSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("mva_st");
            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.NrItem).HasColumnName("nr_item");
            entity.Property(e => e.NrMotorVeic)
                .HasMaxLength(21)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_motor_veic");
            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.PcreditoIcms)
                .HasPrecision(18, 2)
                .HasColumnName("pcredito_icms");
            entity.Property(e => e.Pedido)
                .HasMaxLength(20)
                .HasColumnName("pedido");
            entity.Property(e => e.PesoBrutoVeic)
                .HasPrecision(12, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("peso_bruto_veic");
            entity.Property(e => e.PesoLiquidoVeic)
                .HasPrecision(12, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("peso_liquido_veic");
            entity.Property(e => e.Pfcpufdest)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("pfcpufdest");
            entity.Property(e => e.Picmsinter)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsinter");
            entity.Property(e => e.Picmsinterpart)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsinterpart");
            entity.Property(e => e.Picmsufdest)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("picmsufdest");
            entity.Property(e => e.PocIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("poc_icms");
            entity.Property(e => e.PocReducao)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("poc_reducao");
            entity.Property(e => e.PorcCofins)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_cofins");
            entity.Property(e => e.PorcCofinsSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_cofins_st");
            entity.Property(e => e.PorcDesc)
                .HasPrecision(18, 2)
                .HasColumnName("porc_desc");
            entity.Property(e => e.PorcIbpt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ibpt");
            entity.Property(e => e.PorcIpi)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_ipi");
            entity.Property(e => e.PorcPis)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_pis");
            entity.Property(e => e.PorcPisSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_pis_st");
            entity.Property(e => e.PorcSt)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_st");
            entity.Property(e => e.PotenciaMotorVeic)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("potencia_motor_veic");
            entity.Property(e => e.QtTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("qt_total");
            entity.Property(e => e.QtdeSeloIpi).HasColumnName("qtde_selo_ipi");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("quant");
            entity.Property(e => e.QuantDevolvido)
                .HasPrecision(18, 4)
                .HasColumnName("quant_devolvido");
            entity.Property(e => e.QuantEntregue)
                .HasPrecision(18, 4)
                .HasColumnName("quant_entregue");
            entity.Property(e => e.QuantEstorno)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_estorno");
            entity.Property(e => e.RestricaoVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("restricao_veic");
            entity.Property(e => e.SequenciaItem)
                .HasDefaultValueSql("0")
                .HasColumnName("sequencia_item");
            entity.Property(e => e.SerialVeic)
                .HasMaxLength(9)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serial_veic");
            entity.Property(e => e.St)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("st");
            entity.Property(e => e.TpCombustVeic)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_combust_veic");
            entity.Property(e => e.TpOperacaoVeic)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("tp_operacao_veic");
            entity.Property(e => e.TpPinturaVeic)
                .HasMaxLength(1)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_pintura_veic");
            entity.Property(e => e.TpVeic)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tp_veic");
            entity.Property(e => e.Un)
                .HasMaxLength(4)
                .HasDefaultValueSql("'UN'::character varying")
                .HasColumnName("un");
            entity.Property(e => e.UtilizarIdInternoNfe)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("utilizar_id_interno_nfe");
            entity.Property(e => e.Vbcfcpufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vbcfcpufdest");
            entity.Property(e => e.Vbcufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vbcufdest");
            entity.Property(e => e.Vfcpufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vfcpufdest");
            entity.Property(e => e.Vicmsufdest)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vicmsufdest");
            entity.Property(e => e.Vicmsufremt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vicmsufremt");
            entity.Property(e => e.VlAproxImposto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_aprox_imposto");
            entity.Property(e => e.VlBaseCofins)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_cofins");
            entity.Property(e => e.VlBaseCofinsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_cofins_st");
            entity.Property(e => e.VlBaseIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_icms");
            entity.Property(e => e.VlBaseIpi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_ipi");
            entity.Property(e => e.VlBasePis)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_pis");
            entity.Property(e => e.VlBasePisSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_pis_st");
            entity.Property(e => e.VlBaseRetido)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_retido");
            entity.Property(e => e.VlBaseSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_base_st");
            entity.Property(e => e.VlCofins)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cofins");
            entity.Property(e => e.VlCofinsSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_cofins_st");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comissao");
            entity.Property(e => e.VlCreditoIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_credito_icms");
            entity.Property(e => e.VlCusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlIcmsRet)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms_ret");
            entity.Property(e => e.VlIpi)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_ipi");
            entity.Property(e => e.VlPis)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pis");
            entity.Property(e => e.VlPisSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_pis_st");
            entity.Property(e => e.VlSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_st");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnid)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_unid");
            entity.Property(e => e.VlVenda)
                .HasPrecision(18, 4)
                .HasColumnName("vl_venda");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.ProdutoSaida)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("produto_saida_fk1");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ProdutoSaida)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("produto_saida_fk");

            entity.HasOne(d => d.NrSaidaNavigation).WithMany(p => p.ProdutoSaida)
                .HasForeignKey(d => d.NrSaida)
                .HasConstraintName("produto_saida_fk2");
        });

        modelBuilder.Entity<ProdutoTransferencium>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("produto_transferencia_pkey");

            entity.ToTable("produto_transferencia");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_prod_transf_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtValid).HasColumnName("dt_valid");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.NrTransf).HasColumnName("nr_transf");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.QuantRetorno)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_retorno");
            entity.Property(e => e.QuantVendido)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_vendido");
            entity.Property(e => e.Tranferiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("tranferiu");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.ProdutoTransferencia)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("produto_transferencia_fk1");

            entity.HasOne(d => d.NrTransfNavigation).WithMany(p => p.ProdutoTransferencia)
                .HasForeignKey(d => d.NrTransf)
                .HasConstraintName("produto_transferencia_fk");
        });

        modelBuilder.Entity<ProdutosForn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("produtos_forn");

            entity.Property(e => e.CdBarra)
                .HasMaxLength(14)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_barra");
            entity.Property(e => e.CdForn).HasColumnName("cd_forn");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.IdProdutoExterno)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("id_produto_externo");

            entity.HasOne(d => d.CdFornNavigation).WithMany()
                .HasForeignKey(d => d.CdForn)
                .HasConstraintName("produtos_forn_fk1");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany()
                .HasForeignKey(d => d.CdProduto)
                .HasConstraintName("produtos_forn_fk");
        });

        modelBuilder.Entity<ProdutosSaidaModelo2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("produtos_saida_modelo2_pkey");

            entity.ToTable("produtos_saida_modelo2");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_produtos_saida_modelo2_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.AliquotaProduto)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquota_produto");
            entity.Property(e => e.BaseCalculoIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("base_calculo_icms");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 2)
                .HasColumnName("desconto");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdSaidaM2).HasColumnName("id_saida_m2");
            entity.Property(e => e.Qtd)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("qtd");
            entity.Property(e => e.VlBrutoProduto)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_bruto_produto");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms");
        });

        modelBuilder.Entity<Projeto>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("projetos_pkey");

            entity.ToTable("projetos");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_projetos_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<ProtocoloEstadoNcm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("protocolo_estado_ncm_pkey");

            entity.ToTable("protocolo_estado_ncm");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.Iva)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("iva");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
            entity.Property(e => e.RedIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("red_icms");
            entity.Property(e => e.RedSt)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("red_st");
            entity.Property(e => e.St)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("st");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasColumnName("txt_obs");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });

        modelBuilder.Entity<QuestAlunoMatricula>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("quest_aluno_matricula_pkey");

            entity.ToTable("quest_aluno_matricula");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AlunoFazAtvFisica)
                .HasMaxLength(16384)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("aluno_faz_atv_fisica");
            entity.Property(e => e.DtAtestado).HasColumnName("dt_atestado");
            entity.Property(e => e.EntregouAtestado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("entregou_atestado");
            entity.Property(e => e.IdAluno).HasColumnName("id_aluno");
            entity.Property(e => e.TxtRestricao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_restricao");

            entity.HasOne(d => d.IdAlunoNavigation).WithMany(p => p.QuestAlunoMatriculas)
                .HasForeignKey(d => d.IdAluno)
                .HasConstraintName("quest_aluno_matricula_fk");
        });

        modelBuilder.Entity<Quitacao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("quitacao_pkey");

            entity.ToTable("quitacao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Codclie)
                .HasMaxLength(30)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("codclie");
            entity.Property(e => e.Compra).HasColumnName("compra");
            entity.Property(e => e.Dataq)
                .HasPrecision(10)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("dataq");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Operador)
                .HasMaxLength(30)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("operador");
            entity.Property(e => e.Quitado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("quitado");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("valor");
            entity.Property(e => e.Valorq)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("valorq");
            entity.Property(e => e.Vencimento).HasColumnName("vencimento");
        });

        modelBuilder.Entity<R01>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("r01_pkey");

            entity.ToTable("r01");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_r01_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.BairroSh)
                .HasMaxLength(40)
                .HasColumnName("bairro_sh");
            entity.Property(e => e.CepSh)
                .HasMaxLength(8)
                .HasColumnName("cep_sh");
            entity.Property(e => e.CidadeSh)
                .HasMaxLength(40)
                .HasColumnName("cidade_sh");
            entity.Property(e => e.CnpjEmpresa)
                .HasMaxLength(14)
                .HasColumnName("cnpj_empresa");
            entity.Property(e => e.CnpjSh)
                .HasMaxLength(14)
                .HasColumnName("cnpj_sh");
            entity.Property(e => e.ComplementoSh)
                .HasMaxLength(40)
                .HasColumnName("complemento_sh");
            entity.Property(e => e.ContatoSh)
                .HasMaxLength(20)
                .HasColumnName("contato_sh");
            entity.Property(e => e.DataFinal).HasColumnName("data_final");
            entity.Property(e => e.DataInicial).HasColumnName("data_inicial");
            entity.Property(e => e.DenominacaoSh)
                .HasMaxLength(40)
                .HasColumnName("denominacao_sh");
            entity.Property(e => e.EnderecoSh)
                .HasMaxLength(40)
                .HasColumnName("endereco_sh");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.IdImpressora).HasColumnName("id_impressora");
            entity.Property(e => e.InscricaoEstadualEmpresa)
                .HasMaxLength(30)
                .HasColumnName("inscricao_estadual_empresa");
            entity.Property(e => e.InscricaoEstadualSh)
                .HasMaxLength(14)
                .HasColumnName("inscricao_estadual_sh");
            entity.Property(e => e.InscricaoMunicipalSh)
                .HasMaxLength(14)
                .HasColumnName("inscricao_municipal_sh");
            entity.Property(e => e.Md5PafEcf)
                .HasMaxLength(32)
                .HasColumnName("md5_paf_ecf");
            entity.Property(e => e.NomePafEcf)
                .HasMaxLength(40)
                .HasColumnName("nome_paf_ecf");
            entity.Property(e => e.NumeroLaudoPaf)
                .HasMaxLength(40)
                .HasColumnName("numero_laudo_paf");
            entity.Property(e => e.NumeroSh)
                .HasMaxLength(10)
                .HasColumnName("numero_sh");
            entity.Property(e => e.PrincipalExecutavel)
                .HasMaxLength(40)
                .HasColumnName("principal_executavel");
            entity.Property(e => e.RazaoSocialSh)
                .HasMaxLength(40)
                .HasColumnName("razao_social_sh");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.ShRamo).HasColumnName("sh_ramo");
            entity.Property(e => e.TelefoneSh)
                .HasMaxLength(10)
                .HasColumnName("telefone_sh");
            entity.Property(e => e.UfSh)
                .HasMaxLength(2)
                .HasColumnName("uf_sh");
            entity.Property(e => e.VersaoEr)
                .HasMaxLength(6)
                .HasColumnName("versao_er");
            entity.Property(e => e.VersaoPafEcf)
                .HasMaxLength(10)
                .HasColumnName("versao_paf_ecf");
        });

        modelBuilder.Entity<R02>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("r02_pkey");

            entity.ToTable("r02");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_r02_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.Cro).HasColumnName("cro");
            entity.Property(e => e.Crz).HasColumnName("crz");
            entity.Property(e => e.Crz1).HasColumnName("crz1");
            entity.Property(e => e.DataEmissao).HasColumnName("data_emissao");
            entity.Property(e => e.DataMovimento).HasColumnName("data_movimento");
            entity.Property(e => e.GrandeTotal)
                .HasPrecision(18, 6)
                .HasColumnName("grande_total");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.HoraEmissao)
                .HasMaxLength(8)
                .HasColumnName("hora_emissao");
            entity.Property(e => e.IdEcfCaixa).HasColumnName("id_ecf_caixa");
            entity.Property(e => e.IdImpressora).HasColumnName("id_impressora");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.Mfd)
                .HasMaxLength(1)
                .HasColumnName("mfd");
            entity.Property(e => e.ParEcf)
                .HasMaxLength(1)
                .HasColumnName("par_ecf");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.VendaBruta)
                .HasPrecision(18, 6)
                .HasColumnName("venda_bruta");
        });

        modelBuilder.Entity<R03>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("r03_pkey");

            entity.ToTable("r03");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_r03_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Crz).HasColumnName("crz");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.IdR02).HasColumnName("id_r02");
            entity.Property(e => e.Mfd)
                .HasMaxLength(1)
                .HasColumnName("mfd");
            entity.Property(e => e.Modelo)
                .HasMaxLength(30)
                .HasColumnName("modelo");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.TotalizadorParcial)
                .HasMaxLength(10)
                .HasColumnName("totalizador_parcial");
            entity.Property(e => e.ValorAcumulado)
                .HasPrecision(18, 6)
                .HasColumnName("valor_acumulado");

            entity.HasOne(d => d.IdR02Navigation).WithMany(p => p.R03s)
                .HasForeignKey(d => d.IdR02)
                .HasConstraintName("r03_fk");
        });

        modelBuilder.Entity<R06>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("r06_pkey");

            entity.ToTable("r06");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_r06_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Cdc).HasColumnName("cdc");
            entity.Property(e => e.Coo).HasColumnName("coo");
            entity.Property(e => e.DataEmissao).HasColumnName("data_emissao");
            entity.Property(e => e.Denominacao)
                .HasMaxLength(2)
                .HasColumnName("denominacao");
            entity.Property(e => e.Gnf).HasColumnName("gnf");
            entity.Property(e => e.Grg).HasColumnName("grg");
            entity.Property(e => e.HashIncremento)
                .HasDefaultValueSql("0")
                .HasColumnName("hash_incremento");
            entity.Property(e => e.HashTripa)
                .HasMaxLength(32)
                .HasColumnName("hash_tripa");
            entity.Property(e => e.HoraEmissao)
                .HasMaxLength(8)
                .HasColumnName("hora_emissao");
            entity.Property(e => e.IdEcfCaixa).HasColumnName("id_ecf_caixa");
            entity.Property(e => e.IdImpressora).HasColumnName("id_impressora");
            entity.Property(e => e.IdOperador).HasColumnName("id_operador");
            entity.Property(e => e.MfAdicional)
                .HasMaxLength(1)
                .HasColumnName("mf_adicional");
            entity.Property(e => e.ModeloEcf)
                .HasMaxLength(30)
                .HasColumnName("modelo_ecf");
            entity.Property(e => e.SerieEcf)
                .HasMaxLength(20)
                .HasColumnName("serie_ecf");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
        });

        modelBuilder.Entity<R07>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("r07_pkey");

            entity.ToTable("r07");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_r07_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Ccf).HasColumnName("ccf");
            entity.Property(e => e.Estorno)
                .HasMaxLength(1)
                .HasColumnName("estorno");
            entity.Property(e => e.IdR06).HasColumnName("id_r06");
            entity.Property(e => e.MeioPagamento)
                .HasMaxLength(20)
                .HasColumnName("meio_pagamento");
            entity.Property(e => e.Sincronizado)
                .HasMaxLength(1)
                .HasColumnName("sincronizado");
            entity.Property(e => e.ValorEstorno)
                .HasPrecision(18, 6)
                .HasColumnName("valor_estorno");
            entity.Property(e => e.ValorPagamento)
                .HasPrecision(18, 6)
                .HasColumnName("valor_pagamento");

            entity.HasOne(d => d.IdR06Navigation).WithMany(p => p.R07s)
                .HasForeignKey(d => d.IdR06)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("r07_fk");
        });

        modelBuilder.Entity<ReceitasPisCofin>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("receitas_pis_cofins_pkey");

            entity.ToTable("receitas_pis_cofins");

            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("codigo");
            entity.Property(e => e.Descricao)
                .HasMaxLength(200)
                .HasColumnName("descricao");
            entity.Property(e => e.Imposto)
                .HasMaxLength(10)
                .HasColumnName("imposto");
            entity.Property(e => e.Periodo)
                .HasMaxLength(10)
                .HasColumnName("periodo");
        });

        modelBuilder.Entity<ReferenciaEstoque>(entity =>
        {
            entity.HasKey(e => e.CdRef).HasName("referencia_estoque_pkey");

            entity.ToTable("referencia_estoque");

            entity.Property(e => e.CdRef)
                .HasDefaultValueSql("nextval('gen_referencia_estoque'::regclass)")
                .HasColumnName("cd_ref");
            entity.Property(e => e.Color)
                .HasMaxLength(15)
                .HasColumnName("color");
            entity.Property(e => e.Controlado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("controlado");
            entity.Property(e => e.NmRef)
                .HasMaxLength(62)
                .HasColumnName("nm_ref");
        });

        modelBuilder.Entity<RelMedicao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("rel_medicao");

            entity.Property(e => e.NrFechamento).HasColumnName("nr_fechamento");
            entity.Property(e => e.Obs)
                .HasMaxLength(256)
                .HasColumnName("obs");
            entity.Property(e => e.Texto)
                .HasMaxLength(16384)
                .HasColumnName("texto");
        });

        modelBuilder.Entity<RetornoWbsPopular>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("retorno_wbs_popular_pkey");

            entity.ToTable("retorno_wbs_popular");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(255)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Saida>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("saidas_pkey");

            entity.ToTable("saidas");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_saidas_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdCarga)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_carga");
            entity.Property(e => e.CdSituacao)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("cd_situacao");
            entity.Property(e => e.CdUf)
                .HasMaxLength(2)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cd_uf");
            entity.Property(e => e.CdVendedor)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_vendedor");
            entity.Property(e => e.Cfop)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cfop");
            entity.Property(e => e.ChaveAcessoNfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_acesso_nfe");
            entity.Property(e => e.ChaveNfeSaida)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("chave_nfe_saida");
            entity.Property(e => e.Cliente).HasColumnName("cliente");
            entity.Property(e => e.CnpjMarket)
                .HasMaxLength(18)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cnpj_market");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DtCirugia).HasColumnName("dt_cirugia");
            entity.Property(e => e.DtPagouComis).HasColumnName("dt_pagou_comis");
            entity.Property(e => e.DtPedido).HasColumnName("dt_pedido");
            entity.Property(e => e.DtSaida).HasColumnName("dt_saida");
            entity.Property(e => e.Empresa).HasColumnName("empresa");
            entity.Property(e => e.HrSaida)
                .HasPrecision(0)
                .HasColumnName("hr_saida");
            entity.Property(e => e.IdConvenio)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_convenio");
            entity.Property(e => e.IdEndEntrega)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_end_entrega");
            entity.Property(e => e.IdEndRetirada)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_end_retirada");
            entity.Property(e => e.IdMedico)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_medico");
            entity.Property(e => e.IdPaciente)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_paciente");
            entity.Property(e => e.IdPontoVenda)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_ponto_venda");
            entity.Property(e => e.IdTabelaPrecos).HasColumnName("id_tabela_precos");
            entity.Property(e => e.IdTipoIndicador)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_tipo_indicador");
            entity.Property(e => e.IdTipoOperacaoIntermediador)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_tipo_operacao_intermediador");
            entity.Property(e => e.LocalSalvoNota)
                .HasMaxLength(256)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("local_salvo_nota");
            entity.Property(e => e.NmMarket)
                .HasMaxLength(162)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nm_market");
            entity.Property(e => e.NrAutorizacaoNfe)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_autorizacao_nfe");
            entity.Property(e => e.NrCnf).HasColumnName("nr_cnf");
            entity.Property(e => e.NrNotaFiscal)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_nota_fiscal");
            entity.Property(e => e.NrProtoCancelamento)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_proto_cancelamento");
            entity.Property(e => e.Observacao)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::text")
                .HasColumnName("observacao");
            entity.Property(e => e.PagaComissao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("paga_comissao");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou");
            entity.Property(e => e.Requisicao)
                .HasMaxLength(10)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("requisicao");
            entity.Property(e => e.SerieNf)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serie_nf");
            entity.Property(e => e.TabelaVenda)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tabela_venda");
            entity.Property(e => e.TpOperacao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("tp_operacao");
            entity.Property(e => e.TpPagt)
                .HasMaxLength(1)
                .HasColumnName("tp_pagt");
            entity.Property(e => e.TpSaida)
                .HasMaxLength(2)
                .HasColumnName("tp_saida");
            entity.Property(e => e.TxtJustificativaCancelamento)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_justificativa_cancelamento");
            entity.Property(e => e.TxtObsNf)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs_nf");
            entity.Property(e => e.VlDescGlobal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desc_global");
            entity.Property(e => e.VlOutro)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_outro");
            entity.Property(e => e.XmNf)
                .HasDefaultValueSql("''::text")
                .HasColumnName("xm_nf");

            entity.HasOne(d => d.ClienteNavigation).WithMany(p => p.Saida)
                .HasForeignKey(d => d.Cliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("saidas_fk1");

            entity.HasOne(d => d.EmpresaNavigation).WithMany(p => p.Saida)
                .HasForeignKey(d => d.Empresa)
                .HasConstraintName("saidas_fk");
        });

        modelBuilder.Entity<SaidaMateriaPrima>(entity =>
        {
            entity.HasKey(e => e.NrSaida).HasName("saida_materia_prima_pkey");

            entity.ToTable("saida_materia_prima");

            entity.Property(e => e.NrSaida)
                .HasDefaultValueSql("nextval('gen_saida_materia_prima_id'::regclass)")
                .HasColumnName("nr_saida");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdGrupo).HasColumnName("cd_grupo");
            entity.Property(e => e.DtSaida)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_saida");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasColumnName("transferiu");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.SaidaMateriaPrimas)
                .HasForeignKey(d => d.CdEmpresa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("saida_materia_prima_fk");
        });

        modelBuilder.Entity<SaidaModelo2>(entity =>
        {
            entity.HasKey(e => e.NrSaida).HasName("saida_modelo2_pkey");

            entity.ToTable("saida_modelo2");

            entity.Property(e => e.NrSaida)
                .HasDefaultValueSql("nextval('gen_saida_modelo2_id'::regclass)")
                .HasColumnName("nr_saida");
            entity.Property(e => e.Aliquota)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("aliquota");
            entity.Property(e => e.BaseCalculoIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("base_calculo_icms");
            entity.Property(e => e.DataEmissao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data_emissao");
            entity.Property(e => e.IsentaNaotributada)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("isenta_naotributada");
            entity.Property(e => e.Modelo)
                .HasMaxLength(10)
                .HasColumnName("modelo");
            entity.Property(e => e.NrFinalOrdem).HasColumnName("nr_final_ordem");
            entity.Property(e => e.NrInicialOrdem).HasColumnName("nr_inicial_ordem");
            entity.Property(e => e.Outras)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("outras");
            entity.Property(e => e.Serie)
                .HasMaxLength(10)
                .HasColumnName("serie");
            entity.Property(e => e.Subserie)
                .HasMaxLength(10)
                .HasColumnName("subserie");
            entity.Property(e => e.VlIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_icms");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_total");
        });

        modelBuilder.Entity<SaidaNotasDevolucao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("saida_notas_devolucao_pkey");

            entity.ToTable("saida_notas_devolucao");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_saida_notas_devolucao_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.NrNfEntradaDevolucao)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_nf_entrada_devolucao");
            entity.Property(e => e.NrNfSaida)
                .HasMaxLength(25)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_nf_saida");
            entity.Property(e => e.TpNota)
                .HasMaxLength(4)
                .HasDefaultValueSql("'E'::character varying")
                .HasColumnName("tp_nota");
        });

        modelBuilder.Entity<SaldoEstoque>(entity =>
        {
            entity.HasKey(e => new { e.CdProduto, e.CdEmpresa, e.CdPlano, e.DtValidade, e.Lote }).HasName("saldo_estoque_pkey");

            entity.ToTable("saldo_estoque");

            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.DtValidade)
                .HasDefaultValueSql("'9999-01-01'::date")
                .HasColumnName("dt_validade");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.Alterado)
                .HasMaxLength(1)
                .HasColumnName("alterado");
            entity.Property(e => e.PeriodoFinal)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("periodo_final");
            entity.Property(e => e.PorcVendaAPrazo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_a_prazo");
            entity.Property(e => e.PorcVendaCc)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_cc");
            entity.Property(e => e.PorcVendaCd)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_cd");
            entity.Property(e => e.PorcVendaVista)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_venda_vista");
            entity.Property(e => e.QuantE)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_e");
            entity.Property(e => e.QuantF)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_f");
            entity.Property(e => e.QuantV)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("quant_v");
            entity.Property(e => e.VlCusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo");
            entity.Property(e => e.VlSaida)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_saida");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.SaldoEstoques)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("saldo_estoque_fk");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.SaldoEstoques)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("saldo_estoque_fk1");
        });

        modelBuilder.Entity<SangriaCaixa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sangria_caixa_pkey");

            entity.ToTable("sangria_caixa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.IdAberturaCaixa).HasColumnName("id_abertura_caixa");
            entity.Property(e => e.IdCaixa).HasColumnName("id_caixa");
            entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
            entity.Property(e => e.Tipo)
                .HasMaxLength(4)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tipo");
            entity.Property(e => e.Valor)
                .HasPrecision(15, 2)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Sangrium>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("sangria_pkey");

            entity.ToTable("sangria");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_sangria_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdOperador).HasColumnName("cd_operador");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.NrCaixa)
                .HasMaxLength(10)
                .HasColumnName("nr_caixa");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<SericoGlobal>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("serico_global_pkey");

            entity.ToTable("serico_global");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_serico_global_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<SerieKitItensOrcamento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("serie_kit_itens_orcamento_pkey");

            entity.ToTable("serie_kit_itens_orcamento");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdKit).HasColumnName("id_kit");
            entity.Property(e => e.IdProdKit).HasColumnName("id_prod_kit");
            entity.Property(e => e.IdProdutoPai).HasColumnName("id_produto_pai");
            entity.Property(e => e.IdSerie)
                .HasMaxLength(62)
                .HasColumnName("id_serie");
            entity.Property(e => e.SerieAcess)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serie_acess");
            entity.Property(e => e.SerieCor)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serie_cor");
            entity.Property(e => e.SeriePrinc)
                .HasMaxLength(62)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("serie_princ");
        });

        modelBuilder.Entity<ServOrcamento>(entity =>
        {
            entity.HasKey(e => e.Nr).HasName("serv_orcamento_pkey");

            entity.ToTable("serv_orcamento");

            entity.Property(e => e.Nr)
                .HasDefaultValueSql("nextval('gen_serv_orcamento_id'::regclass)")
                .HasColumnName("nr");
            entity.Property(e => e.Assessorio)
                .HasMaxLength(162)
                .HasColumnName("assessorio");
            entity.Property(e => e.CdMecanico).HasColumnName("cd_mecanico");
            entity.Property(e => e.CdMecanico2).HasColumnName("cd_mecanico2");
            entity.Property(e => e.CdServico).HasColumnName("cd_servico");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.DtPagouMec).HasColumnName("dt_pagou_mec");
            entity.Property(e => e.IdEquipamento).HasColumnName("id_equipamento");
            entity.Property(e => e.Lado)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("lado");
            entity.Property(e => e.NrOr).HasColumnName("nr_or");
            entity.Property(e => e.PagaComissao)
                .HasMaxLength(1)
                .HasColumnName("paga_comissao");
            entity.Property(e => e.PagouMec)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("pagou_mec");
            entity.Property(e => e.Quant)
                .HasPrecision(7, 2)
                .HasDefaultValueSql("1")
                .HasColumnName("quant");
            entity.Property(e => e.TxtAvalTecnico)
                .HasMaxLength(16384)
                .HasColumnName("txt_aval_tecnico");
            entity.Property(e => e.TxtDivergencia)
                .HasMaxLength(16384)
                .HasColumnName("txt_divergencia");
            entity.Property(e => e.TxtRelatoCliente)
                .HasMaxLength(16384)
                .HasColumnName("txt_relato_cliente");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comissao");
            entity.Property(e => e.VlDesc)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desc");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_total");

            entity.HasOne(d => d.CdServicoNavigation).WithMany(p => p.ServOrcamentos)
                .HasForeignKey(d => d.CdServico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("serv_orcamento_fk1");

            entity.HasOne(d => d.NrOrNavigation).WithMany(p => p.ServOrcamentos)
                .HasForeignKey(d => d.NrOr)
                .HasConstraintName("serv_orcamento_fk");
        });

        modelBuilder.Entity<Servico>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("servicos_pkey");

            entity.ToTable("servicos");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_servicos_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.AparecerRelatorioVenda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("aparecer_relatorio_venda");
            entity.Property(e => e.CdDepartamento).HasColumnName("cd_departamento");
            entity.Property(e => e.CdServicoGlobal).HasColumnName("cd_servico_global");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
            entity.Property(e => e.HrTrabalhadas)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("hr_trabalhadas");
            entity.Property(e => e.PagaComissao)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("paga_comissao");
            entity.Property(e => e.PorcComissaoParceiro)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("porc_comissao_parceiro");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 4)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<SetorFuncionario>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("setor_funcionario_pkey");

            entity.ToTable("setor_funcionario");

            entity.Property(e => e.Codigo)
                .HasDefaultValueSql("nextval('gen_setor_funcionario_id'::regclass)")
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Sintegra60a>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.NumeroSerieEcf }).HasName("pk_sintegra60a");

            entity.ToTable("sintegra_60a");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NumeroSerieEcf)
                .HasMaxLength(20)
                .HasColumnName("numero_serie_ecf");
            entity.Property(e => e.IdSintegra60m).HasColumnName("id_sintegra_60m");
            entity.Property(e => e.SituacaoTributaria)
                .HasMaxLength(4)
                .HasColumnName("situacao_tributaria");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<Sintegra60m>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.NumeroSerieEcf }).HasName("pk_sintegra60m");

            entity.ToTable("sintegra_60m");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NumeroSerieEcf)
                .HasMaxLength(20)
                .HasColumnName("numero_serie_ecf");
            entity.Property(e => e.CooFinal).HasColumnName("coo_final");
            entity.Property(e => e.CooInicial).HasColumnName("coo_inicial");
            entity.Property(e => e.Cro).HasColumnName("cro");
            entity.Property(e => e.Crz).HasColumnName("crz");
            entity.Property(e => e.DataEmissao).HasColumnName("data_emissao");
            entity.Property(e => e.ModeloDocumentoFiscal)
                .HasMaxLength(2)
                .HasColumnName("modelo_documento_fiscal");
            entity.Property(e => e.NumeroEquipamento).HasColumnName("numero_equipamento");
            entity.Property(e => e.ValorGrandeTotal)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_grande_total");
            entity.Property(e => e.ValorVendaBruta)
                .HasPrecision(18, 6)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_venda_bruta");
        });

        modelBuilder.Entity<Sm>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("sms_pkey");

            entity.ToTable("sms");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_sms_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.DataEnvio)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("data_envio");
            entity.Property(e => e.Enviado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("enviado");
            entity.Property(e => e.Mensagem)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("mensagem");
            entity.Property(e => e.NrCelular)
                .HasMaxLength(15)
                .HasColumnName("nr_celular");
            entity.Property(e => e.NrCliente).HasColumnName("nr_cliente");
            entity.Property(e => e.Usuario).HasColumnName("usuario");
        });

        modelBuilder.Entity<SpedPlanoConta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sped_plano_contas_pkey");

            entity.ToTable("sped_plano_contas");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CnpjEst)
                .HasMaxLength(30)
                .HasColumnName("cnpj_est");
            entity.Property(e => e.CodCta)
                .HasMaxLength(20)
                .HasColumnName("cod_cta");
            entity.Property(e => e.CodCtaRef)
                .HasMaxLength(2)
                .HasColumnName("cod_cta_ref");
            entity.Property(e => e.CodNatCc)
                .HasMaxLength(2)
                .HasColumnName("cod_nat_cc");
            entity.Property(e => e.DtAlt).HasColumnName("dt_alt");
            entity.Property(e => e.IndCta)
                .HasMaxLength(1)
                .HasColumnName("ind_cta");
            entity.Property(e => e.Nivel)
                .HasMaxLength(2)
                .HasColumnName("nivel");
            entity.Property(e => e.NomeCta)
                .HasMaxLength(255)
                .HasColumnName("nome_cta");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<SubItensCompProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("sub_itens_comp_produto_pkey");

            entity.ToTable("sub_itens_comp_produto", tb => tb.HasComment("Sub itens da tabela composicao produto"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdComposicao).HasColumnName("id_composicao");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Quantidade)
                .HasPrecision(18, 4)
                .HasColumnName("quantidade");

            entity.HasOne(d => d.IdComposicaoNavigation).WithMany(p => p.SubItensCompProdutos)
                .HasForeignKey(d => d.IdComposicao)
                .HasConstraintName("sub_itens_comp_produto_fk");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.SubItensCompProdutos)
                .HasForeignKey(d => d.IdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("sub_itens_comp_produto_fk1");
        });

        modelBuilder.Entity<Subservico>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("subservicos_pkey");

            entity.ToTable("subservicos");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasColumnName("ativo");
            entity.Property(e => e.Complemento)
                .HasMaxLength(255)
                .HasColumnName("complemento");
            entity.Property(e => e.IdServico).HasColumnName("id_servico");
            entity.Property(e => e.NmSubservico)
                .HasMaxLength(150)
                .HasColumnName("nm_subservico");

            entity.HasOne(d => d.IdServicoNavigation).WithMany(p => p.Subservicos)
                .HasForeignKey(d => d.IdServico)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("subservicos_fk");
        });

        modelBuilder.Entity<TabelaAnp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tabela_anp_pkey");

            entity.ToTable("tabela_anp");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval(('public.gen_tabela_anp_id'::text)::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.DataFinalValidade)
                .HasMaxLength(6)
                .HasColumnName("data_final_validade");
            entity.Property(e => e.DataInicioValidade)
                .HasMaxLength(6)
                .HasColumnName("data_inicio_validade");
            entity.Property(e => e.Familia)
                .HasMaxLength(80)
                .HasColumnName("familia");
            entity.Property(e => e.Grupo)
                .HasMaxLength(80)
                .HasColumnName("grupo");
            entity.Property(e => e.Produto)
                .HasMaxLength(150)
                .HasColumnName("produto");
            entity.Property(e => e.Ramo)
                .HasMaxLength(50)
                .HasColumnName("ramo");
            entity.Property(e => e.SubGrupo)
                .HasMaxLength(80)
                .HasColumnName("sub_grupo");
            entity.Property(e => e.SubSubgrupo)
                .HasMaxLength(80)
                .HasColumnName("sub_subgrupo");
            entity.Property(e => e.UnidadeGrandeza)
                .HasMaxLength(50)
                .HasColumnName("unidade_grandeza");
            entity.Property(e => e.UnidadeMedidaSimp)
                .HasMaxLength(5)
                .HasColumnName("unidade_medida_simp");
        });

        modelBuilder.Entity<TabelaPreco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tabela_preco_pkey");

            entity.ToTable("tabela_preco");

            entity.HasIndex(e => e.Id, "tabela_preco_id_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(64)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<Tanque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tanque_pkey");

            entity.ToTable("tanque");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CapacidadeLastro)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("capacidade_lastro");
            entity.Property(e => e.CapacidadeTanque)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("capacidade_tanque");
            entity.Property(e => e.DataFabricacao).HasColumnName("data_fabricacao");
            entity.Property(e => e.Estoque)
                .HasPrecision(18, 3)
                .HasDefaultValueSql("NULL::numeric")
                .HasColumnName("estoque");
            entity.Property(e => e.Fabricante)
                .HasMaxLength(45)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("fabricante");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::bpchar")
                .HasColumnName("integrador");
            entity.Property(e => e.Modelo)
                .HasMaxLength(45)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("modelo");
            entity.Property(e => e.NumeroTanque)
                .HasMaxLength(2)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("numero_tanque");
            entity.Property(e => e.Obs)
                .HasMaxLength(2555)
                .HasDefaultValueSql("NULL::character varying")
                .HasColumnName("obs");
            entity.Property(e => e.VidaUtil).HasColumnName("vida_util");
        });

        modelBuilder.Entity<TaxaJurosFormaPgt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("taxa_juros_forma_pgt_pkey");

            entity.ToTable("taxa_juros_forma_pgt");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdFormaPgt)
                .HasMaxLength(2)
                .HasColumnName("id_forma_pgt");
            entity.Property(e => e.Taxa)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("taxa");
        });

        modelBuilder.Entity<TbAjusteContrCredito>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tb_ajuste_contr_credito_pkey");

            entity.ToTable("tb_ajuste_contr_credito");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TbCdBaseCredito>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tb_cd_base_credito_pkey");

            entity.ToTable("tb_cd_base_credito");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TbCdContrSocialApuradum>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tb_cd_contr_social_apurada_pkey");

            entity.ToTable("tb_cd_contr_social_apurada");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TbDescVProd>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("tb_desc_v_prod_pkey");

            entity.ToTable("tb_desc_v_prod");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_tb_desc_v_prod_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.PorcComissao)
                .HasPrecision(18, 2)
                .HasColumnName("porc_comissao");
            entity.Property(e => e.PorcFinal)
                .HasPrecision(18, 2)
                .HasColumnName("porc_final");
            entity.Property(e => e.PorcInicial)
                .HasPrecision(18, 2)
                .HasColumnName("porc_inicial");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.TbDescVProds)
                .HasForeignKey(d => d.CdProduto)
                .HasConstraintName("tb_desc_v_prod_fk");
        });

        modelBuilder.Entity<TbStatusO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tb_status_os_pkey");

            entity.ToTable("tb_status_os");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TbTipoCredito>(entity =>
        {
            entity.HasKey(e => e.Codigo).HasName("tb_tipo_credito_pkey");

            entity.ToTable("tb_tipo_credito");

            entity.Property(e => e.Codigo)
                .HasMaxLength(4)
                .HasColumnName("codigo");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TbVlVendum>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("tb_vl_venda_pkey");

            entity.ToTable("tb_vl_venda");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_tb_vl_venda_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.HrLanc)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_lanc");
            entity.Property(e => e.VlAntigoAVista)
                .HasPrecision(18, 4)
                .HasColumnName("vl_antigo_a_vista");
            entity.Property(e => e.VlAntigoCc)
                .HasPrecision(18, 4)
                .HasColumnName("vl_antigo_cc");
            entity.Property(e => e.VlAntigoDb)
                .HasPrecision(18, 4)
                .HasColumnName("vl_antigo_db");
            entity.Property(e => e.VlAntigoPrazo)
                .HasPrecision(18, 4)
                .HasColumnName("vl_antigo_prazo");
            entity.Property(e => e.VlNovoAVista)
                .HasPrecision(18, 4)
                .HasColumnName("vl_novo_a_vista");
            entity.Property(e => e.VlNovoCc)
                .HasPrecision(18, 4)
                .HasColumnName("vl_novo_cc");
            entity.Property(e => e.VlNovoDb)
                .HasPrecision(18, 4)
                .HasColumnName("vl_novo_db");
            entity.Property(e => e.VlNovoPrazo)
                .HasPrecision(18, 4)
                .HasColumnName("vl_novo_prazo");
        });

        modelBuilder.Entity<TbcomoAchou>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbcomo_achou_pkey");

            entity.ToTable("tbcomo_achou");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TbconfGerenciadortef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbconf_gerenciadortef_pkey");

            entity.ToTable("tbconf_gerenciadortef");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Autoativar)
                .HasMaxLength(1)
                .HasColumnName("autoativar");
            entity.Property(e => e.IdTipogp)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_tipogp");
            entity.Property(e => e.Multiploscartao)
                .HasMaxLength(1)
                .HasColumnName("multiploscartao");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.Sleep).HasColumnName("sleep");
            entity.Property(e => e.Sts).HasColumnName("sts");
        });

        modelBuilder.Entity<TbcontaEstoque>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbconta_estoque_pkey");

            entity.ToTable("tbconta_estoque");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DataLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data_lanc");
            entity.Property(e => e.HoraLanc)
                .HasPrecision(0)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora_lanc");
            entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            entity.Property(e => e.IdPlano).HasColumnName("id_plano");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.IdUsuario)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_usuario");
            entity.Property(e => e.SaldoAnterior)
                .HasPrecision(18, 4)
                .HasColumnName("saldo_anterior");
            entity.Property(e => e.SaldoNovo)
                .HasPrecision(18, 4)
                .HasColumnName("saldo_novo");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.TbcontaEstoques)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("tbconta_estoque_fk1");

            entity.HasOne(d => d.IdProdutoNavigation).WithMany(p => p.TbcontaEstoques)
                .HasForeignKey(d => d.IdProduto)
                .HasConstraintName("tbconta_estoque_fk");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TbcontaEstoques)
                .HasPrincipalKey(p => p.Id)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tbconta_estoque_fk2");
        });

        modelBuilder.Entity<TbimagemProjetoO>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tbimagem_projeto_os_pkey");

            entity.ToTable("tbimagem_projeto_os");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.FotoProjeto)
                .HasDefaultValueSql("''::text")
                .HasColumnName("foto_projeto");
            entity.Property(e => e.IdSerieKitOrc)
                .HasMaxLength(62)
                .HasColumnName("id_serie_kit_orc");
        });

        modelBuilder.Entity<Tipi>(entity =>
        {
            entity.HasKey(e => e.Ncm).HasName("tipi_pkey");

            entity.ToTable("tipi");

            entity.Property(e => e.Ncm)
                .HasMaxLength(8)
                .HasColumnName("ncm");
            entity.Property(e => e.Aliquota)
                .HasMaxLength(3)
                .HasColumnName("aliquota");
            entity.Property(e => e.Descricao)
                .HasMaxLength(1100)
                .HasColumnName("descricao");
            entity.Property(e => e.IdCf).HasColumnName("id_cf");
        });

        modelBuilder.Entity<TipoEtiquetum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_etiqueta_pkey");

            entity.ToTable("tipo_etiqueta");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('gen_tipo_etiqueta_id'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Altura).HasColumnName("altura");
            entity.Property(e => e.Colunas).HasColumnName("colunas");
            entity.Property(e => e.EspacoHorizontal).HasColumnName("espaco_horizontal");
            entity.Property(e => e.EspacoVertical).HasColumnName("espaco_vertical");
            entity.Property(e => e.Largura).HasColumnName("largura");
            entity.Property(e => e.MargemLateral).HasColumnName("margem_lateral");
            entity.Property(e => e.MargemSuperior).HasColumnName("margem_superior");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.TamanhoFonte).HasColumnName("tamanho_fonte");
            entity.Property(e => e.TipoPapel).HasColumnName("tipo_papel");
        });

        modelBuilder.Entity<TipoInformacaoTecProd>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_informacao_tec_prod_pkey");

            entity.ToTable("tipo_informacao_tec_prod");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Nome)
                .HasMaxLength(162)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TipoKitProduto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_kit_produto_pkey");

            entity.ToTable("tipo_kit_produto");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cor)
                .HasMaxLength(15)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cor");
            entity.Property(e => e.Nome)
                .HasMaxLength(62)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TipoNf>(entity =>
        {
            entity.HasKey(e => e.CdTipoNf).HasName("tipo_nf_pkey");

            entity.ToTable("tipo_nf");

            entity.Property(e => e.CdTipoNf)
                .HasMaxLength(2)
                .HasColumnName("cd_tipo_nf");
            entity.Property(e => e.NmTipoNf)
                .HasMaxLength(62)
                .HasColumnName("nm_tipo_nf");
        });

        modelBuilder.Entity<TipoPapel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tipo_papel_pkey");

            entity.ToTable("tipo_papel");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval(('public.gen_tipo_papel_id'::text)::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Altura).HasColumnName("altura");
            entity.Property(e => e.Largura).HasColumnName("largura");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<TiposEmpresa>(entity =>
        {
            entity.HasKey(e => e.CdTipo).HasName("tipos_empresa_pkey");

            entity.ToTable("tipos_empresa");

            entity.Property(e => e.CdTipo)
                .HasDefaultValueSql("nextval('gen_tipos_empresa_id'::regclass)")
                .HasColumnName("cd_tipo");
            entity.Property(e => e.Chave)
                .HasMaxLength(4)
                .HasColumnName("chave");
            entity.Property(e => e.Descricao)
                .HasMaxLength(150)
                .HasColumnName("descricao");
        });

        modelBuilder.Entity<TiposEquipamento>(entity =>
        {
            entity.HasKey(e => e.CdEquipamento).HasName("tipos_equipamentos_pkey");

            entity.ToTable("tipos_equipamentos");

            entity.Property(e => e.CdEquipamento)
                .HasDefaultValueSql("nextval('gen_tipos_equipamentos_id'::regclass)")
                .HasColumnName("cd_equipamento");
            entity.Property(e => e.DataManutencao).HasColumnName("data_manutencao");
            entity.Property(e => e.Fabricante)
                .HasMaxLength(162)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("fabricante");
            entity.Property(e => e.GerouOs)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("gerou_os");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdDepartamento)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_departamento");
            entity.Property(e => e.Imagem).HasColumnName("imagem");
            entity.Property(e => e.Modelo)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("modelo");
            entity.Property(e => e.NmEquipamento)
                .HasMaxLength(162)
                .HasColumnName("nm_equipamento");
            entity.Property(e => e.NrSerie)
                .HasMaxLength(60)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("nr_serie");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.TiposEquipamentos)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("tipos_equipamentos_fk");
        });

        modelBuilder.Entity<TpAdcAcai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("tp_adc_acai_pkey");

            entity.ToTable("tp_adc_acai");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cor)
                .HasMaxLength(20)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("cor");
            entity.Property(e => e.Nome)
                .HasMaxLength(150)
                .HasColumnName("nome");
            entity.Property(e => e.QtdAdcGratis)
                .HasDefaultValueSql("1")
                .HasColumnName("qtd_adc_gratis");
        });

        modelBuilder.Entity<TransferenciaEstoque>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("transferencia_estoque_pkey");

            entity.ToTable("transferencia_estoque");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval(('public.transferencia_estoque_nr_lanc_seq'::text)::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.AcertouRet)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("acertou_ret");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdPlanoEntrada).HasColumnName("cd_plano_entrada");
            entity.Property(e => e.CdPlanoSaida).HasColumnName("cd_plano_saida");
            entity.Property(e => e.DtTranf)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_tranf");
            entity.Property(e => e.HrTransf)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_transf");
            entity.Property(e => e.Transferiu)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transferiu");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.TransferenciaEstoques)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("transferencia_estoque_fk");

            entity.HasOne(d => d.CdPlanoEntradaNavigation).WithMany(p => p.TransferenciaEstoqueCdPlanoEntradaNavigations)
                .HasForeignKey(d => d.CdPlanoEntrada)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transferencia_estoque_fk2");

            entity.HasOne(d => d.CdPlanoSaidaNavigation).WithMany(p => p.TransferenciaEstoqueCdPlanoSaidaNavigations)
                .HasForeignKey(d => d.CdPlanoSaida)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("transferencia_estoque_fk1");
        });

        modelBuilder.Entity<Transportadora>(entity =>
        {
            entity.HasKey(e => e.CdTransportadora).HasName("transportadora_pkey");

            entity.ToTable("transportadora");

            entity.Property(e => e.CdTransportadora)
                .HasDefaultValueSql("nextval('gen_transportadora_id'::regclass)")
                .HasColumnName("cd_transportadora");
            entity.Property(e => e.CdCidade)
                .HasMaxLength(10)
                .HasColumnName("cd_cidade");
            entity.Property(e => e.CdCnpj)
                .HasMaxLength(18)
                .HasColumnName("cd_cnpj");
            entity.Property(e => e.CdIe)
                .HasMaxLength(18)
                .HasColumnName("cd_ie");
            entity.Property(e => e.Cep)
                .HasMaxLength(9)
                .HasColumnName("cep");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.NmBairro)
                .HasMaxLength(62)
                .HasColumnName("nm_bairro");
            entity.Property(e => e.NmEndereco)
                .HasMaxLength(62)
                .HasColumnName("nm_endereco");
            entity.Property(e => e.NmTransportadora)
                .HasMaxLength(62)
                .HasColumnName("nm_transportadora");
            entity.Property(e => e.NrTelefone)
                .HasMaxLength(15)
                .HasColumnName("nr_telefone");
            entity.Property(e => e.NrTelefone2)
                .HasMaxLength(15)
                .HasColumnName("nr_telefone2");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.PlacaVeiculo)
                .HasMaxLength(11)
                .HasColumnName("placa_veiculo");
        });

        modelBuilder.Entity<UnidadeMedidum>(entity =>
        {
            entity.HasKey(e => e.CdUnidade).HasName("unidade_medida_pkey");

            entity.ToTable("unidade_medida");

            entity.Property(e => e.CdUnidade)
                .HasMaxLength(4)
                .HasColumnName("cd_unidade");
            entity.Property(e => e.Descricao)
                .HasMaxLength(62)
                .HasColumnName("descricao");
            entity.Property(e => e.TpUnidade)
                .HasMaxLength(1)
                .HasColumnName("tp_unidade");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.NmUsuario).HasName("usuario_pkey");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Id, "usuario_id_key").IsUnique();

            entity.Property(e => e.NmUsuario)
                .HasMaxLength(62)
                .HasColumnName("nm_usuario");
            entity.Property(e => e.AcertaCondicionalSaida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("acerta_condicional_saida");
            entity.Property(e => e.AlteraCadProduto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("altera_cad_produto");
            entity.Property(e => e.AlteraCr)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("altera_cr");
            entity.Property(e => e.AlteraEntrada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("altera_entrada");
            entity.Property(e => e.AlteraFormaPgtNfce)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("altera_forma_pgt_nfce");
            entity.Property(e => e.AlteraSaida)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("altera_saida");
            entity.Property(e => e.AlterarValorItemOs)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("alterar_valor_item_os");
            entity.Property(e => e.Ativo)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("ativo");
            entity.Property(e => e.AutorizaDescontoCsenha)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("autoriza_desconto_csenha");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdSenha)
                .HasMaxLength(10)
                .HasColumnName("cd_senha");
            entity.Property(e => e.DaDesconto)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("da_desconto");
            entity.Property(e => e.DescalcularOs)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("descalcular_os");
            entity.Property(e => e.DescontoOs)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("desconto_os");
            entity.Property(e => e.DestravaCliente)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("destrava_cliente");
            entity.Property(e => e.ExcluiItemVenda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("exclui_item_venda");
            entity.Property(e => e.ExcluirComanda)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("excluir_comanda");
            entity.Property(e => e.FazAgendamento)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("faz_agendamento");
            entity.Property(e => e.FazBalanco)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("faz_balanco");
            entity.Property(e => e.FechaTodasMesas)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("fecha_todas_mesas");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdBarra)
                .HasMaxLength(15)
                .HasColumnName("id_barra");
            entity.Property(e => e.Integrado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrado");
            entity.Property(e => e.NmPessoa)
                .HasMaxLength(62)
                .HasColumnName("nm_pessoa");
            entity.Property(e => e.Suporte)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("suporte");
            entity.Property(e => e.VisualizaRelatorioGerencial)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("visualiza_relatorio_gerencial");

            entity.HasMany(d => d.CdEmpresas).WithMany(p => p.CdUsuarios)
                .UsingEntity<Dictionary<string, object>>(
                    "UsuarioEmpresa",
                    r => r.HasOne<Empresa>().WithMany()
                        .HasForeignKey("CdEmpresa")
                        .HasConstraintName("usuario_empresa_fk1"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("CdUsuario")
                        .HasConstraintName("usuario_empresa_fk"),
                    j =>
                    {
                        j.HasKey("CdUsuario", "CdEmpresa").HasName("usuario_empresa_pkey");
                        j.ToTable("usuario_empresa");
                        j.IndexerProperty<string>("CdUsuario")
                            .HasMaxLength(62)
                            .HasColumnName("cd_usuario");
                        j.IndexerProperty<int>("CdEmpresa").HasColumnName("cd_empresa");
                    });
        });

        modelBuilder.Entity<VProdutoKit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_produto_kit");

            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.IdKitProduto).HasColumnName("id_kit_produto");
            entity.Property(e => e.IdProdutoPai).HasColumnName("id_produto_pai");
            entity.Property(e => e.IdTipoKit).HasColumnName("id_tipo_kit");
            entity.Property(e => e.NmKit)
                .HasMaxLength(150)
                .HasColumnName("nm_kit");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.NrKit).HasColumnName("nr_kit");
            entity.Property(e => e.Obrigatorio)
                .HasMaxLength(1)
                .HasColumnName("obrigatorio");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasColumnName("quant");
            entity.Property(e => e.SelAutomatico)
                .HasMaxLength(1)
                .HasColumnName("sel_automatico");
            entity.Property(e => e.SeqComp).HasColumnName("seq_comp");
            entity.Property(e => e.SeqKit).HasColumnName("seq_kit");
            entity.Property(e => e.VlAVista)
                .HasPrecision(18, 4)
                .HasColumnName("vl_a_vista");
        });

        modelBuilder.Entity<VProdutosFornecedorEntradum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_produtos_fornecedor_entrada");

            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdForn).HasColumnName("cd_forn");
            entity.Property(e => e.CdGrupoEstoque).HasColumnName("cd_grupo_estoque");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.NmForn)
                .HasMaxLength(150)
                .HasColumnName("nm_forn");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VProdutosFornecedorOrcamento>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_produtos_fornecedor_orcamento");

            entity.Property(e => e.CdForn).HasColumnName("cd_forn");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Empresa)
                .HasMaxLength(1)
                .HasColumnName("empresa");
            entity.Property(e => e.NmForn)
                .HasMaxLength(150)
                .HasColumnName("nm_forn");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VProdutosFornecedorSaidum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_produtos_fornecedor_saida");

            entity.Property(e => e.CdForn).HasColumnName("cd_forn");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Empresa).HasColumnName("empresa");
            entity.Property(e => e.NmForn)
                .HasMaxLength(150)
                .HasColumnName("nm_forn");
            entity.Property(e => e.NmProduto)
                .HasMaxLength(256)
                .HasColumnName("nm_produto");
            entity.Property(e => e.Quant).HasColumnName("quant");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VendaConsumidorCab>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("venda_consumidor_cab_pkey");

            entity.ToTable("venda_consumidor_cab");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_venda_consumidor_cab_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Baixa)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("baixa");
            entity.Property(e => e.BaseIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("base_icms");
            entity.Property(e => e.Cancelada)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("cancelada");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdOperador).HasColumnName("cd_operador");
            entity.Property(e => e.Cfop)
                .HasMaxLength(6)
                .HasColumnName("cfop");
            entity.Property(e => e.Data)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("data");
            entity.Property(e => e.DescNf)
                .HasMaxLength(3)
                .HasDefaultValueSql("'NF'::character varying")
                .HasColumnName("desc_nf");
            entity.Property(e => e.DescPg)
                .HasMaxLength(15)
                .HasDefaultValueSql("'DINHEIRO'::character varying")
                .HasColumnName("desc_pg");
            entity.Property(e => e.Hora)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora");
            entity.Property(e => e.IdEcf).HasColumnName("id_ecf");
            entity.Property(e => e.NrOrdem)
                .HasMaxLength(10)
                .HasColumnName("nr_ordem");
            entity.Property(e => e.NrSerie)
                .HasMaxLength(10)
                .HasColumnName("nr_serie");
            entity.Property(e => e.Status)
                .HasMaxLength(1)
                .HasColumnName("status");
            entity.Property(e => e.SubSerie)
                .HasMaxLength(10)
                .HasColumnName("sub_serie");
            entity.Property(e => e.TipoNota)
                .HasMaxLength(1)
                .HasColumnName("tipo_nota");
            entity.Property(e => e.ValorIcms)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("valor_icms");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.VendaConsumidorCabs)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venda_consumidor_cab_fk1");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.VendaConsumidorCabs)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("venda_consumidor_cab_fk");
        });

        modelBuilder.Entity<VendaFarmaciaPopular>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("venda_farmacia_popular_pkey");

            entity.ToTable("venda_farmacia_popular");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_venda_farmacia_popular_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");
            entity.Property(e => e.CpfVendeodr)
                .HasMaxLength(18)
                .HasColumnName("cpf_vendeodr");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.Fechou)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("fechou");
            entity.Property(e => e.HrLanc)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_lanc");
            entity.Property(e => e.LoginEmpresa)
                .HasMaxLength(62)
                .HasColumnName("login_empresa");
            entity.Property(e => e.NrCupom)
                .HasMaxLength(6)
                .HasDefaultValueSql("'-1'::character varying")
                .HasColumnName("nr_cupom");
            entity.Property(e => e.SenhaEmpresa)
                .HasMaxLength(62)
                .HasColumnName("senha_empresa");
            entity.Property(e => e.SenhaVendedor)
                .HasMaxLength(62)
                .HasColumnName("senha_vendedor");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasColumnName("status");
            entity.Property(e => e.Transf)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("transf");
            entity.Property(e => e.TxtCupomVinculado)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_cupom_vinculado");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.VendaFarmaciaPopulars)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venda_farmacia_popular_fk2");

            entity.HasOne(d => d.CdEmpresaNavigation).WithMany(p => p.VendaFarmaciaPopulars)
                .HasForeignKey(d => d.CdEmpresa)
                .HasConstraintName("venda_farmacia_popular_fk");

            entity.HasOne(d => d.CdVendedorNavigation).WithMany(p => p.VendaFarmaciaPopulars)
                .HasForeignKey(d => d.CdVendedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("venda_farmacia_popular_fk1");
        });

        modelBuilder.Entity<VendaMobileCab>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("venda_mobile_cab_pkey");

            entity.ToTable("venda_mobile_cab");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("nextval('\"Venda_Mobile_Cab_id_seq\"'::regclass)")
                .HasColumnName("id");
            entity.Property(e => e.Alterado)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("alterado");
            entity.Property(e => e.DtRecebimento)
                .HasDefaultValueSql("now()")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("dt_recebimento");
            entity.Property(e => e.DtVenda).HasColumnName("dt_venda");
            entity.Property(e => e.HrVenda)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hr_venda");
            entity.Property(e => e.IdCliente).HasColumnName("id_cliente");
            entity.Property(e => e.IdFormaPgt)
                .HasDefaultValueSql("1")
                .HasColumnName("id_forma_pgt");
            entity.Property(e => e.IdPedido)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_pedido");
            entity.Property(e => e.IdVendaMobile).HasColumnName("id_venda_mobile");
            entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");
            entity.Property(e => e.Status)
                .HasMaxLength(2)
                .HasDefaultValueSql("'01'::character varying")
                .HasColumnName("status");
            entity.Property(e => e.TpImp).HasColumnName("tp_imp");
            entity.Property(e => e.TxtObs)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs");
            entity.Property(e => e.VlDescontoGeral)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desconto_geral");
        });

        modelBuilder.Entity<VendaMobileDetalhe>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("venda_mobile_detalhe_pkey");

            entity.ToTable("venda_mobile_detalhe");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdCabMobile).HasColumnName("id_cab_mobile");
            entity.Property(e => e.IdCabecalho).HasColumnName("id_cabecalho");
            entity.Property(e => e.IdProduto).HasColumnName("id_produto");
            entity.Property(e => e.Qtde)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("1")
                .HasColumnName("qtde");
            entity.Property(e => e.TipoValor)
                .HasMaxLength(1)
                .HasDefaultValueSql("'V'::character varying")
                .HasColumnName("tipo_valor");
            entity.Property(e => e.TxtObsProduto)
                .HasMaxLength(16384)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("txt_obs_produto");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 2)
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 2)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 2)
                .HasColumnName("vl_unitario");

            entity.HasOne(d => d.IdCabecalhoNavigation).WithMany(p => p.VendaMobileDetalhes)
                .HasForeignKey(d => d.IdCabecalho)
                .HasConstraintName("venda_mobile_detalhe_fk");
        });

        modelBuilder.Entity<VendaRapidaFormapgt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("venda_rapida_formapgt");

            entity.Property(e => e.Caixa)
                .HasDefaultValueSql("0")
                .HasColumnName("caixa");
            entity.Property(e => e.CdVendedor)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_vendedor");
            entity.Property(e => e.Desconto)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("desconto");
            entity.Property(e => e.DtLanc).HasColumnName("dt_lanc");
            entity.Property(e => e.Forma)
                .HasMaxLength(30)
                .HasColumnName("forma");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.IdTipoVenda)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("id_tipo_venda");
            entity.Property(e => e.IdVr).HasColumnName("id_vr");
            entity.Property(e => e.NrAberturaCaixa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_abertura_caixa");
            entity.Property(e => e.Troco)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("troco");
            entity.Property(e => e.Valor)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("valor");
        });

        modelBuilder.Entity<VendaSimple>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("venda_simples_pkey");

            entity.ToTable("venda_simples");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval('gen_venda_simples_id'::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.Caixa)
                .HasDefaultValueSql("0")
                .HasColumnName("caixa");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdEmpresa).HasColumnName("cd_empresa");
            entity.Property(e => e.CdParceiro)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("cd_parceiro");
            entity.Property(e => e.CdPlano).HasColumnName("cd_plano");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdVendedor)
                .HasDefaultValueSql("1")
                .HasColumnName("cd_vendedor");
            entity.Property(e => e.DtLanc)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_lanc");
            entity.Property(e => e.DtPagParc).HasColumnName("dt_pag_parc");
            entity.Property(e => e.DtValidade).HasColumnName("dt_validade");
            entity.Property(e => e.FormaPagt)
                .HasMaxLength(1)
                .HasColumnName("forma_pagt");
            entity.Property(e => e.GerouSaida)
                .HasMaxLength(1)
                .HasColumnName("gerou_saida");
            entity.Property(e => e.HoraLanc)
                .HasDefaultValueSql("('now'::text)::time with time zone")
                .HasColumnName("hora_lanc");
            entity.Property(e => e.IdBandeira).HasColumnName("id_bandeira");
            entity.Property(e => e.IdTipoVenda).HasColumnName("id_tipo_venda");
            entity.Property(e => e.Lote)
                .HasMaxLength(26)
                .HasColumnName("lote");
            entity.Property(e => e.MaisFormapgt)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("mais_formapgt");
            entity.Property(e => e.NmUsuario)
                .HasMaxLength(62)
                .HasColumnName("nm_usuario");
            entity.Property(e => e.NrAberturaCaixa)
                .HasDefaultValueSql("(-1)")
                .HasColumnName("nr_abertura_caixa");
            entity.Property(e => e.NrSaida).HasColumnName("nr_saida");
            entity.Property(e => e.Observacao)
                .HasMaxLength(512)
                .HasColumnName("observacao");
            entity.Property(e => e.Pagou)
                .HasMaxLength(1)
                .HasColumnName("pagou");
            entity.Property(e => e.Quant)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("1")
                .HasColumnName("quant");
            entity.Property(e => e.Sequencia)
                .HasMaxLength(8)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("sequencia");
            entity.Property(e => e.TotalPago)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("total_pago");
            entity.Property(e => e.Troco)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("troco");
            entity.Property(e => e.VlComissao)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_comissao");
            entity.Property(e => e.VlCusto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_custo");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlDescontoClassificacao)
                .HasPrecision(18, 2)
                .HasColumnName("vl_desconto_classificacao");
            entity.Property(e => e.VlDescontoItem)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0")
                .HasColumnName("vl_desconto_item");
            entity.Property(e => e.VlTotal)
                .HasPrecision(18, 4)
                .HasColumnName("vl_total");
            entity.Property(e => e.VlUnitario)
                .HasPrecision(18, 4)
                .HasColumnName("vl_unitario");
        });

        modelBuilder.Entity<Vendedor>(entity =>
        {
            entity.HasKey(e => e.CdFuncionario).HasName("vendedor_pkey");

            entity.ToTable("vendedor");

            entity.Property(e => e.CdFuncionario)
                .ValueGeneratedNever()
                .HasColumnName("cd_funcionario");
            entity.Property(e => e.ComissaoAPrazo)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("comissao_a_prazo");
            entity.Property(e => e.ComissaoAVista)
                .HasPrecision(18, 2)
                .HasDefaultValueSql("0")
                .HasColumnName("comissao_a_vista");
            entity.Property(e => e.TipoPagamento)
                .HasMaxLength(1)
                .HasDefaultValueSql("'V'::character varying")
                .HasColumnName("tipo_pagamento");

            entity.HasOne(d => d.CdFuncionarioNavigation).WithOne(p => p.VendedorNavigation)
                .HasForeignKey<Vendedor>(d => d.CdFuncionario)
                .HasConstraintName("vendedor_fk");
        });

        modelBuilder.Entity<Verificacao>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("verificacao");

            entity.Property(e => e.Integrador)
                .HasMaxLength(1)
                .HasDefaultValueSql("'N'::character varying")
                .HasColumnName("integrador");
            entity.Property(e => e.Qtde)
                .HasDefaultValueSql("0")
                .HasColumnName("qtde");
            entity.Property(e => e.Tipo)
                .HasMaxLength(3)
                .HasDefaultValueSql("''::character varying")
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<VrDevolucao>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vr_devolucao_pkey");

            entity.ToTable("vr_devolucao");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Caixa).HasColumnName("caixa");
            entity.Property(e => e.CdCliente).HasColumnName("cd_cliente");
            entity.Property(e => e.CdProduto).HasColumnName("cd_produto");
            entity.Property(e => e.CdVendedor).HasColumnName("cd_vendedor");
            entity.Property(e => e.DtDevolucao)
                .HasDefaultValueSql("('now'::text)::date")
                .HasColumnName("dt_devolucao");
            entity.Property(e => e.DtVr).HasColumnName("dt_vr");
            entity.Property(e => e.IdVr).HasColumnName("id_vr");
            entity.Property(e => e.NrAbertura).HasColumnName("nr_abertura");
            entity.Property(e => e.Qtde)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0.0")
                .HasColumnName("qtde");
            entity.Property(e => e.VlDesconto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0.0")
                .HasColumnName("vl_desconto");
            entity.Property(e => e.VlProduto)
                .HasPrecision(18, 4)
                .HasDefaultValueSql("0.0")
                .HasColumnName("vl_produto");

            entity.HasOne(d => d.CdClienteNavigation).WithMany(p => p.VrDevolucaos)
                .HasForeignKey(d => d.CdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vr_devolucao_fk");

            entity.HasOne(d => d.CdProdutoNavigation).WithMany(p => p.VrDevolucaos)
                .HasForeignKey(d => d.CdProduto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("vr_devolucao_fk1");
        });

        modelBuilder.Entity<VrTipoVendum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("vr_tipo_venda_pkey");

            entity.ToTable("vr_tipo_venda");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Descricao)
                .HasMaxLength(64)
                .HasColumnName("descricao");
            entity.Property(e => e.EntraFechamento)
                .HasMaxLength(1)
                .HasDefaultValueSql("'S'::character varying")
                .HasColumnName("entra_fechamento");
        });

        modelBuilder.Entity<WebServNfe>(entity =>
        {
            entity.HasKey(e => e.NrLanc).HasName("web_serv_nfe_pkey");

            entity.ToTable("web_serv_nfe");

            entity.Property(e => e.NrLanc)
                .HasDefaultValueSql("nextval(('public.gen_web_serv_nfe_id'::text)::regclass)")
                .HasColumnName("nr_lanc");
            entity.Property(e => e.ProxHost)
                .HasMaxLength(25)
                .HasColumnName("prox_host");
            entity.Property(e => e.ProxPorta)
                .HasMaxLength(10)
                .HasColumnName("prox_porta");
            entity.Property(e => e.ProxSenha)
                .HasMaxLength(25)
                .HasColumnName("prox_senha");
            entity.Property(e => e.ProxUser)
                .HasMaxLength(25)
                .HasColumnName("prox_user");
            entity.Property(e => e.TpAmbiente)
                .HasMaxLength(1)
                .HasColumnName("tp_ambiente");
            entity.Property(e => e.Uf)
                .HasMaxLength(2)
                .HasColumnName("uf");
        });
        modelBuilder.HasSequence("abastecimento_id_seq");
        modelBuilder.HasSequence("alunos_id_seq");
        modelBuilder.HasSequence("animal_id_seq");
        modelBuilder.HasSequence("avaliacao_fisica_id_seq");
        modelBuilder.HasSequence("bandeira_cartao_id_seq");
        modelBuilder.HasSequence("bico_id_seq");
        modelBuilder.HasSequence("cab_contagem_est_mobile_id_seq");
        modelBuilder.HasSequence("cab_devolucao_saida_id_seq");
        modelBuilder.HasSequence("cad_endereco_entrega_id_seq");
        modelBuilder.HasSequence("cad_endereco_retirada_id_seq");
        modelBuilder.HasSequence("cad_tp_avalfisica_id_seq");
        modelBuilder.HasSequence("cfop_conta_speed_id_seq");
        modelBuilder.HasSequence("classificacao_cliente_cd_classificacao_seq").HasMax(2147483647L);
        modelBuilder.HasSequence("cliente_credito_id_seq");
        modelBuilder.HasSequence("comanda_formapgt_id_seq");
        modelBuilder.HasSequence("comanda_perdas_id_seq");
        modelBuilder.HasSequence("composicao_produto_id_seq");
        modelBuilder.HasSequence("conf_balanca_id_seq");
        modelBuilder.HasSequence("conf_boleto_nr_lanc_seq").HasMax(2147483647L);
        modelBuilder.HasSequence("conf_integrador_ecomerce_id_seq");
        modelBuilder.HasSequence("contagem_pr_mobile_id_seq");
        modelBuilder.HasSequence("credenciadora_cartao_id_seq");
        modelBuilder.HasSequence("cte_codigo_seq");
        modelBuilder.HasSequence("cte_comp_prestacao_codigo_seq");
        modelBuilder.HasSequence("cte_doc_anterior_codigo_seq");
        modelBuilder.HasSequence("cte_doc_anterior_nfe_id_seq");
        modelBuilder.HasSequence("cte_duplicata_codigo_seq");
        modelBuilder.HasSequence("cte_nf_codigo_seq");
        modelBuilder.HasSequence("cte_nfe_codigo_seq");
        modelBuilder.HasSequence("cte_obs_contrib_codigo_seq");
        modelBuilder.HasSequence("cte_ordem_coleta_codigo_seq");
        modelBuilder.HasSequence("cte_outros_doc_codigo_seq");
        modelBuilder.HasSequence("cte_passagem_codigo_seq");
        modelBuilder.HasSequence("cte_prod_perigoso_codigo_seq");
        modelBuilder.HasSequence("cte_qtd_carga_codigo_seq");
        modelBuilder.HasSequence("cte_rod_motorista_codigo_seq");
        modelBuilder.HasSequence("cte_rod_veiculo_codigo_seq");
        modelBuilder.HasSequence("cte_seguro_codigo_seq");
        modelBuilder.HasSequence("cte_vale_pedagio_codigo_seq");
        modelBuilder.HasSequence("cte_veiculo_codigo_seq");
        modelBuilder.HasSequence("cupom_nfe_id_seq");
        modelBuilder.HasSequence("dados_banc_fornecedor_id_seq");
        modelBuilder.HasSequence("dav_cabecalho_id_seq");
        modelBuilder.HasSequence("dav_detalhe_id_seq");
        modelBuilder.HasSequence("davmani_id_seq");
        modelBuilder.HasSequence("distribuicao_dfe_id_seq");
        modelBuilder.HasSequence("ecf_aliquotas_id_seq");
        modelBuilder.HasSequence("ecf_caixa_id_seq");
        modelBuilder.HasSequence("ecf_configuracao_id_seq");
        modelBuilder.HasSequence("ecf_fechamento_id_seq");
        modelBuilder.HasSequence("ecf_funcionario_id_seq");
        modelBuilder.HasSequence("ecf_operador_id_seq");
        modelBuilder.HasSequence("ecf_posicao_componentes_id_seq");
        modelBuilder.HasSequence("ecf_resolucao_id_seq");
        modelBuilder.HasSequence("ecf_suprimento_id_seq");
        modelBuilder.HasSequence("ecf_tipo_pagamento_id_seq");
        modelBuilder.HasSequence("ecf_total_tipo_pgto_salve_id_seq");
        modelBuilder.HasSequence("ecf_turno_id_seq");
        modelBuilder.HasSequence("especie_id_seq").HasMax(2147483647L);
        modelBuilder.HasSequence("ficha_tecnica_id_seq");
        modelBuilder.HasSequence("fm_complexos_id_seq");
        modelBuilder.HasSequence("fm_componente_id_seq");
        modelBuilder.HasSequence("fm_embalagem_id_seq");
        modelBuilder.HasSequence("fm_embalagem_relacao_id_seq");
        modelBuilder.HasSequence("fm_forma_tam_dos_componente_fk_id_seq");
        modelBuilder.HasSequence("fm_forma_tamanho_fk_id_seq");
        modelBuilder.HasSequence("fm_hist_estoque_id_seq");
        modelBuilder.HasSequence("fm_incompatibilidade_id_seq");
        modelBuilder.HasSequence("fm_item_complexos_id_seq");
        modelBuilder.HasSequence("fm_item_forma_id_seq");
        modelBuilder.HasSequence("fm_item_forma_tam_id_seq");
        modelBuilder.HasSequence("fm_item_om_id_seq");
        modelBuilder.HasSequence("fm_med_contraindicacoes_id_seq");
        modelBuilder.HasSequence("fm_med_om_id_seq");
        modelBuilder.HasSequence("fm_medicamento_ffarmaceutica_fk_id_seq");
        modelBuilder.HasSequence("fm_medicamento_id_seq");
        modelBuilder.HasSequence("fm_ordem_manipulacao_id_seq");
        modelBuilder.HasSequence("fm_perdas_id_seq");
        modelBuilder.HasSequence("fm_produtos_prontos_id_seq").HasMax(2147483647L);
        modelBuilder.HasSequence("fm_rm_baixas_id_seq");
        modelBuilder.HasSequence("fm_veterinario_id_seq");
        modelBuilder.HasSequence("forma_farmaceutica_id_seq");
        modelBuilder.HasSequence("gen_aaaaa_id");
        modelBuilder.HasSequence("gen_ab_v_rap_id");
        modelBuilder.HasSequence("gen_abast_fr_emp_id");
        modelBuilder.HasSequence("gen_abertura_id");
        modelBuilder.HasSequence("gen_agend_ent_id");
        modelBuilder.HasSequence("gen_agendar_revisao_id");
        modelBuilder.HasSequence("gen_ap_maq_id");
        modelBuilder.HasSequence("gen_apont_cam_id");
        modelBuilder.HasSequence("gen_automovel_id");
        modelBuilder.HasSequence("gen_bco_boletos_id");
        modelBuilder.HasSequence("gen_cab_cot_pc_id");
        modelBuilder.HasSequence("gen_cab_venda_cont_id");
        modelBuilder.HasSequence("gen_categoria_id");
        modelBuilder.HasSequence("gen_cbo_id");
        modelBuilder.HasSequence("gen_ch_p_id");
        modelBuilder.HasSequence("gen_cliente_id");
        modelBuilder.HasSequence("gen_comanda_cabecalho_id");
        modelBuilder.HasSequence("gen_comanda_detalhe_id");
        modelBuilder.HasSequence("gen_comanda_impressora_id");
        modelBuilder.HasSequence("gen_comanda_tipo_impressora_id");
        modelBuilder.HasSequence("gen_comissao_vendedor_id");
        modelBuilder.HasSequence("gen_condicao_troca_id");
        modelBuilder.HasSequence("gen_conf_boleto_id");
        modelBuilder.HasSequence("gen_conf_email_nfe_id");
        modelBuilder.HasSequence("gen_conf_nfe_id");
        modelBuilder.HasSequence("gen_consumo_id");
        modelBuilder.HasSequence("gen_conta_do_caixa_id");
        modelBuilder.HasSequence("gen_contador_id");
        modelBuilder.HasSequence("gen_contas_a_pagar_id");
        modelBuilder.HasSequence("gen_contas_a_receber_id");
        modelBuilder.HasSequence("gen_contratos_id");
        modelBuilder.HasSequence("gen_controle_cheques_id");
        modelBuilder.HasSequence("gen_convenio_id");
        modelBuilder.HasSequence("gen_ct_usr_id");
        modelBuilder.HasSequence("gen_dados_vend_consumidor_id");
        modelBuilder.HasSequence("gen_departamento_id");
        modelBuilder.HasSequence("gen_descricao_despesa_id");
        modelBuilder.HasSequence("gen_det_vd_far_pop");
        modelBuilder.HasSequence("gen_diversos");
        modelBuilder.HasSequence("gen_ecf_impressora_id");
        modelBuilder.HasSequence("gen_ecf_movimento_id");
        modelBuilder.HasSequence("gen_ecf_total_tipo_pgto_id");
        modelBuilder.HasSequence("gen_ecf_venda_cabecalho_id");
        modelBuilder.HasSequence("gen_ecf_venda_detalhe_id");
        modelBuilder.HasSequence("gen_empresa_id");
        modelBuilder.HasSequence("gen_emprestimo_id");
        modelBuilder.HasSequence("gen_ent_out_desp_id");
        modelBuilder.HasSequence("gen_entrada_id");
        modelBuilder.HasSequence("gen_ep_pecas_id");
        modelBuilder.HasSequence("gen_fec_terra_id");
        modelBuilder.HasSequence("gen_forma_pagt_id");
        modelBuilder.HasSequence("gen_fornecedor_id");
        modelBuilder.HasSequence("gen_frete_id");
        modelBuilder.HasSequence("gen_frota_empresa_id");
        modelBuilder.HasSequence("gen_funcionario_id");
        modelBuilder.HasSequence("gen_grupo_estoque");
        modelBuilder.HasSequence("gen_ibpt_id");
        modelBuilder.HasSequence("gen_icms_id");
        modelBuilder.HasSequence("gen_id_balanco");
        modelBuilder.HasSequence("gen_id_itens_balanco");
        modelBuilder.HasSequence("gen_it_ap_cam");
        modelBuilder.HasSequence("gen_it_ct_pc_id");
        modelBuilder.HasSequence("gen_itens_orcamento_id");
        modelBuilder.HasSequence("gen_itens_venda_con_id");
        modelBuilder.HasSequence("gen_kit_produto_id");
        modelBuilder.HasSequence("gen_lanc_carga_id");
        modelBuilder.HasSequence("gen_livro_caixa_id");
        modelBuilder.HasSequence("gen_locacao_orcamento_id");
        modelBuilder.HasSequence("gen_lubr_fr_emp_id");
        modelBuilder.HasSequence("gen_marca_automovel_id");
        modelBuilder.HasSequence("gen_mat_ter_id");
        modelBuilder.HasSequence("gen_md_automovel_id");
        modelBuilder.HasSequence("gen_medicos_id");
        modelBuilder.HasSequence("gen_menu_sistema_id");
        modelBuilder.HasSequence("gen_mesa_id");
        modelBuilder.HasSequence("gen_obs_com_pro_id");
        modelBuilder.HasSequence("gen_obs_item_comanda_id");
        modelBuilder.HasSequence("gen_obs_nf_id");
        modelBuilder.HasSequence("gen_op_ter_id");
        modelBuilder.HasSequence("gen_orcamento_id");
        modelBuilder.HasSequence("gen_p_med_cont");
        modelBuilder.HasSequence("gen_parceiros_id");
        modelBuilder.HasSequence("gen_plano_estoque");
        modelBuilder.HasSequence("gen_posto_abastecimento_id");
        modelBuilder.HasSequence("gen_prod_ag_entrega_id");
        modelBuilder.HasSequence("gen_prod_entr_mat_acabado_id");
        modelBuilder.HasSequence("gen_prod_kit_id");
        modelBuilder.HasSequence("gen_prod_saida_mat_prima_id");
        modelBuilder.HasSequence("gen_prod_transf_id");
        modelBuilder.HasSequence("gen_produto_entrada_id");
        modelBuilder.HasSequence("gen_produto_estoque");
        modelBuilder.HasSequence("gen_produto_saida_id");
        modelBuilder.HasSequence("gen_produtos_saida_modelo2_id");
        modelBuilder.HasSequence("gen_projetos_id");
        modelBuilder.HasSequence("gen_r01_id");
        modelBuilder.HasSequence("gen_r02_id");
        modelBuilder.HasSequence("gen_r03_id");
        modelBuilder.HasSequence("gen_r06_id");
        modelBuilder.HasSequence("gen_r07_id");
        modelBuilder.HasSequence("gen_referencia_estoque");
        modelBuilder.HasSequence("gen_saida_materia_prima_id");
        modelBuilder.HasSequence("gen_saida_modelo2_id");
        modelBuilder.HasSequence("gen_saida_notas_devolucao_id");
        modelBuilder.HasSequence("gen_saidas_id");
        modelBuilder.HasSequence("gen_sangria_id");
        modelBuilder.HasSequence("gen_serico_global_id");
        modelBuilder.HasSequence("gen_serv_orcamento_id");
        modelBuilder.HasSequence("gen_servicos_id");
        modelBuilder.HasSequence("gen_setor_funcionario_id");
        modelBuilder.HasSequence("gen_sintegra_60a_id");
        modelBuilder.HasSequence("gen_sintegra_60m_id");
        modelBuilder.HasSequence("gen_sms_id");
        modelBuilder.HasSequence("gen_tabela_anp_id");
        modelBuilder.HasSequence("gen_tb_desc_v_prod_id");
        modelBuilder.HasSequence("gen_tb_vl_venda_id");
        modelBuilder.HasSequence("gen_tipo_etiqueta_id");
        modelBuilder.HasSequence("gen_tipo_papel_id");
        modelBuilder.HasSequence("gen_tipos_empresa_id");
        modelBuilder.HasSequence("gen_tipos_equipamentos_id");
        modelBuilder.HasSequence("gen_transf_estoque_id");
        modelBuilder.HasSequence("gen_transportadora_id");
        modelBuilder.HasSequence("gen_venda_consumidor_cab_id");
        modelBuilder.HasSequence("gen_venda_farmacia_popular_id");
        modelBuilder.HasSequence("gen_venda_simples_id");
        modelBuilder.HasSequence("gen_web_serv_nfe_id");
        modelBuilder.HasSequence("grupo_id_seq");
        modelBuilder.HasSequence("hora_aluno_matricula_id_seq");
        modelBuilder.HasSequence("inventario_cabecalho_id_seq");
        modelBuilder.HasSequence("inventario_detalhe_id_seq");
        modelBuilder.HasSequence("kit_itens_orcamento_id_seq");
        modelBuilder.HasSequence("log_conta_do_caixa_id_seq");
        modelBuilder.HasSequence("log_importacao_id_seq");
        modelBuilder.HasSequence("m_pagamentos_id_seq");
        modelBuilder.HasSequence("marca_produto_id_seq");
        modelBuilder.HasSequence("mdfe_chaves_id_seq");
        modelBuilder.HasSequence("mdfe_condutor_id_seq");
        modelBuilder.HasSequence("mdfe_id_seq");
        modelBuilder.HasSequence("mdfe_infcarregamento_id_seq");
        modelBuilder.HasSequence("mdfe_percurso_id_seq");
        modelBuilder.HasSequence("mdfe_reboque_id_seq");
        modelBuilder.HasSequence("mdfe_rodoviario_id_seq");
        modelBuilder.HasSequence("mdfe_seguro_id_seq");
        modelBuilder.HasSequence("medico_id_seq");
        modelBuilder.HasSequence("ncm_id_seq");
        modelBuilder.HasSequence("ncm_protocolo_estado_id_seq");
        modelBuilder.HasSequence("nfce_abertura_caixa_nr_lanc_seq");
        modelBuilder.HasSequence("nfce_cartao_bandeira_id_seq");
        modelBuilder.HasSequence("nfce_cartao_empresa_id_seq");
        modelBuilder.HasSequence("nfce_forma_pgt_id_seq");
        modelBuilder.HasSequence("nfce_log_id_seq");
        modelBuilder.HasSequence("nfce_produto_saida_id_seq");
        modelBuilder.HasSequence("nfce_saidas_id_seq");
        modelBuilder.HasSequence("nfe_carta_correcao_id_seq");
        modelBuilder.HasSequence("nfe_inulizadas_id_seq");
        modelBuilder.HasSequence("obs_padrao_contas_receber_id_seq");
        modelBuilder.HasSequence("os_devolucao_id_seq");
        modelBuilder.HasSequence("paciente_id_seq");
        modelBuilder.HasSequence("pagtos_parciais_cr_id_seq");
        modelBuilder.HasSequence("pedidos_id_seq", "mobile");
        modelBuilder.HasSequence("ponto_venda_id_seq");
        modelBuilder.HasSequence("posologia_id_seq");
        modelBuilder.HasSequence("preco_produto_id_seq");
        modelBuilder.HasSequence("protocolo_estado_ncm_id_seq");
        modelBuilder.HasSequence("quest_aluno_matricula_id_seq");
        modelBuilder.HasSequence("quitacao_id_seq");
        modelBuilder.HasSequence("raca_id_seq");
        modelBuilder.HasSequence("sangria_caixa_id_seq");
        modelBuilder.HasSequence("serie_kit_itens_orcamento_id_seq");
        modelBuilder.HasSequence("sped_plano_contas_id_seq");
        modelBuilder.HasSequence("sub_itens_comp_produto_id_seq");
        modelBuilder.HasSequence("subservicos_id_seq");
        modelBuilder.HasSequence("tabela_preco_id_seq");
        modelBuilder.HasSequence("tamanho_forma_farmaceutica_id_seq");
        modelBuilder.HasSequence("tanque_id_seq");
        modelBuilder.HasSequence("taxa_juros_forma_pgt_id_seq");
        modelBuilder.HasSequence("tb_status_os_id_seq");
        modelBuilder.HasSequence("tbcomo_achou_id_seq");
        modelBuilder.HasSequence("tbconf_gerenciadortef_id_seq");
        modelBuilder.HasSequence("tbconta_estoque_id_seq");
        modelBuilder.HasSequence("tbimagem_projeto_os_id_seq");
        modelBuilder.HasSequence("tipo_informacao_tec_prod_id_seq");
        modelBuilder.HasSequence("tipo_kit_produto_id_seq");
        modelBuilder.HasSequence("tp_adc_acai_id_seq");
        modelBuilder.HasSequence("transferencia_estoque_nr_lanc_seq").HasMax(2147483647L);
        modelBuilder.HasSequence("usuario_id_seq");
        modelBuilder.HasSequence("Venda_Mobile_Cab_id_seq");
        modelBuilder.HasSequence("venda_mobile_detalhe_id_seq");
        modelBuilder.HasSequence("venda_rapida_formapgt_id_seq");
        modelBuilder.HasSequence("vr_devolucao_id_seq");
        modelBuilder.HasSequence("vr_tipo_venda_id_seq");

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
