

namespace ABPipeline.View;

/// <summary>
/// Main Shell of this Application 
/// </summary>
public sealed partial class MainShell : PipelineShell
{

    PipelineState state;

    public MainShell()
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();

        #region ViewModel Logic  
        //Set the Title of the Application 
        Pipeline!.Title = "ABPipeline";
        //Set the Frame of the Application 
        Pipeline!.Frame = mainFrame;


        //OnLog Lamba Expression 
        Pipeline.OnLog += (str) =>
        {
            statusTextBlock.Text = str;
            //Animate the Message 
            NotifyHide(statusTextBlock, 10);
        };

        #endregion

        #region Other Operations 

        State = PipelineState.Web;


        #endregion 

        #region  Commaands 

        AddCommand(ApplicationCommands.New, (sender, e) =>
        {
            newDialog.Show("New Project", "Select a Project");
        });

        AddCommand(ApplicationCommands.Open, (sender, e) =>
        {

        });


        AddCommand(DesktopCommands.Quit, (sender, e) =>
        {
            Close();
        });

        #endregion

        #region Import/Export/Close Lamba


        ImportSettings(mainSettingsPath);


        //Close Lamba Expression 
        Closed += (sender, e) =>
        {
            //Export Your Settings 
            ExportSettings(mainSettingsPath);
        };

        #endregion


    }

    void ShowStatus_Click(object sender, RoutedEventArgs e)
    {
        var showStatus = statusMenuItem.IsChecked switch
        {
            true => statusBar.Visibility = Visibility.Visible,
            false => statusBar.Visibility = Visibility.Collapsed,
        };
    }


    void Window_Click(object sender, RoutedEventArgs e)
    {
        MenuItem item = (MenuItem)sender;

        switch (item.Tag)
        {
            case "Design":
                State = PipelineState.Design;
                break;
      
            case "Notes":
                State = PipelineState.Notes;
                break;
            case "Web":
                State = PipelineState.Web;
                break;
          
        }


    }

    void New_Cick(object sender, RoutedEventArgs e)
    {
        var opt = sender as OptionButton;


        switch (opt!.Tag)
        {
            case "DevPad":

                break;
            case "WriterPad":

                break;
            case "YouTubePad":

                break;
            case "YouTube Tumbniail":

                break;
        }

        newDialog.Hide();
    }

    public override void ExportSettings(string _filePath)
    {
        //Create your Pipeline Settings 
        PipelineSettings settings = new()
        {
            FormatAuthor = "Albert M. Byrd",
            FormatDescription = "Basic settings for the Shell of the Application",
            FormatName = "APPipeline Settings",
            WindowState = WindowState,
            ShowStatusBar = statusMenuItem.IsChecked,
            Logs = Pipeline!.Logs,
            RecentFiles = Pipeline.Files,
            State = State
        };

        //Save your Pipeline Settings 
        WriteToJsonFile(settings, _filePath);
        //Export your other settings here 
       


    }

    public override void ImportSettings(string _filePath)
    {
        if (Exists(_filePath))
        {
            //Load your main Pipeline settings 
            var settings = ReadFromJsonFile<PipelineSettings>(_filePath);

            //Pattern Matching 
            (WindowState, State, Pipeline!.Logs, Pipeline.Files) = (settings.WindowState, settings.State, settings.Logs!, settings.RecentFiles!);
            statusMenuItem.IsChecked = settings.ShowStatusBar;
            //Set the Status Visiblity 
            var statusShow = settings.ShowStatusBar switch
            {
                true => statusBar.Visibility = Visibility.Visible,
                false => statusBar.Visibility = Visibility.Collapsed,
            };



   
        }
    }

    public PipelineState State
    {
        get => state;
        set
        {
            state = value;

            switch (value)
            {
                case PipelineState.Design:
                    //Go to the Design Pipeline Page 
                    Pipeline!.NavigateFrame(DesignPipeLine!);
                    //Send a message to the Applicaton 
                    Pipeline.Message("You're in the Design Pipeline.", false);
                    //Change the Window/Shell Title 
                    Pipeline.Title = "ABPipeline - Design";
                    break;
                case PipelineState.Notes:
                    //Jump to the Notes Pipeline 
                    Pipeline!.NavigateFrame(NotesPipeeLine!);
                    //Send a message to the Applicaton 
                    Pipeline.Message("You're in the Notes Pipeline.", false);
                    //Change the Window/Shell Title 
                    Pipeline.Title = "ABPipeline - Notes";
                    break;

                case PipelineState.Web:
                    //Jump to the Web Pipeline 
                    Pipeline!.NavigateFrame(WebPipeLine!);
                    //Send a message to the Applicaton 
                    Pipeline.Message("You're in the Web Pipeline.", false);
                    //Change the Window/Shell Title 
                    Pipeline.Title = "ABPipeline - Web";
                    break;


            }
        }
    }
}
