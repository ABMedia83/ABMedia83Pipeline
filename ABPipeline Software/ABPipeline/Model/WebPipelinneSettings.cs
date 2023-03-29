
namespace ABPipeline.Model;

/// <summary>
/// Thse are basic settings for the YouTube Pipeline
/// </summary>
public sealed record WebPipelineSettings: JsonRecord
{
    public int TabIndex { get; init; }
    public string? Notes { get; init; }
    public string? Desciptionn { get; init; }
    public string? Tags { get; init; }
    public string? Comment { get; init; }
    public string? ThumbTitle { get; init; }
    public string? ThumbContent { get; init; }
    public string? ThumbFooter { get; init; }
    public string? TopicSource { get; init; }
    public string? LogoSource { get; init; }
    public ModelList<string>? RecentFiles { get; init; }
}
