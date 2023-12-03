using System;
using System.Threading.Tasks;
using LINCAR_GESTION.ModelosProducto;
using LINCAR_GESTION.Personas;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace LINCAR_GESTION.OrdenesProduccion
{
    public class OrdenProduccionAppService : LINCAR_GESTIONAppService, IOrdenProduccionAppService
    {
        private readonly IRepository<OrdenProduccion, int> _ordenProduccionRepository;
        private readonly IRepository<ModeloProducto, int> _modeloProductoRepository;
        private readonly IRepository<Cliente, int> _clienteRepository;

        private readonly UserManager<IdentityUser> _userManager;
        // private readonly OrdenProduccionManager _ordenProduccionManager;

        public OrdenProduccionAppService(
            IRepository<OrdenProduccion, int> ordenProduccionRepository,
            IRepository<ModeloProducto, int> modeloProductoRepository,
            IRepository<Cliente, int> clienteRepository
            //UserManager<IdentityUser> userManager,
            )
        {
            _ordenProduccionRepository = ordenProduccionRepository;
            _modeloProductoRepository = modeloProductoRepository;
            _clienteRepository = clienteRepository;
            //_userManager = userManager;
        }

        public async Task<OrdenProduccionDto> CreateUpdateOrdenProduccionAsync(CreateUpdateOrdenProduccionDto input)
        {
            var ordenProduccion = ObjectMapper.Map<CreateUpdateOrdenProduccionDto, OrdenProduccion>(input);
            if (input.ClienteId != null) 
            { 
                var cliente = await _clienteRepository.GetAsync(input.ClienteId.Value);
                ordenProduccion.Cliente = cliente;
            }
            if (input.ModeloProductoId != null)
            {
                var modeloProducto = await _modeloProductoRepository.GetAsync(input.ModeloProductoId.Value);
                ordenProduccion.ModeloProducto = modeloProducto;
            }

            if (input.Id is null)
            {
                //var ordenProduccion = new OrdenProduccion
                //{
                //    NroOrden = input.NroOrden,
                //    FechaEmision = input.FechaEmision,
                //    FechaEntrega = input.FechaEntrega,
                //    FechaEntregaEfectiva = input.FechaEntregaEfectiva,
                //    DescripcionCamion = input.DescripcionCamion,
                //    CentroRuedaCamion = input.CentroRuedaCamion,
                //    ModeloCamion = input.ModeloCamion,
                //    CajaVelocidadCamion = input.CajaVelocidadCamion,
                //    AnchoChasisCamion = input.AnchoChasisCamion,
                //    DominioCamion = input.DominioCamion,
                //    ColorCamion = input.ColorCamion,
                //    LargoChasisCamion = input.LargoChasisCamion,
                //    LargoTotalMts = input.LargoTotalMts,
                //    LargoUtilMts = input.LargoUtilMts,
                //    AltoTotalMts = input.AltoTotalMts,
                //    AltoUtilMts = input.AltoUtilMts,
                //    AnchoTotalMts = input.AnchoTotalMts,
                //    AnchoUtilMts = input.AnchoUtilMts,
                //    EspesorPisoMms = input.EspesorPisoMms,
                //    TipoUnidad = input.TipoUnidad,
                //    TipoPiso = input.TipoPiso,
                //    ColorZocalo = input.ColorZocalo,
                //    ColorInferior = input.ColorInferior,
                //    PuertaLateral = input.PuertaLateral,
                //    PuertaTrasera = input.PuertaTrasera,
                //    Malacates = input.Malacates,
                //    Arcos = input.Arcos,
                //    Escalera = input.Escalera,
                //    Boquillas = input.Boquillas,
                //    PortaEstacas = input.PortaEstacas,
                //    Voltaje = input.Voltaje,
                //    Cliente = cliente,
                //    ModeloProducto = modeloProducto,
                //};

                ordenProduccion = await _ordenProduccionRepository.InsertAsync(ordenProduccion, autoSave: true);
            }
            else
            {
                await _ordenProduccionRepository.UpdateAsync(ordenProduccion, autoSave: true);
            }

            return ObjectMapper.Map<OrdenProduccion, OrdenProduccionDto>(ordenProduccion);
        }


    }
}
