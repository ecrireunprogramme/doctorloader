using DoctorLoader.Application.Contracts.Interfaces.Repositories;
using DoctorLoader.Domain;

namespace DoctorLoader.Infrastructure.Repositories
{
    internal class DocumentRepository(ApplicationDbContext dbContext) 
        : RepositoryBase<Document>(dbContext), IDocumentRepository
    {
    }
}
