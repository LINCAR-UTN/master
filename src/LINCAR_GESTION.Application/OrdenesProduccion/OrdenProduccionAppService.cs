﻿using System;
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
