using MeetFastGit.Models;
using MeetFastGit.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetFastGit.Servicios
{
    public class EventoService : IEventoService
    {
        public void addAsistente(UsuarioModelo asistente)
        {
            throw new NotImplementedException();
        }

        public void addEvento(EventoModel evento)
        {
            throw new NotImplementedException();
        }

        public List<UsuarioModelo> asistentes(long idEvento)
        {
            throw new NotImplementedException();
        }

        public List<EventoModel> eventosCercanos(string coordenadas)
        {
            throw new NotImplementedException();
        }

        public List<EventoModel> eventosTematica(string coordenadas, string tematica)
        {
            throw new NotImplementedException();
        }

        public void removeAsistente(UsuarioModelo asistente)
        {
            throw new NotImplementedException();
        }

        public void removeEvento(EventoModel evento)
        {
            throw new NotImplementedException();
        }

        public void updateEvento(EventoModel evento)
        {
            throw new NotImplementedException();
        }
    }
}