using System.Data.Entity;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;
using WebApiMiniFace.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Repositorios
{
    public class ContactoRespositorio:BaseRepositorioEntity<Usuario,ContactoModel,ContactoAdapter>
    {
        public ContactoRespositorio(DbContext context) : base(context)
        {
            
        }
    }
}