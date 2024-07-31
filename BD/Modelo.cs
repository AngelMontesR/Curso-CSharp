using System;
using System.Collections.Generic;

namespace BD;

public partial class Modelo
{
    public int ModeloId { get; set; }

    public string Nombre { get; set; } = null!;

    public int? MarcaId { get; set; }

    public virtual ICollection<Auto> Autos { get; set; } = new List<Auto>();

    public virtual Marca? Marca { get; set; }
}
