using DoctorLoader.Application.Contracts.DTOs;
using DoctorLoader.Application.Contracts.DTOs.Outputs;
using MediatR;

namespace DoctorLoader.Application.Features.DocumentRequests.Queries
{
    internal class GetAllDocumentRequestQuery(int pageNumber = 1, int pageSize = 10) 
        : IRequest<PaginatedList<DocumentRequestDto>>
    {
        public int PageNumber { get; init; } = pageNumber;
        public int PageSize { get; init; } = pageSize;
    }
}
