using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ContactosModel.Model;
using WebApiMiniFace.Repositorios;


namespace WebApiMiniFace.Controllers
{
    public class MensajeController : ApiController
    {
        public MensajeRepositorio MensajeRepositorio{get; set; }

        public ICollection<MensajeModel> Get(int id, bool enviado)
        {
            return MensajeRepositorio.GetByOrigen(id);
        }

        public ICollection<MensajeModel> Get(int id)
        {
            return MensajeRepositorio.GetByDestino(id);
        }

        [ResponseType(typeof (MensajeModel))]
        public IHttpActionResult Post(MensajeModel model)
        {
            var data = MensajeRepositorio.Add(model);
            if (data==null)
            {
                return BadRequest();
            }
            return Ok(data);
         }

        [ResponseType(typeof (void))]
        public IHttpActionResult Put(MensajeModel model)
        {
            var data = MensajeRepositorio.Update(model);
            if (data<1)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
