namespace FunnyMediaStorage.Domain.Entities;

public class MediaFile
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }

    public string FileName { get; set; } = null!;
    public string StoragePath { get; set; } = null!;

    public string MediaType { get; set; } = null!;
    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }
}