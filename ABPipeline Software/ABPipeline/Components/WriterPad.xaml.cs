

namespace ABPipeline.Components;

/// <summary>
/// Component is designed to Write and Spell Check Text Documents 
/// </summary>
public sealed partial class WriterPad : PipelineControl
{
    /// <summary>
    /// Main Constructor for the Writer Pad 
    /// </summary>
    public WriterPad()
    {
        InitializeComponent();
        Init();
    }
    /// <summary>
    /// Constructor for new Writer Document 
    /// </summary>
    /// <param name="_tab"></param>
    public WriterPad(TabControl _tab)
    {
        InitializeComponent();
        Init();
    }
    /// <summary>
    /// Constructor for opening a writer Document 
    /// </summary>
    /// <param name="_tab"></param>
    /// <param name="_file"></param>
    public WriterPad(TabControl _tab, FileInfo _file)
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();
    }




}
