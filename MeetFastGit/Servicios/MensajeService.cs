using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeetFastGit.Models;
using MeetFastGit.Servicios.Interfaces;

namespace MeetFastGit.Servicios
{
    public class MensajeService : IMensajeService
    {
        public void addMensaje(MensajeModel mensaje)
        {
            throw new NotImplementedException();
        }

        public List<MensajeModel> buscaMensajesContenidoUsuario(long usuario, string contenido)
        {
            throw new NotImplementedException();
        }

        public List<MensajeModel> buscarMensajeContenido(string contenido)
        {
            throw new NotImplementedException();
        }

        public void removeMensaje(MensajeModel mensaje)
        {
            throw new NotImplementedException();
        }

        public List<MensajeModel> todosMensajesConUsuario(long usuario)
        {
            throw new NotImplementedException();
        }

        public List<MensajeModel> todosMensajesConUsuarioFecha(long usuario, DateTime fecha)
        {
            throw new NotImplementedException();
        }
    }
}