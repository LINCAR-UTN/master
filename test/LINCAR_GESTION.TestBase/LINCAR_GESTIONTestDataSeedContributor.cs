

using System.Threading.Tasks;
using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.ModelosProducto;
using LINCAR_GESTION.OrdenesProduccion;
using LINCAR_GESTION.Personas;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace LINCAR_GESTION;

public class LINCAR_GESTIONTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<ModeloProducto, int> _modeloProductoRepository;
    private readonly IRepository<Cliente, int> _clienteRepository;
    private readonly IRepository<OrdenProduccion, int> _ordenProduccionRepository;
    private readonly IRepository<Autoparte, int> _autoparteRepository;

    public LINCAR_GESTIONTestDataSeedContributor
        (
        IRepository<ModeloProducto,int> modeloProductoRepository, 
        IRepository<Cliente, int> clienteRepository, 
        IRepository<OrdenProduccion, int> ordenProduccionRepository,
        IRepository<Autoparte, int> autoparteRepository
        )
    {
        _modeloProductoRepository = modeloProductoRepository;
        _clienteRepository = clienteRepository;
        _ordenProduccionRepository = ordenProduccionRepository;
        _autoparteRepository = autoparteRepository;
    }
    public async Task SeedAsync(DataSeedContext context)
    {
        // añadir ModelosProducto
        ModeloProducto modeloProducto1 = await _modeloProductoRepository.InsertAsync(new ModeloProducto
        {
            CodigoModelo = "LC-155"
        });

        ModeloProducto modeloProducto2 = await _modeloProductoRepository.InsertAsync(new ModeloProducto
        {
            CodigoModelo = "LC-156"
        });

        // añadir clientes
        Cliente cliente1 = await _clienteRepository.InsertAsync(new Cliente
        {
            Nombre = "Juan",
            Apellido = "Chiappella Zarini"
        });

        Cliente cliente2 = await _clienteRepository.InsertAsync(new Cliente
        {
            Nombre = "Aaron",
            Apellido = "Chiappella"
        });

        // añadir OrdenesProduccion
        OrdenProduccion ordenProduccion1 = await _ordenProduccionRepository.InsertAsync(new OrdenProduccion
        {
            NroOrden = 500,
            Cliente = cliente2,
            ModeloProducto = modeloProducto2
        });

        OrdenProduccion ordenProduccion2 = await _ordenProduccionRepository.InsertAsync(new OrdenProduccion
        {
            NroOrden = 600,
            Cliente = cliente1,
            ModeloProducto = modeloProducto1
        });

        OrdenProduccion ordenProduccion3 = await _ordenProduccionRepository.InsertAsync(new OrdenProduccion
        {
            NroOrden = 205,
            Cliente = cliente1,
            ModeloProducto = modeloProducto1
        });

        Autoparte autoparte1 = await _autoparteRepository.InsertAsync(new Autoparte
        {
            CodAutoparte = 205,
            Nombre = "Autoparte de dataSeed 1"
        });

        Autoparte autoparte2 = await _autoparteRepository.InsertAsync(new Autoparte
        {
            CodAutoparte = 215,
            Nombre = "Autoparte de dataSeed 2"
        });
    }
}
