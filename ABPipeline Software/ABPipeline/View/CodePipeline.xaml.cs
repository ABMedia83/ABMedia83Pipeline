
namespace ABPipeline.View;

/// <summary>
/// This Pipeline is designed to handle code that a user has written.
/// </summary>
public partial class CodePipeline : PipelinePage
{
    public CodePipeline()
    {
        InitializeComponent();
        Init();
        //ViewModel Logic 
        Pipeline.CodeTab = codeTabControl;
    }





}
