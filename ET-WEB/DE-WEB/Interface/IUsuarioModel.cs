using DE_WEB.Entities;
using DE_WEB.Models;

namespace DE_WEB.Interface;

public interface IUsuarioModel 
{
    public int SignUp(UsuarioEnt usuario);
    public UsuarioEnt? SignIn(UsuarioEnt usuario);
}
