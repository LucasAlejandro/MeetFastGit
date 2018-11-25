using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetFastGit.Models
{
    public class ComentarioModel
    {
        private long idUsuario;
        private DateTime fecha;
        private string contenido;

        public ComentarioModel(long usuario, DateTime fecha, string contenido)
        {
            this.idUsuario = usuario;
            this.fecha = fecha;
        }

        public void setIdUsuario(long idUsuario)
        {
            this.idUsuario = idUsuario;
        }

        public void setFecha(DateTime fecha)
        {
            this.fecha = fecha;

        }

        public void setContenido(string contenido)
        {
            this.contenido = contenido;
        }

        public long getIdUsuario()
        {
            return this.idUsuario;
        }

        public DateTime getFecha()
        {
            return this.fecha;
        }

        public string getContenido()
        {
            return this.contenido;
        }
    }
}