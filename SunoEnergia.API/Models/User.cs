namespace SunoEnergia.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string CorreoElectronico { get; set; }
        public int Celular { get; set; }
        public string Domicilio { get; set; }
        public int CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
    }
}