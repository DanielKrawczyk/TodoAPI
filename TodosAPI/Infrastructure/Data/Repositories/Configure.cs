using TodosAPI.Infrastructure.Data.Repositories.Interfaces;
using TodosAPI.Infrastructure.Data.Repositories.Read;

namespace TodosAPI.Infrastructure.Data.Repositories
{
    public static class Configure
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddSingleton<IReadTodosRepository, ReadTodosRepository>();
        }
    }
}
