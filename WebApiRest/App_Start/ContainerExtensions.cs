using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BD;
using WBL;
namespace WebApiRest
{
    public static class ContainerExtensions
    {

        public static IServiceCollection AddDIContainer(this IServiceCollection services)
        {

            services.AddSingleton<IDataAccess,DataAccess>();
            services.AddTransient<IAgenciaService, AgenciaService>();
            services.AddTransient<IAlquilerService, AlquilerService>();
            services.AddTransient<ICatalogoCantonService, CatalogoCantonService>();
            services.AddTransient<CatalogoDistritoService, CatalogoDistritoService>();
            services.AddTransient<CatalogoProvinciaService, CatalogoProvinciaService>();
            services.AddTransient<IClientesService, ClientesService>();
            services.AddTransient<IMarcaVehiculoService, MarcaVehiculoService>();
            services.AddTransient<IVehiculoService, VehiculoService>();
            services.AddTransient<IUsuariosServices, UsuariosServices>();

            return services;
        }
    }
}
