using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiParcial3.Models;

namespace apiParcial3.Clases
{
    public class clsOpeMdo
    {
        //Crear los metoddos y la propiedad de entrada y salida
        //La propiedad es de tipo clase a partir de la clasee
        modParcial3 objModMdo = new modParcial3();
        public modParcial3 objModMdo
        { get; set; }

        #region "Métodos Privados"
        private bool Validar()
        {
            //Valida la informaciòn de entrada que se encuentra en la clase mod y retorna un valor booleano
            if (objModMdo.tipoClasif != 1 && objModMdo.tipoClasif != 5 && objModMdo.tipoClasif != 10)
            {
                objModMdo.Error = "Tipo de clasificación no válida";
                return false;
            }

            if (objModMdo.subtotal <= 0)
            {
                objModMdo.Error = "Valor del subtotal no válido";
                return false;
            }
            return true;
        }

        private void hallarDscto()
        {
            //Encuentra el porcentaje de descuento
            if (Validar())
            {
                switch (objModMdo.tipoClasif)
                {
                    case 1:     //Preferente
                        if (objModMdo.subtotal < 1000000)
                            objModMdo.porcDscto = 8f;
                        else
                            objModMdo.porcDscto = 15f;
                        break;

                    case 5:     //Especial
                        if (objModMdo.subtotal < 1000000)
                            objModMdo.porcDscto = 5f;
                        else
                            objModMdo.porcDscto = 10f;
                        break;

                    default:    //Ordinario
                        if (objModMdo.subtotal < 1000000)
                            objModMdo.porcDscto = 0f;
                        else
                            objModMdo.porcDscto = 4f;
                        break;
                }
                objModMdo.vrDsto = objModMdo.subtotal * objModMdo.porcDscto / 100f;
            }
        }

        public void hallarDatos()
        {
            //Invoca los dos metodos anteriores y encuentra el valor total a pagar 
            if (!Validar())
            {
                hallarDscto();
                objModMdo.vrAPagar = objModMdo.subtotal - objModMdo.vrDsto;
            }
        }
        #endregion
    }
}