

namespace ABPipeline.Components;

/// <summary>
/// Interaction logic for RichhTextPad.xaml
/// </summary>
public partial class RichhTextPad : PipelineControl
{
    /// <summary>
    /// Basic Constructor 
    /// </summary>
    public RichhTextPad()
    {
        InitializeComponent();
        Init();
    }


    /// <summary>
    /// Constructor for a New Documeent 
    /// </summary>
    /// <param name="_tab"></param>
    public RichhTextPad(TabControl _tab)
    {
        InitializeComponent();
        Init();
    }

    /// <summary>
    /// Constructor for opening a a file 
    /// </summary>
    /// <param name="_tab"></param>
    /// <param name="_info"></param>
    public RichhTextPad(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();
    }





    public override void Init()
    {
        base.Init();

        
    }


}
