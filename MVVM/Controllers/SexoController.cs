using MVVM.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public IHttpActionResult Get(int id)   
        {
            return Ok(db.TSexo.ToList().Where(x => x.ID == id).Select(x => new SexoModel(x)).ToList());
        }

        // POST: api/Sexo
        public IHttpActionResult Post([FromBody]TSexo sexo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.TSexo.Add(sexo);
            db.SaveChanges();
            return Ok(sexo);

        }

        // PUT: api/Sexo/5
        public IHttpActionResult  Put(int id, [FromBody]TSexo sexo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.TSexo.Add(sexo);
            db.SaveChanges();
            return CreatedAtRoute("wapo", id = sexo.ID, sexo);
        }

        // DELETE: api/Sexo/5
        public IHttpActionResult Delete(int id)
        {
            var eliminars = db.TSexo.FirstOrDefault(x => id == x.ID);
            db.TSexo.Remove(eliminars);
            db.SaveChanges();
                
            return Ok(eliminars);
        }
    }
}
