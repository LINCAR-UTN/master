using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LINCAR_GESTION.Observaciones;

namespace LINCAR_GESTION.OrdenesProduccion
{
    public class CreateUpdateOrdenProduccionDto
    {
        public int? Id { get; set; }
        [Required]
        public int NroOrden { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEntregaEfectiva { get; set; }
        public string DescripcionCamion { get; set; }
        public float CentroRuedaCamion { get; set; }
        public string ModeloCamion { get; set; }
        public string CajaVelocidadCamion { get; set; }
        public float AnchoChasisCamion { get; set; }
        public string DominioCamion { get; set; }
        public string ColorCamion { get; set; }
        public float LargoChasisCamion { get; set; }
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
        
        // relaciones
        public int ClienteId { get; set; }
        public int ModeloProductoId { get; set; }
        // public ICollection<ObservacionDto> Observaciones { get; set; } // no van las observaciones porque se agregan mediante método, 
        // no se como se hace esto porque al momento que se quiera agregar una nueva observacion la orden de produccion aun no va a estar creada
        // por lo cual no se podrá asignar la observación a la orden de producción

    }
}
