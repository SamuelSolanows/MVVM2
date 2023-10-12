using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVM.Models
{
    public class UsuasrioModel
    {


       public UsuasrioModel(TUsuario us) {
            ID = us.ID;
            Nombre = us.Nombre;
            Apellido = us.Apellido;
            Correo = us.Correo;
            Telefono = us.Telefono;
            
            Sexo = new SexoModel(us.TSexo);
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public SexoModel Sexo { get; set; } 
    }
}