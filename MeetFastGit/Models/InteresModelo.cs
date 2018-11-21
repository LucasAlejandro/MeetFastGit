using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetFastGit.Models
{
    public class InteresModelo
    {
        private long ID;
        private string nombre;
        private string tipo;

        public long getID()
        {
            return this.ID;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getTipo()
        {
            return this.tipo;
        }

        public void setNombre(string nombreNuevo)
        {
            this.nombre = nombreNuevo;
        }

        public void setTipo(string tipoNuevo)
        {
            this.tipo = tipoNuevo;
        }
    }
}