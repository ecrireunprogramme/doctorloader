namespace DoctorLoader.Domain;

public class DocumentRequest: BaseAuditableEntity
{
    public string? Reference { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DocumentResponse? DocumentResponse { get; set; }
}
