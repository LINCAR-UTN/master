

using System.Threading.Tasks;
using LINCAR_GESTION.ModelosProducto;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace LINCAR_GESTION;

public class LINCAR_GESTIONTestDataSeedContributor : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<ModeloProducto, int> _modeloProductoRepository;
    public LINCAR_GESTIONTestDataSeedContributor(IRepository<ModeloProducto, int> modeloProductoRepository)
    {
        _modeloProductoRepository = modeloProductoRepository;
    }
    public async Task SeedAsync(DataSeedContext context)
    {
        // ñadir modeloProducto
        ModeloProducto modeloProducto1 = await _modeloProductoRepository.InsertAsync(new ModeloProducto
        {
            CodigoModelo = "LC-155"
        });

        ModeloProducto modeloProducto2 = await _modeloProductoRepository.InsertAsync(new ModeloProducto
        {
            CodigoModelo = "LC-156"
        });
    }
}
