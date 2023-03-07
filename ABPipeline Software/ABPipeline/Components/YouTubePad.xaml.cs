
namespace ABPipeline.Components;

/// <summary>
/// Componeent is Designed to setup a YouTube page and or livestream
/// </summary>
public sealed partial class YouTubePad : PipelineControl
{
    public YouTubePad()
    {
        InitializeComponent();
        Init();
    }
    public YouTubePad(TabControl _tab)
    {
        InitializeComponent();
        Init();
    }
}
