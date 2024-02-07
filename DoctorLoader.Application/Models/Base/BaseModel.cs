namespace DoctorLoader.Application.Models.Base;

internal abstract record BaseModel
{
    public Guid Id { get; init; }
}
