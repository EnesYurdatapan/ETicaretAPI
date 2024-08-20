using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretAPI.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection collection)
        {
            //collection.AddMediatR(typeof(ServiceRegistration));
            collection.AddHttpClient();
            collection.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));//ServiceRegistration'ın bulunduğu assemblydeki tüm handler sınıflarını bul ve ona göre ioc'ye ekle inşaa et 
        }
    }
}
