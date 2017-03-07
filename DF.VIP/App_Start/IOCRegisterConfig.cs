using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using DF.VIP.Infrastructure.Logger;
using DF.VIP.Infrastructure.Configuration;
using DF.VIP.Infrastructure.Repository;
using DF.VIP.Infrastructure.Entity.Admin;
using DF.VIP.AppService.Authentication;
using DF.VIP.Infrastructure.Security;

namespace DF.VIP
{
    public class IOCRegisterConfig
    {
        public static void Register()
        {

            var builder = new ContainerBuilder();
            builder.RegisterType<EncryptionService>().As<IEncryptionService>().InstancePerRequest();
            builder.RegisterType<VIPDB>().As<IDbContext>().InstancePerRequest();
            builder.RegisterType<Log4NetAdapter>().As<ILogger>().InstancePerRequest();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>().InstancePerRequest();
            builder.RegisterType<CommandRepository<LoginUser>>().As<ICommandRepository<LoginUser>>().InstancePerRequest();
            builder.RegisterType<QueryRepository<LoginUser>>().As<IQueryRepository<LoginUser>>().InstancePerRequest();

            builder.RegisterType<ApplicationSettingsFactory>().AsSelf().SingleInstance();
            builder.RegisterType<LoggingFactory>().AsSelf().SingleInstance();
            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // OPTIONAL: Register model binders that require DI.
            builder.RegisterModelBinders(typeof(MvcApplication).Assembly);
            builder.RegisterModelBinderProvider();

            // OPTIONAL: Register web abstractions like HttpContextBase.
            builder.RegisterModule<AutofacWebTypesModule>();

            // OPTIONAL: Enable property injection in view pages.
            builder.RegisterSource(new ViewRegistrationSource());

            // OPTIONAL: Enable property injection into action filters.
            builder.RegisterFilterProvider();

            // OPTIONAL: Enable action method parameter injection (RARE).
            // builder.InjectActionInvoker();

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
         
        }
     }
}