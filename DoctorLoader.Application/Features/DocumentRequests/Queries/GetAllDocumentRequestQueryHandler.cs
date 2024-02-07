using AutoMapper;
using AutoMapper.QueryableExtensions;
using DoctorLoader.Application.Contracts.DTOs;
using DoctorLoader.Application.Contracts.DTOs.Outputs;
using DoctorLoader.Application.Contracts.Interfaces;
using MediatR;
using DoctorLoader.Application.Extensions;

namespace DoctorLoader.Application.Features.DocumentRequests.Queries
{
    internal class GetAllDocumentRequestQueryHandler(IApplicationUnitOfWork uow, IMapper mapper)
                : IRequestHandler<GetAllDocumentRequestQuery, PaginatedList<DocumentRequestDto>>
    {
        private readonly IApplicationUnitOfWork _uow = uow;
        private readonly IMapper _mapper = mapper;

        public async Task<PaginatedList<DocumentRequestDto>> Handle(GetAllDocumentRequestQuery request, 
            CancellationToken cancellationToken)
        {
            return await _uow.DocumentRequestRepository
                .FindAll()
                .ProjectTo<DocumentRequestDto>(_mapper.ConfigurationProvider)
                .PaginatedListAsync(request.PageNumber, request.PageSize);
        }
    }
}
