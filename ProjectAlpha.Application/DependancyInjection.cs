using Microsoft.Extensions.DependencyInjection;
using ProjectAlpha.Application.Services.Authentication;

namespace ProjectAlpha.Application;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    services.AddScoped<IAuthenticationService, AuthenticationService>();
    return services;
  }
}