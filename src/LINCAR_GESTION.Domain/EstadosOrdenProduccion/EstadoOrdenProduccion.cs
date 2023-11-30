using LINCAR_GESTION.OrdenesProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.EstadosOrdenAutoparte
{
    public class EstadoOrdenProduccion : Entity<int>
    {
        public NombreEstadoOrdenAutoparte Nombre {  get; set; }
        public DateTime FechaHoraHasta {get; set; }

        // Relación * a * OrdenProduccion
        public ICollection<OrdenProduccion> Ordenes { get; set; }
    }
}
