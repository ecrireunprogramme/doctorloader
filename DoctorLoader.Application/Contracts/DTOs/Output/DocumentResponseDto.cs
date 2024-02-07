using DoctorLoader.Application.Contracts.DTOs.Base;

namespace DoctorLoader.Application.Contracts.DTOs.Outputs;

public class DocumentResponseDto: BaseDto
{
    public DocumentRequestDto? DocumentRequest { get; set; }
    public IEnumerable<DocumentDto>? Documents { get; set; }
}
