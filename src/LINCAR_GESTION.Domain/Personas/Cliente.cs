using LINCAR_GESTION.OrdenesProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINCAR_GESTION.Personas
{
    public class Cliente : Persona
    {
        public string Direccion { get; set; }

        // Relación 1 a * Ordenes de Producción
        public ICollection<OrdenProduccion> OrdenesProduccion { get; set; }

    }
}
