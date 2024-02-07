using DoctorLoader.Application.Contracts.DTOs.Base;

namespace DoctorLoader.Application.Contracts.DTOs.Outputs;

public class DocumentDto: BaseDto
{
    public string? Name { get; set; }
    public int Size { get; set; }
}
