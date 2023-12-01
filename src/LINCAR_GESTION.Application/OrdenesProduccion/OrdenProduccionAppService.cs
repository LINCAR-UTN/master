using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace LINCAR_GESTION.OrdenesProduccion
{
    public class OrdenProduccionAppService : LINCAR_GESTIONAppService, IOrdenProduccionAppService
    {
        private readonly IRepository<OrdenProduccion, int> _ordenProduccionRepository;
        private readonly UserManager<IdentityUser> _userManager;
        // private readonly OrdenProduccionManager _ordenProduccionManager;

        public OrdenProduccionAppService(
            IRepository<OrdenProduccion, int> ordenProduccionRepository, 
            UserManager<IdentityUser> userManager/*,
            OrdenProduccionManager ordenProduccionManager*/)
        {
            _ordenProduccionRepository = ordenProduccionRepository;
            _userManager = userManager;
            // _ordenProduccionManager = ordenProduccionManager;
        }

        public async Task<OrdenProduccionDto> CreateUpdateOrdenProduccionAsync(CreateUpdateOrdenProduccionDto input)
        {
            //var userGuid = CurrentUser.Id.GetValueOrDefault();

            //var identityUser = await _userManager.FindByIdAsync(userGuid.ToString());

            var ordenProduccion = ObjectMapper.Map<CreateUpdateOrdenProduccionDto, OrdenProduccion>(input);

            if (input.Id is null)
            {
                ordenProduccion = await _ordenProduccionRepository.InsertAsync(ordenProduccion, autoSave: true);
            }
            else
            {
                ordenProduccion = await _ordenProduccionRepository.GetAsync(input.Id.Value, includeDetails: true);
                await _ordenProduccionRepository.UpdateAsync(ordenProduccion, autoSave: true);
            }

            return ObjectMapper.Map<OrdenProduccion, OrdenProduccionDto>(ordenProduccion);
        }


    }
}
