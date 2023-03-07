

namespace ABPipeline.Model;

public record WebPadFormat: JsonRecord 
{
    public string? Url { get; init; } 
    public string? Notes { get; init; } 
    public string? SketchUrl { get; init; }
}
