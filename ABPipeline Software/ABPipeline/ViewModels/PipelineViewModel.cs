



namespace ABPipeline.ViewModels;

/// <summary>
/// Main ViewModel of this Application 
/// </summary>
public sealed class PipelineViewModel : ViewModel
{
    #region Field's 
    WebPipelineSettings? websettings;
    TabControl? designTab, noteTab, codeTab, webTab;
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


    public TabControl? NoteTab
    {
        get => noteTab;
        set { noteTab = value; OnPropertyChanged("NoteTab"); }
    }

    public TabControl? CodeTab
    {
        get => codeTab;
        set { codeTab = value; OnPropertyChanged("CodeTab"); }
    }

    public TabControl? WebTab
    {
        get  => webTab;  
        set { webTab = value; OnPropertyChanged("WebTab"); }
    }



    #endregion

    #region Dynamic Properties 

    public WebPipelineSettings? WebSettings
    {
        get => websettings;
        set { websettings = value; OnPropertyChanged("WebSettings"); }
    }

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

    #region Settings Path's 

    public static string mainSettingsPath => "settings.json";

    public static string webPipelinePath = "websettings.json";


    #endregion

    #region Filter Path's    
    /// <summary>
    /// Get All Format Filter for Save / Open Dialog 
    /// </summary>
    public static string filterAll => "AB Files(.absketch,.abcode,.abenote,.abtube)|*.abnote;*.absketch;*abcode;*.abtube;|All Formats (.)|*.*|Code Files(.json,.abjson,.html,.htm,.css,.js,.scss,.ts,.php,.cs,.py,.cpp,.h,.cshtml,.razor)|*.html;*.htm;*.css;*.scss;*.js;*.ts;*.php;*.cpp;*.h;*.cs;*.py;*.cshtml;*.json;*.abjson|Image Files(.png,.jpg,.jpeg,.jiff,.tiff,.gif)|*.png;*.jpg;*.jpeg;*.jiff;*.tiff;*.gif; | PDF Format(.pdf) | *.pdf|Video Format(.mp4)|*.mp4";

    /// <summary>
    /// Get Filter for exporting Images 
    /// </summary>
    public static string filterImages => "All Image(.png,.jpeg,.jpg,.jiff,.tiff,.gif) | *.png;*.jpg;*.jpeg;*.jiff;*.tiff;*.gif|Png Format(.png)|*.png| Jpeg Format(.jpg,.jpeg,.jiff)|*.jpg;*.jpeg;*.jiff|Tiff Format(.tiff)|*.tiff|Gif Format (.gif)|*.gif";


    public static string filterRichText => "Rich Text Format(.rtf)|*.rtf";

    /// <summary>
    /// Gets a PDF Filter for reading PDF FIles
    /// </summary>
    public static string filterPDF => "PDF Format(.pdf) | *.pdf";

    /// <summary>
    /// Filter is desinged for the Notebook format 
    /// </summary>
    public static string filterNote => "AB Note Formats(.abNote,.txt,.)|*.abnote;*.txt;*.*";

    /// <summary>
    /// Filter is designed to Open a SKtch File 
    /// </summary>
    public static string filterSketch => "AB SketchFormat(.absketch)|*.absketch";

    /// <summary>
    /// Get's a Filter for reading Video 
    /// </summary>
    public static string filterVideo => "Video Format(.mp4)|*.mp4";
    /// <summary>
    /// Get's filter to save a Youtube Project 
    /// </summary>
    public static string filterYouTube => "AB Youtube Project Format(.abtube)|*.abtube";



    #endregion



    #region Settings Path 

    public static string? mainsettings => "settings.json";
    public static string? webpipelinesettings => "webpipeline.json";

    #endregion



    #region  Default Pages 

    /// <summary>
    /// Get the Code Pipeline Paage 
    /// </summary>
    public static CodePipeline? CodePipeLine { get; set; } = App.AppHost?.Services.GetService<CodePipeline>();

    /// <summary>
    ///Gets the Design Pipeline Page 
    /// </summary>
    public static DesignPipeline? DesignPipeLine { get; set; } = App.AppHost?.Services.GetService<DesignPipeline>();
    /// <summary>
    /// Gets the Notes Pipeline Page
    /// </summary>
    public static NotesPipeline? NotesPipeeLine { get; set; } = App.AppHost?.Services.GetService<NotesPipeline>();
   /// <summary>
   /// Gets the Web Pipeline Page 
   /// </summary>
    public static WebPipeline? WebPipeLine { get; set; } = App.AppHost?.Services.GetService<WebPipeline>();



    #endregion




}

