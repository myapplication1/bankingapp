[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(app.com.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(app.com.App_Start.NinjectWebCommon), "Stop")]

namespace app.com.App_Start
{
  using System;
  using System.Web;
  using System.Web.Http;
  using app.com.Data;
  using Microsoft.Web.Infrastructure.DynamicModuleHelper;
  using Ninject;
  using Ninject.Web.Common;
  using WebApiContrib.IoC.Ninject;

  public static class NinjectWebCommon
  {
    private static readonly Bootstrapper bootstrapper = new Bootstrapper();

    /// <summary>
    /// Starts the application
    /// </summary>
    public static void Start()
    {
      DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
      DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
      bootstrapper.Initialize(CreateKernel);
    }

    /// <summary>
    /// Stops the application.
    /// </summary>
    public static void Stop()
    {
      bootstrapper.ShutDown();
    }

    /// <summary>
    /// Creates the kernel that will manage your application.
    /// </summary>
    /// <returns>The created kernel.</returns>
    private static IKernel CreateKernel()
    {
      var kernel = new StandardKernel();
      try
      {
        kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
        kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

        // Support Ninject in Web API
        GlobalConfiguration.Configuration.DependencyResolver = new NinjectResolver(kernel);

        RegisterServices(kernel);
        return kernel;
      }
      catch
      {
        kernel.Dispose();
        throw;
      }
    }

    /// <summary>
    /// Load your modules or register your services here!
    /// </summary>
    /// <param name="kernel">The kernel.</param>
    private static void RegisterServices(IKernel kernel)
    {
      kernel.Bind<_DbContext>().ToSelf().InRequestScope();
      //kernel.Bind<I_Repository>().To<_Repository>();
      kernel.Bind<ICusRepository>().To<CusRepository >();
        }
  }
}
