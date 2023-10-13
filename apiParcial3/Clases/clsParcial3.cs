using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiParcial3.Models;

namespace apiParcial3.Clases
{
    public class clsParcial3
    {
        //Crear los metoddos y la propiedad de entrada y salida
        //La propiedad es de tipo clase a partir de la clasee
        //modParcial3 objModMdo = new modParcial3();
        public modParcial3 objModMdo
        { get; set; }

        #region "Métodos Privados"
        private bool Validar()
        {
            //Valida la informaciòn de entrada que se encuentra en la clase mod y retorna un valor booleano
            if (objModMdo.undVendidas <= 1)
            {
                objModMdo.Error = "Cantidad de unidades vendidas inferior a uno";
                return false;
            }

            if (objModMdo.precioComputador <= 1)
            {
                objModMdo.Error = "Valor del computador inferior a $1 peso";
                return false;
            }
            return true;
        }

        public string hallarUndxAño()
        {
            //Encuentra las unidades vendidas por año
            string unixAño = string.Empty;
            if (Validar())
            {
                objModMdo.Año++;
                
                for (; objModMdo.Año >= 2023 && objModMdo.Año <= 2026; objModMdo.Año++)
                {
                    objModMdo.undVendidas += Convert.ToInt32(objModMdo.undVendidas * 0.2);
                    unixAño = $"{objModMdo.undVendidas} \n";
                }

                for (; objModMdo.Año >= 2027 && objModMdo.Año <= 2030; objModMdo.Año++)
                {
                    objModMdo.undVendidas += Convert.ToInt32(objModMdo.undVendidas * 0.3352);
                    unixAño = $"{objModMdo.undVendidas} \n";
                }

                for (; objModMdo.Año == 2031; objModMdo.Año++)
                {
                    objModMdo.undVendidas -= Convert.ToInt32(objModMdo.undVendidas * 0.0253);
                    unixAño = $"{objModMdo.undVendidas} \n";
                }

                for (; objModMdo.Año == 2032; objModMdo.Año++)
                {
                    objModMdo.undVendidas += Convert.ToInt32(objModMdo.undVendidas * 0.25);
                    unixAño = $"{objModMdo.undVendidas} \n";
                }

            }
            return unixAño;
        }

        public string hallarPrecioxAño()
        {
            string precioxAño = string.Empty;
            //Encuentra el valor del computador por año
            if (!Validar())
            {
                objModMdo.Año++;
                for (; objModMdo.Año >= 2023 && objModMdo.Año <= 2029; objModMdo.Año++)
                {
                    objModMdo.precioComputador -= Convert.ToInt32(objModMdo.precioComputador * 0.0275);
                    precioxAño = $"{objModMdo.precioComputador} \n";
                }

                for (; objModMdo.Año >= 2030 && objModMdo.Año <= 2033; objModMdo.Año++)
                {
                    objModMdo.precioComputador += Convert.ToInt32(objModMdo.precioComputador * 0.2324);
                    precioxAño = $"{objModMdo.precioComputador} \n";
                }
            }
            return precioxAño;
        }

        public string infoDeRetorno()
        {
            string info = $"Unidades por año: \n" +
                          $"{hallarUndxAño()}\n" +
                          $"{hallarPrecioxAño()}\n";
            return info;
        }
        #endregion
    }
}