using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.Empleados;
using LINCAR_GESTION.Observaciones;
using LINCAR_GESTION.OrdenesProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.OrdenesTrabajoAutoparte
{
    public class OrdenTrabajoAutoparte : Entity<int>
    {
        public int NroOrden {  get; set; }
        public DateTime FechaHoraCreada {  get; set; }
        public int Cantidad {  get; set; }  

        // Relación 0..1 a * OrdenProduccion
        public OrdenProduccion ordenProduccion { get; set; }

        // Relación * a * EstadosOrdenTrabajoAutoparte
        // public ICollection<EstadosOrdenTrabajoAutoparte> Estados { get; set; }

        // Relación 0..1 a * Empleado
        public Empleado Empleado { get; set; }

        // Relación 1 a * Autoparte
        public Autoparte Autoparte { get; set; }

        // Relacion 1 a * observaciones
        public List<Observacion> Observaciones { get; set; }

    }
}
