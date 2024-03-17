using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using KYC360_Project.Data;

namespace KYC360_Project
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Configure services (e.g., database context, authentication)
            services.AddDbContext<Kyc365DbContext>();
        }
    }
}
