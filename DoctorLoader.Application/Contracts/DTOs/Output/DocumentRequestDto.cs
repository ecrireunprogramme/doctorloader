using DoctorLoader.Application.Contracts.DTOs.Base;

namespace DoctorLoader.Application.Contracts.DTOs.Outputs;

public class DocumentRequestDto: BaseDto
{
    public string? Reference { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
}
