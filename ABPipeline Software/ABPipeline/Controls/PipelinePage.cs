

namespace ABPipeline.Controls;

/// <summary>
/// Class is a Special Page that links to the Oipeline ViewModel 
/// </summary>
public class PipelinePage: ViewPage,IPipelineBase
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
