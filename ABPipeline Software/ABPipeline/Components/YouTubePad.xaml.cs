



namespace ABPipeline.Components;

/// <summary>
/// Componeent is Designed to setup a YouTube page and or livestream
/// </summary>
public sealed partial class YouTubePad : PipelineControl
{
    public YouTubePad()
    {
        InitializeComponent();
        Init();
    }
    public YouTubePad(TabControl _tab)
    {
        InitializeComponent();
        Init();
        CreateTab($"YoutubeDocument{Count++}", _tab, Close);

        
        
    }

    public YouTubePad(TabControl _tab,FileInfo _info)
    {
        InitializeComponent();
        Init();
        CreateTab(_tab, _info, Close);
    }

    public override void Init()
    {
        base.Init();
        #region Lamba's 
        backgroundComboBox.SelectionChanged += (sender, e) =>
        {
            BrushItem? brush = backgroundComboBox!.SelectedItem as BrushItem;
            thumbNail!.Background = brush!.Brush!;

        };

        //Template ComboBox Lamba 
        templateComboBox.SelectionChanged += (sender, e) =>
        {
            BasicItem? item = (BasicItem)templateComboBox.SelectedItem;

            if (item != null) 
            {
               //Change the thumbnail Style 
                thumbNail.Style = (Style)this.FindResource(item.Value!.ToString()!)!;
            }
        };

        //Title Slider Lamba 
        titleSlider.ValueChanged += (sender, e) =>
        {
            titleRun.FontSize = e.NewValue;
        };

        //Content SLider Lamba 
        contentSlider.ValueChanged += (sender, e) =>
        {
            contentTextBlock.FontSize = e.NewValue;
        };
        //Footer Slider Lamba 
        footerSlider.ValueChanged += (sender, e) =>
        {
            footerRun.FontSize = e.NewValue;
        };


        //Load WebPipeline Settings 
        if (Pipeline!.WebSettings != null)
        {
            descriptionWriterBox.Text = Pipeline!.WebSettings.Desciptionn;
            tagsWriterBox.Text = Pipeline!.WebSettings.Tags;
            commentWriterBox.Text = Pipeline!.WebSettings.Comment;
        }
        #endregion


        #region Commands 

        //Save Command 
        AddCommand(ApplicationCommands.Save, (sender, e) =>
        {
            if (CurrentFile != null)
            {

            }
            else if(CurrentFile == null)
            {
                
            }
        });

        //Save As Command 
        AddCommand(DesktopCommands.SaveAs , (sender, e) =>
        {


        });



        #endregion 



    }

    void Export_Click (object sender, RoutedEventArgs e)
    {
        SaveDialogTask("Export Thumbnail", "PNG Images(.png)|*.png", (s, i) =>
        {
            //Export the Png
            CreatePng(s.FileName, 96, thumbNail);
        });
    }
       
    void Url_Click(object sender, RoutedEventArgs e) 
    {
        PushButton? push = sender as PushButton; 


      
        switch(push!.Tag)
        {
            case "Topic":
                OpenDialogTask("Load a Image for the Topic", filterImages, (o, i) =>
                    {
                        topicRun.Text = i.Name;
                        thumbNail.TopicSource = LoadSource(o.FileName);
                    });
                break;
            case "Logo":
                OpenDialogTask("Load a Image for the Logo", filterImages, (o, i) =>
                {
                    logoRun.Text = i.Name;
                    thumbNail.LogoSource = LoadSource(o.FileName);
                });
                break;
        }
    
    }


    public string? Notes
    {
        get => notesTextEditor.Text;
        set => notesTextEditor.Text = value;   
    }

    public string? Description
    {
        get => descriptionWriterBox.Text;
        set => descriptionWriterBox.Text = value;
    }
    public string? Tags
    {
        get => tagsWriterBox.Text;
        set => tagsWriterBox.Text = value;
    }

    public string? Comment
    {
        get => commentWriterBox.Text;
        set => commentWriterBox.Text = value;
    }

    public string? Title
    {
        get => titleRun.Text; 
        set => titleRun.Text = value; 
    }

    public string? ThumbContent
    {
        get => contentTextBlock.Text; 
        set => contentTextBlock.Text = value;
    }

    public string? Footer
    {
        get => footerRun.Text; 
        set => footerRun.Text = value;
    }

    public ImageSource TopicSource
    {
        get => thumbNail.TopicSource;
        set => thumbNail.TopicSource = value;
    }

    public ImageSource LogoSource
    {
        get => thumbNail.LogoSource; 
        set => thumbNail.LogoSource = value;
    }


}
