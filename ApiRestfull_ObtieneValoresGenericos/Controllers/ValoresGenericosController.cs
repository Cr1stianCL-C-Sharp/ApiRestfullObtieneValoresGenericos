using ApiRestfull_ObtieneValoresGenericos.Class;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ApiRestfull_ObtieneValoresGenericos.Controllers
{

    [EnableCors(origins: "*", headers: "*", methods: "*")]//-->ESTA SENTENCIA HABILITA EL CORS
    public class ValoresGenericosController : ApiController
    {

        /// <summary>
        /// PROTOCOLO GET
        /// INVOCACION EN LA DIRECCION:http://localhost:64055/api/valoresgenericos
        /// </summary>
        /// <returns>List<ObjetoGenerico></returns>
        [HttpGet]
        public List<ObjetoGenerico> obtieneListaObjeto()
        {
            try
            {

                List<ObjetoGenerico> listaObjetoGenerico = new List<ObjetoGenerico>();
                ObjetoGenerico objecto = new ObjetoGenerico();
                int recorre = 50;
                for (int i = 0; i < recorre; i++)
                {
                    objecto.id = i;
                    objecto.postId = i + 1000;
                    objecto.name = String.Format("nombre generico {0}", i);
                    objecto.email = String.Format("correogenerico{0}@webservices.cl", i);
                    objecto.body = @"est natus enim nihil est dolore omnis voluptatem numquam\net omnis " +
                                    "occaecati quod ullam at\nvoluptatem error expedita pariatur\nnihil sint nostrum " +
                                    "voluptatem reiciendis et";
                    listaObjetoGenerico.Add(objecto);
                }
                return listaObjetoGenerico;

            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return null;
            }
        }






        /// <summary>
        /// PROTOCOLO GET/ID
        /// INVOCACION EN LA DIRECCION:http://localhost:64055/api/valoresgenericos/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns>ObjetoGenerico</returns>

        [HttpGet]
        public ObjetoGenerico obtieneObjetoPorID(int id)
        {
            try
            {
                ObjetoGenerico objeto = new ObjetoGenerico();
                objeto.postId = id + 1000;
                objeto.id = id;
                objeto.name = "objeto generico";
                objeto.email = "correo@retorno.cl";
                objeto.body = "Cuerpo generico del retorno";



                return objeto;
            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return null;
            }

        }


        /// <summary>
        /// PROTOCOLO POST
        /// INVOCACION EN LA DIRECCION:http://localhost:64055/api/valoresgenericos
        /// SE DEBE PASAR OBJETO VALORES GENERICOS(JSON)
        /// {
        ///"postId": 1001,
        ///"id": 1,
        ///"name": "Articulo",
        ///"email": "crosas@mailgenerico.cl",
        ///"body": "mensaje del post"
        ///}
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>bool</returns>
        [HttpPost]
        public bool GuardaObjetoGenerico([FromBody]ObjetoGenerico objeto)
        {
            try
            {
                bool retorno = false;
                if (objeto != null)
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return false;
            }
        }


        /// <summary>
        /// PROTOCOLO PUT
        /// INVOCACION EN LA DIRECCION:http://localhost:64055/api/valoresgenericos
        /// </summary>
        /// <returns>string</returns>
        [HttpPut]
        public string obtieneDiaActual()
        {
            try
            {
                CultureInfo ci = new CultureInfo("Es-Es");

                string diaActual = ci.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek).ToString();

                return diaActual;
            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return null;
            }

        }

        /// <summary>
        /// PROTOCOLO DELETE
        ///INVOCACION EN LA DIRECCION:http://localhost:64055/api/valoresgenericos/1
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        [HttpDelete]
        public bool Delete(int? id)
        {

            try
            {
                bool retorno = false;
                if (id != null)
                {
                    retorno = true;
                }

                return retorno;
            }
            catch (Exception ex)
            {
                string error = ex.InnerException.ToString();
                return false;
            }
        }
    }
}
