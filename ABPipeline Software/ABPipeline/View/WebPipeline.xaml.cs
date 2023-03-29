

using System.Diagnostics;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace ABPipeline.View;

/// <summary>
/// Pipeline is for Web Pages I want to use 
/// </summary>
public partial class WebPipeline : PipelinePage
{



    public WebPipeline()
    {
        InitializeComponent();
        Init();
    }

 


    public override void Init()
    {
        base.Init();
        Pipeline!.WebTab = webTabControl;
    }

    public override void ExportSettings(string _filePath)
    {

        WebPipelineSettings settings = new()
        {
            FormatAuthor = "Albert M. Byrd",
            FormatDescription = "Stores the Web Pipeline Settings",
            FormatName = "WebPipeline Settings",
    
            
        };

        //Write to Json File Format 
        WriteToJsonFile(settings,_filePath);

    }

    public override void ImportSettings(string _filePath)
    {
        if(Exists(_filePath))
        {
            Pipeline!.WebSettings = ReadFromJsonFile<WebPipelineSettings>(_filePath);
         


       
        }
    }


}
