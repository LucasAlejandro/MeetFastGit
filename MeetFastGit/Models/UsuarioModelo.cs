using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetFastGit.Models
{
    public class UsuarioModelo
    {
        private long ID;
        private string email;
        private string contraseña;
        private string nombre;
        private DateTime fechaDeNacimiento;
        private string fotoUI;
        private string telefono;
        private string localidad;
        private List<InteresModelo> listaDeIntereses;

        public long getID()
        {
            return this.ID;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public DateTime getFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public string getFotoUI()
        {
            return this.fotoUI;
        }

        public string getTelefono()
        {
            return this.telefono;
        }

        public string getLocalidad()
        {
            return this.localidad;
        }

        public List<IteresesModelo> getListaDeIntereses()
        {
            return this.listaDeIntereses;
        }

        public void setEmail(string emailNuevo)
        {
            this.email = emailNuevo;
        }

        public void setNombre(string nombreNuevo)
        {
            this.nombre = nombreNuevo;
        }

        public void setContraseña(string contraseñaNueva)
        {
            this.contraseña = contraseñaNueva;
        }

        public void setFotoUI(string fotoUINuevo)
        {
            this.fotoUI = fotoUINuevo;
        }

        public void setTelefono(string telefonoNuevo)
        {
            this.telefono = telefonoNuevo;
        }

        public void setLocalidad(string localidadNueva)
        {
            this.localidad = localidadNueva;
        }

        public void setListaDeIntereses(List<IteresesModelo> listaNueva)
        {
            this.listaDeIntereses = listaNueva;
        }

    }
}