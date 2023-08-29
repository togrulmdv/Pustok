using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using Pustok.Business.MappingProfiles;
using Pustok.Business.Services.Implementations;
using Pustok.Business.Services.Interfaces;
using Pustok.Business.Validators.AuthorValidators;

namespace Pustok.Business;

public static class ServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AuthorMapper).Assembly);

        services.AddScoped<IAuthorService, AuthorService>();
        services.AddScoped<IBookService, BookService>();

        services.AddFluentValidation(o => o.RegisterValidatorsFromAssembly(typeof(AuthorPostDtoValidator).Assembly));

        return services;
    }
}