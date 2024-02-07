using DoctorLoader.Application.Models.Base;

namespace DoctorLoader.Application.Models;

internal record DocumentResponseModel: BaseModel
{
    public DocumentRequestModel? DocumentRequest { get; init; }
    public IEnumerable<DocumentModel>? Documents { get; init; }
}
