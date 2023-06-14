using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Empresa_Vuelos.Entidades
{
    static class UsuarioValidaciones 
    {
        static public string ValidarInicioSesionUsuario(string usuario, Usuario user)
        {
            string respuesta = "";

            //Validar datos vacios o null en usuairo
            if (string.IsNullOrEmpty(usuario))
            {
                respuesta = "El usuario no puede estar vacío.";
            }

            //Validar Que el usuario estre en la lista
            if (user == null)
            {
                respuesta = "El usuario no se encuentra registrado.";
            }

            return respuesta;
        }

        static public string ValidarInicioSesionContrasena(string contrasena, Usuario user)
        {
            string respuesta = "";

            //Validar datos vacios o null en contraseña
            if (string.IsNullOrEmpty(contrasena))
            {
                respuesta = "La contraseña no puede estar vacía.";
            }
            //Validar que el usuario registrado corresponda con la contraseña asignada
            else
            {
                if (!string.Equals(contrasena, user.contrasena, StringComparison.Ordinal))
                {
                    respuesta = "La contraseña es incorrecta.";
                }
            }

            return respuesta;
        }
    }
}
