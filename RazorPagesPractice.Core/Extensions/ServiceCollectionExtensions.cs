using Microsoft.Extensions.DependencyInjection;
using RazorPagesPractice.Core.UseCases;

namespace RazorPagesPractice.Core.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddTransient<IUseCase<GetTransactionRequest, GetTransactionResponse>, GetTransactionUseCase>();
        }
    }
}