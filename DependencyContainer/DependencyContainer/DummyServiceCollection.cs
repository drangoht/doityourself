using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyContainer
{
    public class DummyServiceCollection
    {
        List<ServiceDefinition> services = new();

        public void AddSingleton<TService>()
        {
            Add<TService>(ServiceLifetime.Singleton);
        }
        public void AddSingleton<TService, TImplementation>()
        {
            Add<TService, TImplementation>(ServiceLifetime.Singleton);
        }
        public void AddTransient<TService>()
        {
            Add<TService>(ServiceLifetime.Transient);

        }
        public void AddTransient<TService, TImplementation>()
        {
            Add<TService, TImplementation>(ServiceLifetime.Transient);
        }

        public void Add<TService>(ServiceLifetime serviceLifetime)
        {
            services.Add(new(typeof(TService), serviceLifetime));
        }
        public void Add<TService,TImplementation>(ServiceLifetime serviceLifetime)
        {
            services.Add(new(typeof(TService),typeof(TImplementation), serviceLifetime));
        }
        public DummyContainer GetContainer()
        {
            return new DummyContainer(services);
        }


    }
}
