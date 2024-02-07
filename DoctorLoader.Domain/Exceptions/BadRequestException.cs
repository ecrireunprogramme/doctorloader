namespace DoctorLoader.Domain;

internal abstract class BadRequestException(string message) : Exception(message)
{
}