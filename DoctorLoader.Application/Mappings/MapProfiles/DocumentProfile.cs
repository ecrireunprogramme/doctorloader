using AutoMapper;
using DoctorLoader.Application.Models;
using DoctorLoader.Domain;

namespace DoctorLoader.Application.Mappings.MapProfiles;

internal class DocumentProfile: Profile
{
    public DocumentProfile()
    {
        CreateMap<DocumentModel, Document>()
            .ReverseMap();
    }
}
