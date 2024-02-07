using DoctorLoader.Application.Models.Base;

namespace DoctorLoader.Application.Models;

internal class DocumentModel: BaseModel
{
    public string? Name { get; set; }
    public int Size { get; set; }
}
