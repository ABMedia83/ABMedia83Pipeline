

namespace ABPipeline.Components;

/// <summary>
/// This Component is desgned to write code. 
/// </summary>
public sealed partial class DevPad : PipelineControl 
{
    public DevPad()
    {
        InitializeComponent();
        Init();
    }
    /// <summary>
    /// This Contructor is designed to create a new Code file 
    /// </summary>
    /// <param name="_tab"></param>
    public DevPad(TabControl _tab)
    {
        InitializeComponent();
        Init();
        CreateTab($"Code{Count++}", _tab, Close);
    }
    /// <summary>
    /// Constructor grabs text from another place to 
    /// </summary>
    /// <param name="_tab"></param>
    /// <param name="_text"></param>
    public DevPad(TabControl _tab, string _text,string  _title)
    {
        InitializeComponent();
        Init();

    }
    /// <summary>
    /// Constructor Load's a Code file 
    /// </summary>
    /// <param name="_tab">Tab Control used</param>
    /// <param name="_info">Grab the File</param>
    public DevPad(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();

    }

    public override void Init()
    {
        base.Init();
        ProjectType = "Code File";
    }
}

