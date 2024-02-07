using DoctorLoader.Application.Contracts.Interfaces.Repositories;

namespace DoctorLoader.Application.Contracts.Interfaces;

public interface IApplicationUnitOfWork
{
    IDocumentRepository DocumentRepository {get;}
    IDocumentRequestRepository DocumentRequestRepository {get;}
    IDocumentResponseRepository DocumentResponseRepository {get;}

    Task SaveChangesAsync(CancellationToken cancellationToken = default);
}
