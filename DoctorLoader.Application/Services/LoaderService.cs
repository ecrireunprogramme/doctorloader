using DoctorLoader.Application.Contracts.Interfaces.Services;
using MediatR;

namespace DoctorLoader.Application.Services
{
    internal class LoaderService(IMediator mediator) : ILoaderService
    {
        private readonly IMediator _mediator = mediator;
    }
}
