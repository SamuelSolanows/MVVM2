using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVVM.Models
{
    public class SexoModel
    {
        public SexoModel(TSexo sx)
        {
            ID = sx.ID;
            Nombre = sx.Nombre;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
    }
}