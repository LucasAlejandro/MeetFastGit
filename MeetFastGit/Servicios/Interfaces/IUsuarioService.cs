using MeetFastGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetFastGit.Servicios.Interfaces
{
    public interface IUsuarioService
    {
        /// <summary>
        /// Añade un usuario a la bbdd
        /// </summary>
        /// <param name="usuario"></param>
        void addUsuario(UsuarioModelo usuario);

        /// <summary>
        /// Actualiza un usuario de la bbdd
        /// </summary>
        /// <param name="usuario"></param>
        void updateUsuario(UsuarioModelo usuario);

        /// <summary>
        /// Elimina un usuario de la bbdd
        /// </summary>
        /// <param name="usuario"></param>
        void removeUsuario(UsuarioModelo usuario);

        /// <summary>
        /// Añade un amigo a la lista
        /// </summary>
        /// <param name="amigo"></param>
        void addAmigo(UsuarioModelo amigo);

        /// <summary>
        /// Elimina un amigo de la lista
        /// </summary>
        /// <param name="amigo"></param>
        void removeAmigo(UsuarioModelo amigo);

        /// <summary>
        /// Lista de todos los usuarios
        /// </summary>
        /// <returns></returns>
        List<UsuarioModelo> todosUsuarios();

        /// <summary>
        /// Lista de los usuarios de determinado rango de edad
        /// </summary>
        /// <param name="edadMinima"></param>
        /// <param name="edadMaxima"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosUsuariosEdad(int edadMinima, int? edadMaxima);

        /// <summary>
        /// Busca usuarios que tengan unos intereses determinados
        /// </summary>
        /// <param name="interes"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosUsuariosInteres(List<InteresModelo> interes);

        /// <summary>
        /// Busca usuarios en una determinada localidad
        /// </summary>
        /// <param name="localidad"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosUsuariosLocalidad(string localidad);

        /// <summary>
        /// Lista de usuarios asistentes a un evento determinado
        /// </summary>
        /// <param name="idEvento"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosUsuariosEvento(long idEvento);

        /// <summary>
        /// Lista de amigos completa
        /// </summary>
        /// <returns></returns>
        List<UsuarioModelo> todosAmigos();

        /// <summary>
        /// Lista de amigos por rango de edad
        /// </summary>
        /// <param name="edadMinima"></param>
        /// <param name="edadMaxima"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosAmigosEdad(int edadMinima, int? edadMaxima);

        /// <summary>
        /// Lista de amigos con unos intereses determinados
        /// </summary>
        /// <param name="interes"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosAmigosInteres(List<InteresModelo> interes);

        /// <summary>
        /// Lista de amigos en una localidad concreta
        /// </summary>
        /// <param name="localidad"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosAmigosLocalidad(string localidad);

        /// <summary>
        /// Lista de amigos que asisten a un evento determinado
        /// </summary>
        /// <param name="idEvento"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosAmigosEvento(long idEvento);

        /// <summary>
        /// Lista de amigos con un nombre determinado
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        List<UsuarioModelo> todosAmigosNombre(string nombre);
    }
}
