using DoctorLoader.Application.Models.Base;

namespace DoctorLoader.Application.Models;

internal class DocumentRequestModel: BaseModel
{
    public string? Reference { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
