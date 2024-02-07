using DoctorLoader.Application.Contracts.Interfaces.Repositories;
using DoctorLoader.Domain;

namespace DoctorLoader.Infrastructure.Repositories
{
    internal class DocumentResponseRepository(ApplicationDbContext dbContext)
        : RepositoryBase<DocumentResponse>(dbContext), IDocumentResponseRepository
    {
    }
}
