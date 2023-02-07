



namespace ABPipeline.ViewModels;

/// <summary>
/// Main ViewModel of this Application 
/// </summary>
public sealed class PipelineViewModel : ViewModel
{
    #region Field's 
    TabControl? designTab, mediaTab, noteTab, youTubeTab;
    ModelList<ColorItem>? colors = new();
    ModelList<ThemeItem>? themes = new();
    ModelList<FontItem>? fonts = new();
    #endregion

    #region Tab Properties 

    public TabControl? DesignTab
    {
        get => designTab;
        set { designTab = value; OnPropertyChanged("DesignTab"); }

    }
    public TabControl? MediaTab
    {
        get => mediaTab;
        set { mediaTab = value; OnPropertyChanged("MediaTab"); }
    }

    public TabControl? NoteTab
    {
        get => noteTab;
        set { noteTab = value; OnPropertyChanged("NoteTab"); }
    }

    public TabControl? YouTubeTab
    {
        get  => youTubeTab;  
        set { youTubeTab = value; OnPropertyChanged("YoutubeTab"); }
    }



    #endregion

    #region Dynamic List Properties 
    /// <summary>
    /// Get or set Colors you want to use 
    /// </summary>
    public ModelList<ColorItem>? Colors
    {
        get => colors; 
        set { colors = value; OnPropertyChanged("Colors"); }
    } 
    /// <summary>
    /// Get or set Themes that you want to use 
    /// </summary>
    public ModelList<ThemeItem>? Themes
    {
        get => themes; 
        set { themes = value; OnPropertyChanged("Themes"); }
    }
    /// <summary>
    /// Get or set the List of Fonts you want to work wih. 
    /// </summary>
    public ModelList<FontItem>? Fonts
    {
        get => fonts; 
        set { fonts = value; OnPropertyChanged("Fonts"); }

    }

    #endregion




}

