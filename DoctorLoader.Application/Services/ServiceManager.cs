using DoctorLoader.Application.Contracts;
using DoctorLoader.Application.Contracts.Interfaces.Services;
using MediatR;

namespace DoctorLoader.Application.Services
{
    internal class ServiceManager(IMediator mediator) : IServiceManager
    {
        private readonly Lazy<ILoaderService> _loaderService 
            = new(() => new LoaderService(mediator));

        public ILoaderService LoaderService => _loaderService.Value;
    }
}
