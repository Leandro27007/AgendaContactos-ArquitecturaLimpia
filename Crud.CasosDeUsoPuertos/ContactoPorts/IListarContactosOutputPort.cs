using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.CasosDeUsoPuertos.ContactoPorts
{
    public interface IListarContactosOutputPort
    {
        Task Handle(IEnumerable<ContactoDTO> contatos);
    }
}
