using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class TiposEquipamento
{
    public int CdEquipamento { get; set; }

    public string NmEquipamento { get; set; } = null!;

    public string? Fabricante { get; set; }

    public string? Modelo { get; set; }

    public string? NrSerie { get; set; }

    public int? IdDepartamento { get; set; }

    public string? Imagem { get; set; }

    public DateOnly? DataManutencao { get; set; }

    public int IdCliente { get; set; }

    public string? GerouOs { get; set; }

    public virtual Cliente IdClienteNavigation { get; set; } = null!;
}
