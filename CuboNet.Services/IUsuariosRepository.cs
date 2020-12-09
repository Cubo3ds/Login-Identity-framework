using System;
using System.Collections.Generic;
using System.Text;



namespace CuboNet.Services
{
    public interface IUsuariosRepository
    {
        Usuarios Add(Usuario newUsuario);

    }
}
