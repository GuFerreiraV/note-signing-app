using System;
using System.Collections.Generic;

namespace note_signing_app.Models;

public partial class Zxo010
{
    public string ZxoFilial { get; set; } = null!;

    public string ZxoDoc { get; set; } = null!;

    public string ZxoSerie { get; set; } = null!;

    public string ZxoClient { get; set; } = null!;

    public string ZxoLoja { get; set; } = null!;

    public string ZxoNome { get; set; } = null!;

    public string ZxoRg { get; set; } = null!;

    public string ZxoData { get; set; } = null!;

    public string ZxoHora { get; set; } = null!;

    public string DELET { get; set; } = null!;

    public decimal RECNO { get; set; }

    public decimal RECDEL { get; set; }
}
