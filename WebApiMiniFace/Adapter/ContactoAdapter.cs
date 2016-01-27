using ContactosModel.Model;
using RepositorioAdapter.Adapter;
using WebApiMiniFace.Models;

namespace WebApiMiniFace.Adapter
{
    public class ContactoAdapter : BaseAdapter<Usuario, ContactoModel>
    {

        public override Usuario FromViewModel(ContactoModel model)
        {
            return null;

        }

        public override ContactoModel FromModel(Usuario model)
        {
            return null;
        }


    }
}