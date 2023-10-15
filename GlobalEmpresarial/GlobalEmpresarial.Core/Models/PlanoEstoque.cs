using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class PlanoEstoque
{
    public int CdPlano { get; set; }

    public string NmPlano { get; set; } = null!;

    public int? CdEmpresa { get; set; }

    public string? Ativo { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<ProdEntrMatAcabado> ProdEntrMatAcabados { get; set; } = new List<ProdEntrMatAcabado>();

    public virtual ICollection<TransferenciaEstoque> TransferenciaEstoqueCdPlanoEntradaNavigations { get; set; } = new List<TransferenciaEstoque>();

    public virtual ICollection<TransferenciaEstoque> TransferenciaEstoqueCdPlanoSaidaNavigations { get; set; } = new List<TransferenciaEstoque>();

    public virtual ICollection<PontoVendum> IdPontoVenda { get; set; } = new List<PontoVendum>();
}
