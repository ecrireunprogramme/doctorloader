namespace DoctorLoader.Domain;

public class DocumentResponse: BaseAuditableEntity
{
    public DocumentRequest? DocumentRequest { get; set; }
    public Guid DocumentRequestId { get; set; }
    public IEnumerable<Document>? Documents { get; set; }
}
