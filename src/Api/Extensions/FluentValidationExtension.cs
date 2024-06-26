using System.Diagnostics.CodeAnalysis;

namespace Api.Extensions
{
    [ExcludeFromCodeCoverage]
    public static class FluentValidationExtension
    {
        public static IMvcBuilder AddFluentValidation(this IMvcBuilder services)
        {
            //services.AddFluentValidation(fv =>
            //{
            //});

            return services;
        }
    }
}