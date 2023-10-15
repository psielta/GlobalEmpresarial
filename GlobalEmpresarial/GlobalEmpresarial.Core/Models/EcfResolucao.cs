using System;
using System.Collections.Generic;

namespace GlobalEmpresarial.Core.Models;

public partial class EcfResolucao
{
    public int Id { get; set; }

    public string? ResolucaoTela { get; set; }

    public int? Largura { get; set; }

    public int? Altura { get; set; }

    public string? ImagemTela { get; set; }

    public string? ImagemMenup { get; set; }

    public string? ImagemMenu { get; set; }

    public string? ImagemSubmenu { get; set; }

    public string? HottrackColor { get; set; }

    public string? ItemStyleFontName { get; set; }

    public string? ItemStyleFontColor { get; set; }

    public string? ItemSelStyleColor { get; set; }

    public string? LabelTotalGeralFontColor { get; set; }

    public string? ItemStyleFontStyle { get; set; }

    public string? EditsColor { get; set; }

    public string? EditsFontColor { get; set; }

    public string? EditsDisabledColor { get; set; }

    public string? EditsFontName { get; set; }

    public string? EditsFontStyle { get; set; }

    public string? Integrador { get; set; }

    public string? Bobinacolor { get; set; }

    public string? BobinacolorFont { get; set; }
}
