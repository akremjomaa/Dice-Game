using DéApplication.Repositories;
using DéApplication.Repositories.Interfaces;

namespace DéApplication
{
    public static class PersistenceService
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            return services;
        }
    }
}
