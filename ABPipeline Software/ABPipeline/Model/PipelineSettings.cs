

using System.Diagnostics.Eventing.Reader;

namespace ABPipeline.Model;
/// <summary>
/// Main Settings for the Shell of the Application 
/// </summary>
public record PipelineSettings : JsonRecord
{
    public WindowState WindowState { get; init; }
    public bool ShowStatusBar { get; init; }
    public string? QuickNote { get; init; }
    public PipelineState State {get; init; }
    public ModelList<LogRecord>? Logs { get; init; }
    public ModelList<FileRecord>? RecentFiles { get; init; }
}
