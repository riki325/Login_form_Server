using Microsoft.Extensions.DependencyInjection;
using Repositories.Entities;
using Repositories.Interfaces;
using Repositories.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class ServerCollection
    {
        public static void AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IDataRepository<PrivateUserDetails>, PrivateUserDetailsRepository>();
        }
    }
}
