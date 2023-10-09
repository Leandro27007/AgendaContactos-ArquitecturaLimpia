namespace Crud.Entities.POCOs
{
    public class InformacionDeContacto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public Persona Persona { get; set; }

    }
}
