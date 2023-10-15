﻿using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfImpressora
{
    public int Id { get; set; }

    public int? Numero { get; set; }

    public string? Codigo { get; set; }

    public string? Serie { get; set; }

    public string? Identificacao { get; set; }

    public string? Mc { get; set; }

    public string? Md { get; set; }

    public string? Vr { get; set; }

    public string? Tipo { get; set; }

    public string? Marca { get; set; }

    public string? Modelo { get; set; }

    public string? ModeloAcbr { get; set; }

    public string? ModeloDocumentoFiscal { get; set; }

    public string? Versao { get; set; }

    public string? Le { get; set; }

    public string? Lef { get; set; }

    public string? Mfd { get; set; }

    public string? LacreNaMfd { get; set; }

    public string? Docto { get; set; }

    public DateOnly? DataInstalacaoSb { get; set; }

    public string? HoraInstalacaoSb { get; set; }

    public string? EcfImpressora1 { get; set; }
}
