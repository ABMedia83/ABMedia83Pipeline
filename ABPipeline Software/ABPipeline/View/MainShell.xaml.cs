

namespace ABPipeline.View;

/// <summary>
/// Main Shell of this Application 
/// </summary>
public sealed partial class MainShell : PipelineShell 
{
    public MainShell()
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();

        #region ViewModel Logic  
        //Set the Title of the Application 
        Pipeline!.Title = "ABPipeline";
        //Set the Frame of the Application 
        Pipeline!.Frame = mainFrame;
        //OnLog Lamba Expression 
        Pipeline.OnLog += (str) =>
        {
            statusTextBlock.Text = str;
            //Animate the Message 
            NotifyHide(statusTextBlock, 10);
        };

        #endregion 
    }

    public override void ExportSettings(string _filePath)
    {
        base.ExportSettings(_filePath);
    }

    public override void ImportSettings(string _filePath)
    {
        base.ImportSettings(_filePath);
    }
}
