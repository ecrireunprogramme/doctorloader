using DoctorLoader.Application.Contracts.Interfaces.Repositories;
using DoctorLoader.Domain;

namespace DoctorLoader.Infrastructure.Repositories
{
    internal class DocumentRequestRepository(ApplicationDbContext dbContext)
        : RepositoryBase<DocumentRequest>(dbContext), IDocumentRequestRepository
    {
    }
}
