using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Services.Protocols;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;
using WebApiMiniFace.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Repositorios
{
    public class UsuarioRepositorio:BaseRepositorioEntity<Usuario, UsuarioModel,UsuarioAdapter>
    {
        public UsuarioRepositorio(DbContext context) : base(context)
        {

        }
        //creacion de un metodo para validar

        public UsuarioModel Validar(String login, String password)
        {
            var data = Get(o => o.login == login && o.password == password);

            if (data.Any())
                return data.First();
            return null;
        }


        public override UsuarioModel Add(UsuarioModel model)
        {
            if (IsUnico(model.login))
                return base.Add(model);
            return null;
        }


        //para saber si el login es unico y no se repite (creacion de metodo para luego)
        public bool IsUnico(String login)
        {
            var data = Get(o => o.login == login);
            return !data.Any();
        }

    }
}