using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace LINCAR_GESTION.Autopartes
{
    public abstract class Autoparte : Entity<Guid>
    {
        public int CodAutoparte { get; set; }
        public string Nombre { get; set; }
        public bool Activa { get; set; }
        public List<string> Observaciones { get; set; }

    }
}
