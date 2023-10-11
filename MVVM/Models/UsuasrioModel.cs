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
            IDSexo = us.IDSexo;
        }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public int IDSexo { get; set; }
    }
}