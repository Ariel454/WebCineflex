using System;
using System.Collections.Generic;

namespace WebCineflex.Models.DB;

public partial class Comentario
{
    public int IdComentario { get; set; }

    public int IdUserF { get; set; }

    public string Titulo { get; set; } = null!;

    public string Cuerpo { get; set; } = null!;

    public string RutaArchivo { get; set; } = null!;

    public DateTime FechaComentario { get; set; }

    public virtual Usuario IdUserFNavigation { get; set; } = null!;
}
