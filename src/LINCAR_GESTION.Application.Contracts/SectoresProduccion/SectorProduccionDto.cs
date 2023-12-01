using System;
using System.Collections.Generic;
using System.Text;
using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.Empleados;
using Volo.Abp.Application.Dtos;

namespace LINCAR_GESTION.SectoresProduccion
{
    public class SectorProduccionDto : EntityDto<int>
    {
        public int NroSector { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        //Relación 1 a * Empleado(s)
        public ICollection<EmpleadoDto> Empleados { get; set; } // un Sector de producción tiene tantos a cargo

        //Relación * a 1 Encargado
        public EmpleadoDto Encargado { get; set; } // Un sector de producción tiene un encargado

        public ICollection<AutoparteDto> Autopartes { get; set; }
    }
}
