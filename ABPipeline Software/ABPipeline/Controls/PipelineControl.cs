

namespace ABPipeline.Controls;

/// <summary>
/// Class is a special Control thatlinks directly to the Pipeline ViewModel 
/// </summary>
public class PipelineControl: ViewControl, IPipelineBase
{
    /// <summary>
    /// Get the main ViewModel to handle business 
    /// </summary>
    public PipelineViewModel? Pipeline => App.AppHost?.Services.GetService<PipelineViewModel>();

    /// <summary>
    /// Init the Pipeline ViewModel with this base method 
    /// </summary>
    public override void Init()
    {
        //Set the DataContext to the ViewModel 
        DataContext = Pipeline;
    }
    public override void Close()
    {
        TabDialog.Show("Closing Tab", $"Do you want to close this {ProjectType }?", "Close", "Cancel", () =>
        {
            //Close the Tab 
            RemoveTab();
            //Send Message to the Applicaton 
            
        
        });
    }
    /// <summary>
    /// Get or set the  name of the  Proect Type
    /// </summary>
    public string? ProjectType { get; set; }
}
