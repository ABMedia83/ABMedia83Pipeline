
namespace ABPipeline.Model;

/// <summary>
/// Thse are basic settings for the YouTube Pipeline
/// </summary>
public sealed record WebPipelinneSettings: JsonRecord
{
    public int TabIndex { get; init; }
    public string? Notes { get; init; }
    public string? Desciptionn { get; init; }
    public string? Tags { get; init; }
    public string? SketchUrl { get; init; }
    public double DrawWidth { get; init; }
    public double DrawHeight { get; init; }
    public double BrushSize { get; init; }
    public byte BrushOpacity { get; init; }
    public ModelList<string>? RecentFiles { get; init; }
}
