using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Canterbury.Default;
using R5T.Dacia;


namespace R5T.Canterbury.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="CDriveNameConvention"/> implementation of <see cref="ICDriveNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddCDriveNameConvention(this IServiceCollection services)
        {
            services.AddDefaultCDriveNameConvention();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="CDriveNameConvention"/> implementation of <see cref="ICDriveNameConvention"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<ICDriveNameConvention> AddCDriveNameConventionAction(this IServiceCollection services)
        {
            var serviceAction = new ServiceAction<ICDriveNameConvention>(() => services.AddCDriveNameConvention());
            return serviceAction;
        }
    }
}
