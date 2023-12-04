﻿using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.Personas;
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.SectoresProduccion
{
    public class SectorProduccion : Entity<Guid>
    {
        public int NroSector { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {get; set; }

        //Relación 1 a * Empleado(s)
        public ICollection<Empleado> Empleados { get; set; } // un Sector de producción tiene tantos a cargo

        //Relación * a 1 Encargado
        public Empleado Encargado { get; set; } // Un sector de producción tiene un encargado

        public ICollection<Autoparte> Autopartes { get; set; }

    }
}
