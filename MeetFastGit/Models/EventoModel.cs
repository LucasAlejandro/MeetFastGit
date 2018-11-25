using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MeetFastGit.Models;

namespace MeetFastGit.Models
{
    public class EventoModel
    {
        private long id;
        private string tematica;
        private bool privado;
        private DateTime fechaCreacion;
        private DateTime fechaEvento;
        private string coordenadas;
        
        public EventoModel(string tematica, bool privado, DateTime fCreacion, DateTime fEvento, string coodenadas)
        {
            this.tematica = tematica;
            this.privado = privado;
            this.fechaCreacion = fCreacion;
            this.fechaEvento = fEvento;
            this.coordenadas = coordenadas;
        }

        public void setID(long id)
        {
            this.id = id;
        }

        public void setTematica(string tematica)
        {
            this.tematica = tematica;
        }

        public void setPrivado(bool privado)
        {
            this.privado = privado;
        }

        public void setFechaCreacion(DateTime FCreacion)
        {
            this.fechaCreacion = FCreacion;
        }

        public void setFechaEvento(DateTime FEvento)
        {
            this.fechaCreacion = FEvento;
        }


        public void setCoordenadas(string coordenadas)
        {
            this.coordenadas = coordenadas;
        }

        public long getID()
        {
            return this.id;
        }

        public string getTematica()
        {
            return this.tematica;
        }

        public bool getPrivado()
        {
            return this.privado;
        }

        public DateTime getFechaCreacion()
        {
            return this.fechaCreacion;
        }

        public DateTime getFechaEvento()
        {
            return this.fechaEvento;
        }

        public string getCoordenadas()
        {
            return this.coordenadas;
        }

        
    }
}