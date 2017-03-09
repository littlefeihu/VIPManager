
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
using DF.VIP.Infrastructure.Authentication;
using DF.VIP.Infrastructure;
using DF.VIP.Infrastructure.DependencyManagement;
namespace DF.VIP.Infrastructure
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public int Order { get; }

        public void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<FormsAuthenticationService>().As<IFormsAuthenticationService>().InstancePerLifetimeScope();
            builder.RegisterType<EncryptionService>().As<IEncryptionService>().InstancePerLifetimeScope();
            builder.RegisterType<VIPDB>().As<IDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<Log4NetAdapter>().As<ILogger>().InstancePerLifetimeScope();
            builder.RegisterType<AuthenticationService>().As<IAuthenticationService>().InstancePerLifetimeScope();
            builder.RegisterType<CommandRepository<LoginUser>>().As<ICommandRepository<LoginUser>>().InstancePerLifetimeScope();
            builder.RegisterType<QueryRepository<LoginUser>>().As<IQueryRepository<LoginUser>>().InstancePerLifetimeScope();
            builder.RegisterType<WebHelper>().As<IWebHelper>().InstancePerLifetimeScope();
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


        }
    }
}