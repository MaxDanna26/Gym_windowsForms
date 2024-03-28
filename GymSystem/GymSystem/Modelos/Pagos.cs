using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem.Modelos
{
     class Pagos
    {
        private int idPago;
        private int fk_idCliente;
        private DateTime fechaPago;
        private bool estadoPago;
        private decimal cuota;

        public Pagos(int idPago,int fk_idCliente,DateTime fechaPago,bool estadoPago,decimal cuota)
        {  
            this.idPago = idPago;
            this.fk_idCliente = fk_idCliente;
            this.fechaPago = fechaPago;
            this.estadoPago = estadoPago;
            this.cuota = cuota;
        }
    }
}
