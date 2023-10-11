using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI;

namespace MVVM.Controllers
{
    public class UsuarioController : ApiController
    {
        PruebaMVVMEntities1 db = new PruebaMVVMEntities1 ();

        // GET: api/Usuario
        public IHttpActionResult Get()
        {
            return Ok(db.TUsuario.ToList().Select(x=> new UsuasrioModel(x)).ToList());
        }

        // GET: api/Usuario/5
        public string Get(int id)
        {
            return "sapo";
        }


        // GET: api/Usuario/5 
        [HttpGet]
        [Route ("api/Usuario/sapo")]
        public string Get2(int id)
        {
            return "value";
        }

        // POST: api/Usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Usuario/5
        public void Delete(int id)
        {
        }
    }
}
