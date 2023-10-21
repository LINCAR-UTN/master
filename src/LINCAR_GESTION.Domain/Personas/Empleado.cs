using LINCAR_GESTION.OrdenesTrabajoAutoparte;
using LINCAR_GESTION.SectoresProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINCAR_GESTION.Empleados
{
    public class Empleado
    {
        public bool activo {  get; set; }

        //Relación 1 a * OrdenTrabajoAutoparte
        public ICollection<OrdenTrabajoAutoparte> OrdenesTrabajoAutoparte { get; set; }
        //Relacion 1 a * SectorProduccion
        public SectorProduccion SectorProduccion { get; set; } // Sector de Producción en el que trabaja
        //Relacion * a 1 Encargado -> SectorProduccion
        public ICollection<SectorProduccion> SectoresProduccionACargo { get; set; } // Sectores de Produccíón de los cuales está a cargo


    }
}
