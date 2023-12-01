using System;

namespace LINCAR_GESTION.Personas
{
    public class CreateUpdateClienteDto
    {
        public int? Id { get; set; }
        // atributos de Persona
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroTelefono { get; set; }
        public int DNI { get; set; }
        public DateTime FechaHoraAlta { get; set; }
        public DateTime FechaHoraModificado { get; set; }

        // atributos de Cliente
        public string Direccion { get; set; }
    }
}
