
namespace ABPipeline.View;

/// <summary>
/// Interaction logic for NotesPipeline.xaml
/// </summary>
public sealed partial class NotesPipeline : PipelinePage
{
    public NotesPipeline()
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();
        Pipeline!.NoteTab = noteTabControl;

    }
}
