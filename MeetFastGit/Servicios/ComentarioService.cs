using MeetFastGit.Models;
using MeetFastGit.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetFastGit.Servicios
{
    public class ComentarioService : IComentarioService
    {
        public void addComentario(ComentarioModel comentario)
        {
            throw new NotImplementedException();
        }

        public List<ComentarioModel> buscarComentarioContenido(string contenido)
        {
            throw new NotImplementedException();
        }

        public List<ComentarioModel> buscarComentarioFecha(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public List<ComentarioModel> buscarComentarioUsuario(long id)
        {
            throw new NotImplementedException();
        }

        public void editComentario(ComentarioModel comentario)
        {
            throw new NotImplementedException();
        }

        public void removeComentario(ComentarioModel comentario)
        {
            throw new NotImplementedException();
        }
    }
}