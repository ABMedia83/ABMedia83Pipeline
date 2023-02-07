



namespace ABPipeline.Controls;

/// <summary>
/// Interface links a Control and or class to the main ViewModel 
/// </summary>
public interface IPipelineBase
{
    PipelineViewModel? Pipeline { get; }
}
