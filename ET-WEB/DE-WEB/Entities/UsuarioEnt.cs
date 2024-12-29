using System;

namespace DE_WEB.Entities;

public class UsuarioEnt
{
    public long IdUsuario { get; set; }
    public string identificacion { get; set; } = string.Empty;
    public string nombreCompleto { get; set; } = string.Empty;
    public string username { get; set; } = string.Empty;
    public string correoElectronico { get; set; } = string.Empty;
    public string password { get; set; } = string.Empty;
    public bool TerminosyCondiciones { get; set; } = false;
    public bool Estado { get; set; } 
    public string token { get; set; } = string.Empty;
}
