namespace DoctorLoader.Domain;

internal abstract class NotFoundException(string message): Exception(message)
{
}
