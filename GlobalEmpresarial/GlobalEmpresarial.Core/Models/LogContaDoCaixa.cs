﻿using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class LogContaDoCaixa
{
    public int Id { get; set; }

    public string? Descricao { get; set; }

    public DateTime? Datahora { get; set; }
}
