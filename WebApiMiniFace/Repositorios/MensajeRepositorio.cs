using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Security.Cryptography.X509Certificates;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;
using WebApiMiniFace.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Repositorios
{
    public class MensajeRepositorio:BaseRepositorioEntity<Usuario,ContactoModel,ContactoAdapter>
    {

        public MensajeRepositorio(DbContext context) : base(context)
        {
            
        }

        public ICollection<ContactoModel> GetByOrigen(int id)
        {
            var data = DbSet.Find(id).Amigo;
            var ret= new List<ContactoModel>();
            foreach (var usuario in data)
            {
                ret.Add(new ContactoModel()
                {
                    idOrigen=id,
                    idDestino= usuario.id,
                    nombreCompleto=$"{usuario.nombre}{usuario.apellidos}"
                });

            }
            return ret;
        }

        public override ContactoModel Add(ContactoModel model)
        {
            var yo = DbSet.Find(model.idOrigen);
            var tu = DbSet.Find(model.idDestino);
            yo.Amigo.Add(tu);
            try
            {
                Context.SaveChanges();
                return model;
            }
            catch (Exception e)
            {
                return null;
            }

        }
        public override int Delete(ContactoModel model)
        {
            var yo = DbSet.Find(model.idOrigen);
            var tu = DbSet.Find(model.idDestino);
            yo.Amigo.Remove(tu);
            try
            {
                return Context.SaveChanges();
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        public override int Update(ContactoModel model)
        {
            throw new NotImplementedException();
        }
    }
}