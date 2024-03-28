using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.Modelos
{
     class Clase
    {
        private int idClase;
        private string nombre;
        private int fk_idProfesor;
        private int capacidad;
        private int fk_idHorario;
        private int fk_idDia;

        public string GetClase
        {
            get => $"La clase {nombre} se realizara el dia {fk_idDia} a las {fk_idHorario}.";
        }

        public Clase(int idClase,string nombre,int fk_idProfesor,int capacidad,int fk_idHorario)
        {
            this.idClase = idClase;
            this.nombre = nombre;
            this.fk_idProfesor = fk_idProfesor;
            this.capacidad = capacidad;
            this.fk_idHorario = fk_idHorario;
        }
}
}
