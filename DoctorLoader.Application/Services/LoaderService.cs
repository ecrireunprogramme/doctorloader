using DoctorLoader.Application.Contracts.DTOs;
using DoctorLoader.Application.Contracts.DTOs.Outputs;
using DoctorLoader.Application.Contracts.Interfaces.Services;
using DoctorLoader.Application.Features.DocumentRequests.Queries;
using MediatR;

namespace DoctorLoader.Application.Services
{
    internal class LoaderService(IMediator mediator) : ILoaderService
    {
        private readonly IMediator _mediator = mediator;

        public async Task<PaginatedList<DocumentRequestDto>> GetDocumentRequests(int pageNumber, int pageSize)
        {
            return await _mediator.Send(new GetAllDocumentRequestQuery(pageNumber, pageSize));
        }
    }
}
