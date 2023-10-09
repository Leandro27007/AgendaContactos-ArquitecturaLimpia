using Crud.CasosDeUsoPuertos.ContactoPorts;
using Crud.Presenter;
using DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactoController
    {
        private readonly ICrearContactoInputPort _crearContactoInputPort;
        private readonly IListarContactosInputPort _listarContactosInputPort;
        private readonly IEditarContactoInputPort _editarContactoInputPort;
        private readonly IEliminarContactoInputPort _eliminarContactoInputPort;

        private readonly IListarContactosOutputPort _listarContactosOutputPort;
        private readonly ICrearContactoOutputPort _crearContactoOutputPort;
        private readonly IEditarContactoOutputPort _editarContactoOutputPort;
        private readonly IEliminarContactoOutputPort _eliminarContactoOutputPort;

        public ContactoController(
            ICrearContactoInputPort crearContactoInputPort,
            ICrearContactoOutputPort crearContactoOutputPort,
            IListarContactosInputPort listarContactosInputPort,
            IListarContactosOutputPort listarContactosOutputPort,
            IEditarContactoInputPort editarContactoInputPort,
            IEditarContactoOutputPort editarContactoOutputPort,
            IEliminarContactoInputPort eliminarContactoInputPort,
            IEliminarContactoOutputPort eliminarContactoOutputPort)
        {
            this._listarContactosInputPort = listarContactosInputPort;
            this._crearContactoInputPort = crearContactoInputPort;
            this._listarContactosOutputPort = listarContactosOutputPort;
            this._crearContactoOutputPort = crearContactoOutputPort;
            this._editarContactoInputPort = editarContactoInputPort;
            this._editarContactoOutputPort = editarContactoOutputPort;
            this._eliminarContactoInputPort = eliminarContactoInputPort;
            this._eliminarContactoOutputPort = eliminarContactoOutputPort;
        }




        [HttpPost]
        public async Task<ContactoDTO> CrearContacto(CrearContactoDTO contacto)
        {
            await _crearContactoInputPort.Handle(contacto);
            return ((IPresenter<ContactoDTO>)_crearContactoOutputPort).Content;
        }

        [HttpGet]
        public async Task<IEnumerable<ContactoDTO>> ListarContactos()
        {
            await _listarContactosInputPort.Handle();
            return ((IPresenter<IEnumerable<ContactoDTO>>)_listarContactosOutputPort).Content;
        }

        [HttpPut]
        public async Task<bool> EditarContacto(EditarContactoDTO contacto)
        {
            await _editarContactoInputPort.Handle(contacto);
            return ((IPresenter<bool>)_editarContactoOutputPort).Content;
        }

        [HttpDelete]
        public async Task<bool> EliminarContacto(int id)
        {
            await _eliminarContactoInputPort.Handle(id);
            return ((IPresenter<bool>)_eliminarContactoOutputPort).Content;
        }


    }
}
