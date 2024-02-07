using DoctorLoader.Application.Models.Base;

namespace DoctorLoader.Application.Models;

internal class DocumentResponseModel: BaseModel
{
    public DocumentRequestModel? DocumentRequest { get; set; }
    public IEnumerable<DocumentModel>? Documents { get; set; }
}
