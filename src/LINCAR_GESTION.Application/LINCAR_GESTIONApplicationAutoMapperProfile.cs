using AutoMapper;
using LINCAR_GESTION.OrdenesProduccion;

namespace LINCAR_GESTION;

public class LINCAR_GESTIONApplicationAutoMapperProfile : Profile
{
    public LINCAR_GESTIONApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        // OrdenProduccion
        CreateMap<OrdenProduccionDto, OrdenProduccion>().ReverseMap();
        CreateMap<CreateUpdateOrdenProduccionDto, OrdenProduccion>();



    }
}
