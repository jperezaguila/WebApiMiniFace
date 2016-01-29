﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ContactosModel.Model;
using RepositorioAdapter.Repositorio;
using WebApiMiniFace.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Repositorios
{
    public class MensajeRepositorio : BaseRepositorioEntity<Mensaje, MensajeModel, MensajeAdapter>
    {
        public MensajeRepositorio(DbContext context) : base(context)
        {
        }

        public ICollection<MensajeModel>
            GetByDestino(int idDestino)
        {
            var data = Get(o => o.IdDestino == idDestino).OrderByDescending(o => o.fecha);
            return data.ToList();

        }
        public ICollection<MensajeModel>
           GetByOrigen(int idOrigen)
        {
            var data = Get(o => o.idOrigen == idOrigen).OrderByDescending(o => o.fecha);
            return data.ToList();

        }
    }
}