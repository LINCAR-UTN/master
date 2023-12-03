using AutoMapper;
using LINCAR_GESTION.Autopartes;
using LINCAR_GESTION.ModelosProducto;
using LINCAR_GESTION.OrdenesProduccion;
using LINCAR_GESTION.OrdenesTrabajoAutoparte;
using LINCAR_GESTION.Personas;

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

        CreateMap<ClienteDto, Cliente>().ReverseMap();
        CreateMap<CreateUpdateClienteDto, Cliente>();

        CreateMap<ModeloProductoDto, ModeloProducto>().ReverseMap();
        CreateMap<CreateUpdateModeloProductoDto, ModeloProducto>();

        CreateMap<AutoparteDto, Autoparte>().ReverseMap();
        CreateMap<CreateUpdateAutoparteDto, Autoparte>();

        CreateMap<OrdenTrabajoAutoparteDto, OrdenTrabajoAutoparte>().ReverseMap();
        // CreateMap<CreateUpdateOrdenTrabajoAutoparteDto, OrdenTrabajoAutoparte>();
    }
}
