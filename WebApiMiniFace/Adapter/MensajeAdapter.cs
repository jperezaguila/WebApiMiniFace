using System;
using System.Diagnostics;
using ContactosModel.Model;
using RepositorioAdapter.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Adapter
{

    public class MensajeAdapter : BaseAdapter<Mensaje, MensajeModel>
    {
        public override Mensaje FromViewModel(MensajeModel model)
        {
            return new Mensaje()
            {
                id = model.id,
                IdDestino = model.IdDestino,
                idOrigen = model.idOrigen,
                asunto = model.asunto,
                fecha = model.fecha,
                leido = model.leido,
                mensaje = model.mensaje
            };
        }

        public override MensajeModel FromModel(Mensaje model)
        {
            return new MensajeModel()
            {
                id = model.id,
                IdDestino = model.IdDestino,
                idOrigen = model.idOrigen,
                asunto = model.asunto,
                fecha = model.fecha,
                leido = model.leido,
                mensaje = model.mensaje
            };
        }
    }
}



