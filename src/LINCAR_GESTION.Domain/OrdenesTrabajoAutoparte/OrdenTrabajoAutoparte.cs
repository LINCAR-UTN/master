using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.OrdenesTrabajoAutoparte
{
    public class OrdenTrabajoAutoparte : Entity<Guid>
    {
        public int NroOrden {  get; set; }
        public DateTime FechaHoraCreada {  get; set; }
        public List<string> Observaciones { get; set; }
        public int Cantidad {  get; set; }



    }
}
