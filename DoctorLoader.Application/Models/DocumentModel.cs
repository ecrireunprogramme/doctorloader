using DoctorLoader.Application.Models.Base;

namespace DoctorLoader.Application.Models;

internal record DocumentModel: BaseModel
{
    public string? Name { get; init; }
    public int Size { get; init; }
}
