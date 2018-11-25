using MeetFastGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetFastGit.Servicios.Interfaces
{
    public interface IHistoriaService
    {
        /// <summary>
        /// Añade una historia
        /// </summary>
        /// <param name="historia"></param>
        /// <param name="usuario"></param>
        void addHistoria(HistoriaModelo historia, long usuario);

        /// <summary>
        /// Elimina una historia
        /// </summary>
        /// <param name="historia"></param>
        /// <param name="usuario"></param>
        void removeHistoria(HistoriaModelo historia, long usuario);

        /// <summary>
        /// Busca todas las historias
        /// </summary>
        /// <returns></returns>
        /// <param name="usuario"></param>
        List<HistoriaModelo> todasHistorias(long usuario);
    }
}
