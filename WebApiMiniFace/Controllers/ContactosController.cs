using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Web.Http;

namespace WebApiMiniFace.Controllers
{
    public class ContactosController : ApiController
    {
        [Dependency]
        public ICollection<ContactosModel>GetNoContactoByOrigen(int id)
        {
            var data= DbSet.find(id).Amigo.select()
        }

    }
}
