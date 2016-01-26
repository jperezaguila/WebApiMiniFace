using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace RepositorioAdapter.Repositorio
{
    public class MensajeRepositorio: BaseRepositorioEntity<c, MensajeModel, MensajeAdapter>
    {
        public MensajeRepositorio(DbContext context) : base(context)
        {
            
        }

        public ICollection<MensajeModel> GetByDestino(int idDestino)
        {
            var data = Get(o => o.idDestino == idDestino);
            return data;
        }


        public ICollection<MensajeModel> GetByOrigen(int idDestino)
        {
            var data = Get(o => o.idOrigen == idOrigen).OrderByDescending(o => o.fecha);
            return data.ToList();
        }
    }
}