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
        public IHttpActionResult Get(int id)
        {
            return Ok(db.TUsuario.ToList().Where(x => x.ID == id).Select(x=> new UsuasrioModel(x)).ToList());
        }

        // POST: api/Usuario
        public IHttpActionResult Post([FromBody]TUsuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.TUsuario.Add(usuario); 
            db.SaveChanges();
            return Ok(usuario);
        }

        // PUT: api/Usuario/5
        public IHttpActionResult Put(int id, [FromBody]TUsuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.TUsuario.Add(usuario);
            db.SaveChanges();
            return CreatedAtRoute("swwd",  id = usuario.ID , usuario);
        }

        // DELETE: api/Usuario/5
        public IHttpActionResult Delete(int id)
        {
           var eliminar = db.TUsuario.FirstOrDefault(x => x.ID == id);
            db.TUsuario.Remove(eliminar);
            db.SaveChanges();
            return Ok(eliminar);
        }
    }
}
