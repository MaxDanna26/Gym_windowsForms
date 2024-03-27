using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.Modelos
{
    class Cliente : Personas
    {
        private int idCliente;
        private DateTime fechaInicio;
        private int fk_IdCuota;

        public Cliente(string nombre, string apellido, string tel, int idCliente, DateTime fechaInicio, int fk_IdCuota) : base(nombre,apellido,tel)
        {
            this.idCliente = idCliente;
            this.fechaInicio = fechaInicio;
            this.fk_IdCuota = fk_IdCuota;
        }

        public override string ToString()
        {
            return $"{apellido},{nombre}.";
        }


    }
}
