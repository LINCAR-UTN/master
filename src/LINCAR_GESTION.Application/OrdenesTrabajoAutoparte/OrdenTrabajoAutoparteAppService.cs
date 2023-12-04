using System.Threading.Tasks;
using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.Empleados;
using LINCAR_GESTION.OrdenesProduccion;
using Microsoft.AspNetCore.Identity;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Identity;

namespace LINCAR_GESTION.OrdenesTrabajoAutoparte
{
    public class OrdenTrabajoAutoparteAppService : LINCAR_GESTIONAppService, IOrdenTrabajoAutoparteAppService
    {
        private readonly IRepository<OrdenTrabajoAutoparte, int> _ordenTrabajoAutoparteRepository;
        private readonly IRepository<Autoparte, int> _autoparteRepository;
        private readonly IRepository<Empleado, int> _empleadoRepository;
        private readonly IRepository<OrdenProduccion, int> _ordenProduccionRepository;

        private readonly UserManager<IdentityUser> _userManager;
        // private readonly OrdenTrabajoAutoparteManager _ordenTrabajoAutoparteManager;

        public OrdenTrabajoAutoparteAppService(
            IRepository<OrdenTrabajoAutoparte, int> ordenTrabajoAutoparteRepository,
            IRepository<Autoparte, int> autoparteRepository,
            IRepository<Empleado, int> empleadoRepository,
            IRepository<OrdenProduccion, int> ordenProduccionRepository
            //UserManager<IdentityUser> userManager,
            )
        {
            _ordenTrabajoAutoparteRepository = ordenTrabajoAutoparteRepository;
            _autoparteRepository = autoparteRepository;
            _empleadoRepository = empleadoRepository;
            _ordenProduccionRepository = ordenProduccionRepository;
            //_userManager = userManager;
        }

        public async Task<OrdenTrabajoAutoparteDto> CreateUpdateOrdenTrabajoAutoparteAsync(CreateUpdateOrdenTrabajoAutoparteDto input)
        {
            var ordenTrabajoAutoparte = ObjectMapper.Map<CreateUpdateOrdenTrabajoAutoparteDto, OrdenTrabajoAutoparte>(input);
            if (input.EmpleadoId != null)
            {
                var empleado = await _empleadoRepository.GetAsync(input.EmpleadoId);
                ordenTrabajoAutoparte.Empleado = empleado;
            }
            if (input.SolicitanteId != null)
            {
                var solicitante = await _empleadoRepository.GetAsync(input.SolicitanteId);
                ordenTrabajoAutoparte.Solicitante = solicitante;
            }
            if (input.AutoparteId != null)
            {
                var autoparte = await _autoparteRepository.GetAsync(input.AutoparteId);
                ordenTrabajoAutoparte.Autoparte = autoparte;
            }
            if (input.ordenProduccionId != null)
            {
                var ordenProduccion = await _ordenProduccionRepository.GetAsync(input.ordenProduccionId.Value);
                ordenTrabajoAutoparte.ordenProduccion = ordenProduccion;
            }


            if (input.Id is null)
            {
                ordenTrabajoAutoparte = await _ordenTrabajoAutoparteRepository.InsertAsync(ordenTrabajoAutoparte, autoSave: true);
            }
            else
            {
                await _ordenTrabajoAutoparteRepository.UpdateAsync(ordenTrabajoAutoparte, autoSave: true);
            }
            return ObjectMapper.Map<OrdenTrabajoAutoparte, OrdenTrabajoAutoparteDto>(ordenTrabajoAutoparte);
        }
    }
}

