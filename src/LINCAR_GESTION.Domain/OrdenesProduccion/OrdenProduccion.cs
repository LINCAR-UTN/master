using LINCAR_GESTION.EstadosOrdenAutoparte;
using LINCAR_GESTION.ModelosProducto;
using LINCAR_GESTION.OrdenesTrabajoAutoparte;
using LINCAR_GESTION.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace LINCAR_GESTION.OrdenesProduccion
{
    public class OrdenProduccion : Entity<Guid>
    {
        public int NroOrden { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEntregaEfectiva { get; set; }
        public string DescripcionCamion {  get; set; }
        public float CentroRuiedaCamion { get; set; }
        public string ModeloCamion {get; set; }
        public string CajaVelocidadCamion { get; set; }
        public float AnchoChasisCamion { get; set; }
        public string DominioCamion {  get; set; }
        public string ColorCamion { get; set; }
        public float LargoChasisCamion { get; set; }
        public List<String> Observaciones { get; set; }
      public float LargoTotalMts { get; set; }
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
        public int Malacates { get; set; }
        public int Arcos { get; set; }
        public string Escalera { get; set; }
        public int Boquillas { get; set; }
        public int PortaEstacas { get; set; }
        public float Voltaje { get; set; }

        // Relación 1 a * Cliente
        public Cliente Cliente { get; set; }

        // Relacion * a * EstadoOrdenProduccion 
        public ICollection<EstadoOrdenProduccion> Estados { get; set; }

        // Relacion 1 a * ModeloProducto
        public ModeloProducto ModeloProducto { get; set; }

        // Relacion 0..1 a * OrdenTrabajoAutoparte
        public ICollection<OrdenTrabajoAutoparte> OrdenesTrabajoAutoparte { get; set; }



    }
}
