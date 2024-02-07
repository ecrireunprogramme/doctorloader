namespace DoctorLoader.Domain;

public class Document: BaseAuditableEntity
{
    public string? Name { get; set; }
    public int Size { get; set; }
    public DocumentResponse? DocumentResponse { get; set; }
}
