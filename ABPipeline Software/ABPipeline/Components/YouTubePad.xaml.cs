
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
        get => titleTextBox.Text; 
        set => titleTextBox.Text = value; 
    }

    public string? ThumbContent
    {
        get => contentTextBlock.Text; 
        set => contentTextBlock.Text = value;
    }

    public string? Footer
    {
        get => footerTextBox.Text; 
        set => footerTextBox.Text = value;
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
