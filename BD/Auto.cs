using System;
using System.Collections.Generic;

namespace BD;

public partial class Auto
{
    public int AutoId { get; set; }

    public int? ModeloId { get; set; }

    public decimal Precio { get; set; }

    public int? Anio { get; set; }

    public virtual Modelo? Modelo { get; set; }
}
