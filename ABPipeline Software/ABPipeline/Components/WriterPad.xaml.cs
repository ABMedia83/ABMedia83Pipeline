

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
        CreateTab($"WriterDocument{Count++}", _tab, Close);
    }
    /// <summary>
    /// Constructor for opening a writer Document 
    /// </summary>
    /// <param name="_tab"></param>
    /// <param name="_file"></param>
    public WriterPad(TabControl _tab, FileInfo _info)
    {
        InitializeComponent();
        Init();
        CreateTab(_tab, _info, Close);

    }

    public override void Init()
    {
        base.Init();

        styleComboBox.SelectionChanged += (sender, e) =>
        {
            NoteStyle item = (NoteStyle)styleComboBox.SelectedItem;

            writerBox.Foreground = item.TextBrush;
            writerBox.Background = item.Background;

        };

        fontComboBox.SelectionChanged += (sender, e) =>
        {
            FontItem item = (FontItem)fontComboBox.SelectedItem;
            writerBox.FontFamily = item.FontFamily;
        };

        fontSizeSlider.ValueChanged += (sender, e) =>
        {
            writerBox.FontSize = e.NewValue;
        };
    }




}
