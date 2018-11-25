using MeetFastGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeetFastGit.Servicios.Interfaces
{
    public interface IInteresInterface
    {
        /// <summary>
        /// Añade un interes a la bbdd
        /// </summary>
        /// <param name="interes"></param>
        void addInteres(InteresModelo interes);

        /// <summary>
        /// Actualiza un interes de la bbdd
        /// </summary>
        /// <param name="interes"></param>
        void updateInteres(InteresModelo interes);

        /// <summary>
        /// Devuelve todos los intereses de un determinado tipo
        /// </summary>
        /// <param name="tipo"></param>
        /// <returns></returns>
        IEnumerable<InteresModelo> todosInteresTipo(string tipo);

        /// <summary>
        /// Busca un interés por el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        InteresModelo interesNombre(string nombre);

        /// <summary>
        /// Elimina un interes de la bbdd
        /// </summary>
        /// <param name="interes"></param>
        void deleteInteres(InteresModelo interes);

        /// <summary>
        /// Busca todos los tipos de interes
        /// </summary>
        /// <returns></returns>
        IEnumerable<String> todosTipos();
    }
}
