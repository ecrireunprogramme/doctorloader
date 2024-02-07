using AutoMapper;
using DoctorLoader.Application.Contracts.DTOs.Outputs;
using DoctorLoader.Application.Models;
using DoctorLoader.Domain;

namespace DoctorLoader.Application.Mappings.MapProfiles;

internal class DocumentProfile: Profile
{
    public DocumentProfile()
    {
        CreateMap<DocumentModel, Document>()
            .ReverseMap();

        CreateMap<Document, DocumentDto>() 
            .ReverseMap();
    }
}
