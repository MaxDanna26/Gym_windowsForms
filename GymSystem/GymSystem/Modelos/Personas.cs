using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.Modelos
{
    public class Personas
    {
        public string nombre;
        public string apellido;
        public string tel;

        public string GetName
        {
            get => $"{apellido},{nombre}";
        }
        
        public string GetTel
        {
            get => tel;
        }

        public Personas(string nombre, string apellido, string tel)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tel = tel;
        }



      
    }
}
