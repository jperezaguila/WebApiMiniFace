﻿using System;
using System.Diagnostics;
using ContactosModel.Model;
using RepositorioAdapter.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Adapter
{

    public class MensajeAdapter : BaseAdapter<Contenido, MensajeModel>
    {
        public override Contenido FromViewModel(MensajeModel model)
        {
            return new Contenido()
            {
                id = model.id,
                
            };

        }

        public override MensajeModel FromModel(Contenido model)
        {
            return new MensajeModel();
            {
            
            };
        }
    }
}