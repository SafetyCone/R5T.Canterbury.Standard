using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Canterbury.Default;


namespace R5T.Canterbury.Standard
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddCDriveNameConvention(this IServiceCollection services)
        {
            services.AddSingleton<ICDriveNameConvention, CDriveNameConvention>();

            return services;
        }
    }
}
