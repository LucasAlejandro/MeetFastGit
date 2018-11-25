using MeetFastGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetFastGit.Servicios.Interfaces
{
    public interface IEventoService
    {
        /// <summary>
        /// Añade un evento
        /// </summary>
        /// <param name="evento"></param>
        void addEvento(EventoModel evento);

        /// <summary>
        /// Actualiza un evento
        /// </summary>
        /// <param name="evento"></param>
        void updateEvento(EventoModel evento);

        /// <summary>
        /// Elimina un evento
        /// </summary>
        /// <param name="evento"></param>
        void removeEvento(EventoModel evento);

        /// <summary>
        /// Añade un asistente
        /// </summary>
        /// <param name="asistente"></param>
        void addAsistente(UsuarioModelo asistente);

        /// <summary>
        /// Elimina un asistente
        /// </summary>
        /// <param name="asistente"></param>
        void removeAsistente(UsuarioModelo asistente);

        /// <summary>
        /// Busca eventos cercanos
        /// </summary>
        /// <param name="coordenadas"></param>
        /// <returns></returns>
        List<EventoModel> eventosCercanos(string coordenadas);

        /// <summary>
        /// Busca eventos cercanos con cierta tematica
        /// </summary>
        /// <param name="coordenadas"></param>
        /// <param name="tematica"></param>
        /// <returns></returns>
        List<EventoModel> eventosTematica(string coordenadas, string tematica);

        /// <summary>
        /// Visauliza la lista de asistentes
        /// </summary>
        /// <param name="idEvento"></param>
        /// <returns></returns>
        List<UsuarioModelo> asistentes(long idEvento);
    }
}
