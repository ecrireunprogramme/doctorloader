using DoctorLoader.Application.Contracts.Interfaces.Services;

namespace DoctorLoader.Application.Contracts;

public interface IServiceManager
{
    public ILoaderService LoaderService { get; }
}
