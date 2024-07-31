using System;
using System.Collections.Generic;

namespace BD;

public partial class Marca
{
    public int MarcaId { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Modelo> Modelos { get; set; } = new List<Modelo>();
}
