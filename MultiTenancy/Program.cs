using System;
using Autofac;
using Autofac.Multitenant;

namespace MultiTenancy
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    //internal class MyTenantIdentificationStrategy : ITenantIdentificationStrategy
    //{
    //    public bool TryIdentifyTenant(out object tenantId)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //// First, create your application-level defaults using a standard
    //// ContainerBuilder, just as you are used to.
    //var builder = new ContainerBuilder();
    //var appContainer = builder.Build();

    //// Once you've built the application-level default container, you
    //// need to create a tenant identification strategy. The details of this
    //// are discussed later on.
    //var tenantIdentifier = new MyTenantIdentificationStrategy();

    //// Now create the multitenant container using the application
    //// container and the tenant identification strategy.
    //var mtc = new MultitenantContainer(tenantIdentifier, appContainer);

    //// Configure the overrides for each tenant by passing in the tenant ID
    //// and a lambda that takes a ContainerBuilder.
    //mtc.ConfigureTenant('1', b => b.RegisterType<Tenant1Dependency>().As<IDependency>().InstancePerDependency());
    //mtc.ConfigureTenant('2', b => b.RegisterType<Tenant2Dependency>().As<IDependency>().SingleInstance());

    //// Now you can use the multitenant container to resolve instances.
}
