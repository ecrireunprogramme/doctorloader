using AutoMapper;
using DoctorLoader.Application.Models;
using DoctorLoader.Domain;

namespace DoctorLoader.Application.Mappings.MapProfiles;

internal class DocumentRequestProfile: Profile
{
    public DocumentRequestProfile()
    {
        CreateMap<DocumentRequestModel, DocumentRequest>()
            .ReverseMap();
    }
}
