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
            this.undVendidas = 0;
            this.precioComputador = 0;
            this.Año = 2022;
            Error = string.Empty;
        }
        public modParcial3(int undVendidas, float precioComputador, string error)
        {
            this.undVendidas = undVendidas;
            this.precioComputador = precioComputador;
            this.Año = 2022;
            Error = string.Empty;
            Error = error;
        }
        #endregion

        #region Atributos/Propiedades
        public int undVendidas { get; set; }
        public float precioComputador { get; set; }
        public int Año { get; set; }
        public string Error { get; set; }
        #endregion
    }
}