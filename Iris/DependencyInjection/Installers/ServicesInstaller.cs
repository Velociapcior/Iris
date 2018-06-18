using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Iris.Services;
using Iris.Services.Interfaces;

namespace Iris.DependencyInjection.Installers
{
  public class ServicesInstaller : IWindsorInstaller
  {
    public void Install(IWindsorContainer container, IConfigurationStore store)
    {
      container.Register(Component.For<ISessionStateServie>()
        .ImplementedBy<SessionStateService>()
        .LifestyleTransient());
    }
  }
}