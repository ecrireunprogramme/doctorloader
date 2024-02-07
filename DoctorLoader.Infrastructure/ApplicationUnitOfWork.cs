using DoctorLoader.Application.Contracts.Interfaces;
using DoctorLoader.Application.Contracts.Interfaces.Repositories;
using DoctorLoader.Infrastructure.Repositories;

namespace DoctorLoader.Infrastructure
{
    internal class ApplicationUnitOfWork(ApplicationDbContext dbContext) : IApplicationUnitOfWork
    {
        private readonly Lazy<IDocumentRepository> _documentRepository
            = new(() => new DocumentRepository(dbContext));
        private readonly Lazy<IDocumentRequestRepository> _documentRequestRepository
            = new(() => new DocumentRequestRepository(dbContext));
        private readonly Lazy<IDocumentResponseRepository> _documentResponseRepository
            = new (() => new DocumentResponseRepository(dbContext));

        public IDocumentRepository DocumentRepository => _documentRepository.Value;
        public IDocumentRequestRepository DocumentRequestRepository => _documentRequestRepository.Value;
        public IDocumentResponseRepository DocumentResponseRepository => _documentResponseRepository.Value;

        public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
            => await dbContext.SaveChangesAsync(cancellationToken);
    }
}
