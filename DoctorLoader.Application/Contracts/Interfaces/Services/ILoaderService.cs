using DoctorLoader.Application.Contracts.DTOs;
using DoctorLoader.Application.Contracts.DTOs.Outputs;

namespace DoctorLoader.Application.Contracts.Interfaces.Services;

public interface ILoaderService
{
    Task<PaginatedList<DocumentRequestDto>> GetDocumentRequests(int pageNumber, int pageSize);
}
