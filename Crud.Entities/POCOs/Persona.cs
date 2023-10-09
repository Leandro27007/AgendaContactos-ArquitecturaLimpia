namespace Crud.Entities.POCOs
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Sexo { get; set; }
        public DateTime Nacimiento { get; set; }
        public InformacionDeContacto InformacionDeContacto { get; set; }
        public int InformacionDeContactoId { get; set; }

    }
}
