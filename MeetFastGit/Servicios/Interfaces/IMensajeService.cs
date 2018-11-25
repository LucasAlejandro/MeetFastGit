using MeetFastGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetFastGit.Servicios.Interfaces
{
    public interface IMensajeService
    {
        /// <summary>
        /// Añade un mensaje
        /// </summary>
        /// <param name="mensaje"></param>
        void addMensaje(MensajeModel mensaje);

        /// <summary>
        /// Elimina un mensaje
        /// </summary>
        /// <param name="mensaje"></param>
        void removeMensaje(MensajeModel mensaje);

        /// <summary>
        /// Busca todos los mensajes con un determinado usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        List<MensajeModel> todosMensajesConUsuario(long usuario);

        /// <summary>
        /// Busca todos los mensajes con un determinado usuario en una fecha concreta
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        List<MensajeModel> todosMensajesConUsuarioFecha(long usuario, DateTime fecha);

        /// <summary>
        /// Busca los mensajes que contengan una determinada cadena
        /// </summary>
        /// <param name="contenido"></param>
        /// <returns></returns>
        List<MensajeModel> buscarMensajeContenido(string contenido);

        /// <summary>
        /// Busca los mensajes con un usuario con una determinada cadena
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="contenido"></param>
        /// <returns></returns>
        List<MensajeModel> buscaMensajesContenidoUsuario(long usuario, string contenido);
    }
}
