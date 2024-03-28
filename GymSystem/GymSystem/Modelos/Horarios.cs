using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.Modelos
{
     class Horarios
    {
        private int idHorario;
        private string inicioHora;
        private string finHora;
        private int fk_idClase;
        private int fk_idDia;

        public Horarios(int idHorario, string inicioHora, string finHora, int fk_idClase, int fk_idDia) 
        {
            this.idHorario = idHorario;
            this.inicioHora = inicioHora;
            this.finHora = finHora;
            this.fk_idClase = fk_idClase;
            this.fk_idDia = fk_idDia;
        }
    }
}
