
namespace ABPipeline.Model;

/// <summary>
/// Record is used to discribe a YouTubePad Format 
/// </summary>
public sealed record YouTubePadFormat : JsonRecord
{
    public string? Notes { get; init; }
    public string? Desciptionn { get; init; }
    public string? Tags { get; init; }
    public string? Comment { get; init; }
    public string? FontFamily { get; init; }
    public double FontSize { get; init; }
}
