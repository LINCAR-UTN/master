using System;
using System.Collections.Generic;
using System.Text;
using LINCAR_GESTION.Clientes;
using LINCAR_GESTION.EstadosOrdenProduccion;
using LINCAR_GESTION.ModelosProducto;
using LINCAR_GESTION.OrdenesTrabajoAutoparte;
using Volo.Abp.Application.Dtos;

namespace LINCAR_GESTION.OrdenesProduccion
{
    public class OrdenProduccionDto : EntityDto<int>
    {
        public int NroOrden { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaEntregaEfectiva { get; set; }
        public string DescripcionCamion { get; set; }
        public float CentroRuiedaCamion { get; set; }
        public string ModeloCamion { get; set; }
        public string CajaVelocidadCamion { get; set; }
        public float AnchoChasisCamion { get; set; }
        public string DominioCamion { get; set; }
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
        public ClienteDto Cliente { get; set; }

        // Relacion * a * EstadoOrdenProduccion 
        public ICollection<EstadoOrdenProduccionDto> Estados { get; set; }

        // Relacion 1 a * ModeloProducto
        public ModeloProductoDto ModeloProducto { get; set; }

        // Relacion 0..1 a * OrdenTrabajoAutoparte
        public ICollection<OrdenTrabajoAutoparteDto> OrdenesTrabajoAutoparte { get; set; }
    }
}
