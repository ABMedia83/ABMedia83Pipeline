

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

        //Export Settings Lamba 
        OnExportSettings += (file) =>
        {
            
            WebPipelineSettings settings = new()
            {
                FormatAuthor = "Albert M. Byrd",
                FormatDescription = "Stores the Web Pipeline Settings",
                FormatName = "WebPipeline Settings",
                Notes = youTubePad.Notes,
                Desciptionn = youTubePad.Description,
                Comment = youTubePad.Comment,
                Tags = youTubePad.Tags,
                ThumbTitle = youTubePad.Title,
                ThumbContent = youTubePad.ThumbContent,
                ThumbFooter = youTubePad.Footer,
                TopicSource = youTubePad.TopicSource.ToString(),
                LogoSource = youTubePad.LogoSource.ToString()
            };


            //Write to Json File Format 
            WriteToJsonFile(settings, file);

        };
        
        //Import Settigns Lamba 
        OnImoortSettings += (file) => 
        {
            Pipeline!.WebSettings = ReadFromJsonFile<WebPipelineSettings>(file);

            //Unload Settings 
            youTubePad.Notes = Pipeline.WebSettings.Notes;
            youTubePad.Description = Pipeline.WebSettings.Desciptionn;
            youTubePad.Tags = Pipeline.WebSettings.Tags;
            youTubePad.Comment = Pipeline.WebSettings.Comment;
            youTubePad.titleRun.Text = Pipeline.WebSettings.ThumbTitle;
            youTubePad.contentTextBlock.Text = Pipeline.WebSettings.ThumbContent;
            youTubePad.footerRun.Text = Pipeline.WebSettings.ThumbFooter;
            //Load Image Sources 
            youTubePad.TopicSource  = LoadSource(Pipeline.WebSettings.TopicSource!);
            youTubePad.LogoSource = LoadSource(Pipeline.WebSettings.LogoSource!);

        };

    }




}
