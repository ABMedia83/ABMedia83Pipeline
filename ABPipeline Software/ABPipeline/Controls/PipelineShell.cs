

namespace ABPipeline.Controls;

/// <summary>
/// Class is the base Shell Class for this Application 
/// </summary>
public class PipelineShell: ViewShell, IPipelineBase
{
    /// <summary>
    /// Get the main ViewModel to handle business 
    /// </summary>
    public PipelineViewModel? Pipeline => App.AppHost?.Services.GetService<PipelineViewModel>();

    public override void Init()
    {
        //Set the DataContext to the ViewModel 
        DataContext = Pipeline;
    }

}
