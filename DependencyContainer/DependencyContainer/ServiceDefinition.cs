// See https://aka.ms/new-console-template for more information

using DependencyContainer;

public class ServiceDefinition
{
    
    public Type ServiceType { get;}
    public Type ImplementationType { get;}
    public Object ServiceImplementation { get; internal set; }
    public ServiceLifetime ServiceLifetime { get; }
    public ServiceDefinition(object serviceImplementation,ServiceLifetime serviceLifetime)
    {
        ServiceType=serviceImplementation.GetType();
        ServiceLifetime= serviceLifetime;
        ServiceImplementation = serviceImplementation;
    }

    public ServiceDefinition(Type serviceType, ServiceLifetime serviceLifetime)
    {
        ServiceType = serviceType;
        ServiceLifetime = serviceLifetime;
    }
    public ServiceDefinition(Type serviceType,Type implementationType, ServiceLifetime serviceLifetime)
    {
        ImplementationType = implementationType;
        ServiceType = serviceType;
        ServiceLifetime = serviceLifetime;
    }

}