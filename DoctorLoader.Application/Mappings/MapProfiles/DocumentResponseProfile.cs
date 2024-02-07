using AutoMapper;
using DoctorLoader.Application.Models;
using DoctorLoader.Domain;

namespace DoctorLoader.Application.Mappings.MapProfiles;

internal class DocumentResponseProfile: Profile
{
    public DocumentResponseProfile()
    {
        CreateMap<DocumentResponseModel, DocumentResponse>()
            .ReverseMap();
    }
}
