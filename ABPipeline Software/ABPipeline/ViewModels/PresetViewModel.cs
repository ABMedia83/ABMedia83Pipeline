

namespace ABPipeline.ViewModels;

public sealed class PresetViewModel : ViewModel
{
    #region PreMade Lists 

    public ModelList<BasicItem> YoutubeThumbnailPreset => new()
    {
        new("Template 1", "YoutubeOne"),
        new("Template 2", "YoutubeTwo"),
        new("Template 3", "YoutubeThree"),
        new("Template 4", "YoutubeNoContent"),
         new("Template 5", "YoutubeNoTopic"),
    };

    /// <summary>
    /// Prest FontFamiles to use in Application 
    /// </summary>
    public ModelList<FontItem> NoteFontPresets => new()
    {
        new("Calibri"),
        new("Courier New"),
        new("Consolas"),
        new("DejaVu Serif"),
        new("Georgia"),
        new("Segoe Print"),
        new("Segoe UI"), 
        new("Urbanist")

    };

    /// <summary>
    /// Preset list for Note Stiels
    /// </summary>
    public ModelList<NoteStyle> NoteStylePrests => new()
    {
        new("BlackWhite","#ffffff","#0000000"),
        new("ChaulkBoard","ffffff","#FF046318"),
        new("BluePrint","#ffffff","#FF161479"),
        new("RedPrint", "#ffffff","#B00D00")
    };




    public ModelList<FontItem> CodeFontPrests => new()
    {
        new("Consolas"),
        new("Courier New"),
         new("Segoe Print")
    };
    /// <summary>
    /// Preset DrawCanvas Colors 
    /// </summary>
    public ModelList<InkItem> PresetDrawCanvasList => new()
    {
        new("ChaulkBoard", HexColor("#ffffff"), HexColor("#FF046318")),
        new("BlackBoard", HexColor("#ffffff"), HexColor("#FF232323")),
        new("BlueBoard", HexColor("#ffffff"), HexColor("#FF161479")),
        new("WhiteBoard", HexColor("#0000000"), HexColor("#FFA7A7A7")),
        new("WhiteBoardBlue", HexColor("#FF161479"), HexColor("#FFA7A7A7"))

    };
    /// <summary>
    /// Preset DrawCanvas Formats 
    /// </summary>
    public ModelList<FormatItem> PresetFormats => new()
    {
        new("HD Standard", 1920, 1080),
        new("HD Square", 1080, 1080),
        new("Character Sheet", 1080, 1440),
        new("Comic Strip", 1274,1966),
        new("Screen", 1365, 768),
        new("720p", 1240, 768),
        new("Medium Square", 504, 504),
        new("Small Square", 300, 300),
        new("Small Square", 100, 100)
    };



    public ModelList<BrushItem> PresetBackgroundBrushes => new()
    {
        new("Primary", (SolidColorBrush)App.Current.Resources["Primary"]),
          new("Secondary", (SolidColorBrush)App.Current.Resources["Secondary"]),
        new("Accent", (SolidColorBrush)App.Current.Resources["abAccent"]),
        new("Accent2", (SolidColorBrush)App.Current.Resources["abAccent2"]),
        new("Accent3", (SolidColorBrush)App.Current.Resources["abAccent3"]),
        new("LightBlue", (SolidColorBrush)App.Current.Resources["abAccent4"]),
        new("LihtBlue2", (SolidColorBrush)App.Current.Resources["abAccent5"]),
        new("ChaulkBoard", (SolidColorBrush)App.Current.Resources["abChulkBoard"]),
        new("BlackBoard", (SolidColorBrush)App.Current.Resources["abBlackBoard"]),
        new("BlueBoard", (SolidColorBrush)App.Current.Resources["abBlueBoard"]),
        new("RadialChrome", (RadialGradientBrush)App.Current.Resources["abRadialChrome"]),
        new("RadialChrome2", (RadialGradientBrush)App.Current.Resources["abRadialChrome2"]),
        new("RadialChrome3", (RadialGradientBrush)App.Current.Resources["abRadialChrome3"]),
        new("RadialChrome4", (RadialGradientBrush)App.Current.Resources["abRadialChrome4"]),
        new("RadialChromeRed", (RadialGradientBrush)App.Current.Resources["abRadialChromeRed"]),
        new("RadialChromeGreen", (RadialGradientBrush)App.Current.Resources["abRadialChromeGreen"]),
    };



    #endregion

}
