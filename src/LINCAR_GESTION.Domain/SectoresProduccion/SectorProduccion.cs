using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.SectoresProduccion
{
    public class SectorProduccion : Entity<Guid>
    {
        public int NroSector { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {get; set; }

    }
}
