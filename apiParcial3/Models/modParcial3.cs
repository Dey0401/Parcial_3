using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace apiParcial3.Models
{
    public class modParcial3
    {
        //propiedades de entrada y salida
        #region costructor
        public modParcial3()
        {
            this.tipoClasif = 0;
            this.subtotal = 0;
            this.porcDscto = 0;
            this.vrDsto = 0;
            this.vrAPagar = 0;
            Error = string.Empty;
        }
        public modParcial3(int tipoClasif, float subtotal, float porcDscto, float vrDsto, float vrAPagar, string error)
        {
            this.tipoClasif = tipoClasif;
            this.subtotal = subtotal;
            this.porcDscto = porcDscto;
            this.vrDsto = vrDsto;
            this.vrAPagar = vrAPagar;
            Error = error;
        }
        #endregion

        #region Atributos/Propiedades
        public int tipoClasif { get; set; }
        public float subtotal { get; set; }
        public float porcDscto { get; set; }
        public float vrDsto { get; set; }
        public float vrAPagar { get; set; }
        public string Error { get; set; }
        #endregion
    }
}