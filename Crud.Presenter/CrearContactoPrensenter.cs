using Crud.CasosDeUsoPuertos.ContactoPorts;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Presenter
{
    public class CrearContactoPrensenter : ICrearContactoOutputPort, IPresenter<ContactoDTO>
    {
        public ContactoDTO Content { get; private set; }

        public Task Handle(ContactoDTO contacto)
        {  
            Content = contacto;

            return Task.CompletedTask;
        }
    }
}
