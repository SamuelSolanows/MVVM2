using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVVM.Controllers
{
    public class SexoController : ApiController
    {

        PruebaMVVMEntities1 db =new PruebaMVVMEntities1 ();
        // GET: api/Sexo
        public IHttpActionResult Get()
        {
            return Ok(db.TSexo.ToList().Select(x =>new  SexoModel(x)).ToList());
        }

        // GET: api/Sexo/5
        public string Get(int id)   
        {
            return "value";
        }

        // POST: api/Sexo
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sexo/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sexo/5
        public void Delete(int id)
        {
        }
    }
}
