using AutoMapper;
using DoctorLoader.Application.Contracts.DTOs.Outputs;
using DoctorLoader.Application.Models;
using DoctorLoader.Domain;

namespace DoctorLoader.Application.Mappings.MapProfiles;

internal class DocumentResponseProfile: Profile
{
    public DocumentResponseProfile()
    {
        CreateMap<DocumentResponseModel, DocumentResponse>()
            .ReverseMap();

        CreateMap<DocumentResponse, DocumentResponseDto>()
            .ReverseMap();
    }
}
