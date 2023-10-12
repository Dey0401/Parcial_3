using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiParcial3.Models;
using apiParcial3.Clases;
using System.Web.Http.Cors;

namespace apiParcial3.Controllers
{
    [EnableCors(origins: "http://localhost:XXXXX", headers: "*", methods: "*")]
    public class servParcialTresController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller> UNICO METODO DE ENTRADA y salida de info
        public modParcial3 Post([FromBody] modParcial3 objIN)
        {
            //Crea el objeto de la clase operativa (Clases/clsOpeMdo) clsOpeMdo
            clsOpeMdo objOpe = new clsOpeMdo();
            //Paso el parámetro/propiedad (objModMdo) de los datos del modelo
            objOpe.objModMdo = objIN;
            objOpe.hallarDatos();
            return objOpe.objModMdo;
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}