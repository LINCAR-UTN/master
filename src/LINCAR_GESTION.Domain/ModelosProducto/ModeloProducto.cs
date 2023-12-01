using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.OrdenesProduccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.ModelosProducto
{
    public class ModeloProducto : Entity<int>
    {
        public string CodigoModelo { get; set; }
        public float LargoTotalMts {  get; set; }
        public float LargoUtilMts { get; set; }
        public float AltoTotalMts { get; set; }

        public float AltoUtilMts { get; set; }
        public float AnchoTotalMts { get; set; }
        public float AnchoUtilMts { get; set; }

        public float EsperorPisoMms { get; set; }
        public string TipoUnidad { get; set; }
        public string TipoPiso { get; set; }
        public string ColorZocalo { get; set; }
        public string ColorInferior { get; set; }
        public string PuertaLateral { get; set; }
        public string PuertaTrasera { get; set; }
        public int Malacates {  get; set; }
        public int Arcos { get; set; }
        public string Escalera { get; set; }
        public int Boquillas { get; set; }
        public int PortaEstacas { get; set; }
        public float Voltaje {get; set; }

        // Relacion 1 a * OrdenesProducción
        public ICollection<OrdenProduccion> OrdenesProduccion { get; set; } // creo que esta navigabilidad no es necesaria

        // Relación * a * ModeloProducto
        public ICollection<Autoparte> Autopartes { get; set; } 




    }
}
