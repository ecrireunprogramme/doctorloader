using DoctorLoader.Application.Models.Base;

namespace DoctorLoader.Application.Models;

internal record DocumentRequestModel: BaseModel
{
    public string? Reference { get; init; }
    public string? Title { get; init; }
    public string? Description { get; init; }
}
