// See https://aka.ms/new-console-template for more information


using DependencyContainer;
using System.Xml.Schema;

public class DummyContainer
{
    List<ServiceDefinition> _services = new();
    public DummyContainer(List<ServiceDefinition> services)
    {
        _services = services;
    }

    public object GetService(Type serviceType)
    {
        var svc = _services.SingleOrDefault(s => s.ServiceType == serviceType);
        if(svc == null)
        {
            throw new Exception($"Service of type {serviceType.Name} is not registered");
        }
        if(svc.ServiceImplementation != null)
        {
            return svc.ServiceImplementation;
        }
        var currentType=svc.ImplementationType ?? svc.ServiceType;
        if (currentType.IsAbstract || currentType.IsInterface)
        {
            throw new Exception("Cannot instantiate abstract classes or interfaces");
        }

        var constructorInfo = currentType.GetConstructors().First();

        var parameters = constructorInfo.GetParameters()
            .Select(x => GetService(x.ParameterType)).ToArray();

        var implementation = Activator.CreateInstance(currentType, parameters);

        if (svc.ServiceLifetime == ServiceLifetime.Singleton)
        {
            svc.ServiceImplementation = implementation;
        }

        return implementation;
    }
    public T GetService<T>()
    {
        return (T)GetService(typeof(T));
    }

}