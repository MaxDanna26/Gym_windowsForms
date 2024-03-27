using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.Modelos
{
     class Profesor : Personas
    {
        private int idProfesor;

        public Profesor(int idProfesor,string nombre,string apellido,string tel) : base(nombre,apellido,tel)
        {
            this.idProfesor = idProfesor;
        }

        public override string ToString()
        {
            return $"Profesor {apellido},{nombre}.";
        }
    }

}
