using MeetFastGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetFastGit.Servicios.Interfaces
{
    public interface IComentarioService
    {
        /// <summary>
        /// Añade un comentario
        /// </summary>
        /// <param name="comentario"></param>
        void addComentario(ComentarioModel comentario);

        /// <summary>
        /// Elimina un comentario
        /// </summary>
        /// <param name="comentario"></param>
        void removeComentario(ComentarioModel comentario);

        /// <summary>
        /// Edita un comentario
        /// </summary>
        /// <param name="comentario"></param>
        void editComentario(ComentarioModel comentario);

        /// <summary>
        /// Busca comentarios que contentan un texto determinada
        /// </summary>
        /// <param name="contenido"></param>
        /// <returns></returns>
        List<ComentarioModel> buscarComentarioContenido(string contenido);

        /// <summary>
        /// Busca comentarios por fecha
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        List<ComentarioModel> buscarComentarioFecha(DateTime fecha);

        /// <summary>
        /// Busca los comentarios de un usuario dado
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        List<ComentarioModel> buscarComentarioUsuario(long id);
    }
}
