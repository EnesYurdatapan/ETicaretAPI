using ETicaretAPI.Application.Abstraction.Services;
using ETicaretAPI.Application.Abstraction.Services.Configurations;
using ETicaretAPI.Application.Abstraction.Storage;
using ETicaretAPI.Application.Abstraction.Token;
using ETicaretAPI.Infrastructure.Configurations;
using ETicaretAPI.Infrastructure.Enums;
using ETicaretAPI.Infrastructure.Services;
using ETicaretAPI.Infrastructure.Services.Storage;
using ETicaretAPI.Infrastructure.Services.Storage.Local;
using ETicaretAPI.Infrastructure.Services.Token;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure
{
    public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStorageService, StorageService>();
            serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
            serviceCollection.AddScoped<IMailService,MailService>();
            serviceCollection.AddScoped<IApplicationService,ApplicationService>();
            serviceCollection.AddScoped<IQRCodeService,QRCodeService>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : class,IStorage
        {
            serviceCollection.AddScoped<IStorage, T>();
        }

        public static void AddStorage<T>(this IServiceCollection serviceCollection, StorageType storageType) where T : class, IStorage
        {
            switch (storageType)
            {
                case StorageType.Local:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
                case StorageType.Azure:
                    break;
                case StorageType.AWS:
                    break;
                default:
                    serviceCollection.AddScoped<IStorage, LocalStorage>();
                    break;
            }
        }
    }
}
