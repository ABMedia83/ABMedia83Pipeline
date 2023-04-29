
namespace ABPipeline.Components;

/// <summary>
/// Component is designed to create Snippeet for Code Editor's 
/// </summary>
public sealed partial class SnippetPad : PipelineControl
{

    //Field's 
    SnippetMode mode; 

    public SnippetPad()
    {
        InitializeComponent();
        Init();
    }
    public SnippetPad(TabControl _tab)
    {
        InitializeComponent();
        Init();
        CreateTab($"Snippet{Count++}", _tab, Close);
    }

    public SnippetPad(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();
        CreateTab(_tab, _info, Close);
    }



    public override void Init()
    {
        base.Init();
        
    }


    public SnippetMode Mode
    {
        get => mode; 
        set
        {
            mode = value; 
            
            switch(value)
            {
                case SnippetMode.VisualStudio:

                    break;
                case SnippetMode.VisualStudioCode:

                    break;

            }
        }
    }
}
