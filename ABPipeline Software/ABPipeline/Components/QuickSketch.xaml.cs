
namespace ABPipeline.Components;

/// <summary>
/// Interaction logic for QuickSketch.xaml
/// </summary>
public partial class QuickSketch : PipelineControl
{
    public QuickSketch()
    {
        InitializeComponent();
        Init();
    }

    public override void Init()
    {
        base.Init();

        //sizeComboBox Lamba Selection Expression  
        sizeComboBox.SelectionChanged += (sender, e) =>
        {
            FormatItem item = (FormatItem)sizeComboBox.SelectedItem;

            drawCanvas.Width = item.Width;
            canvasGrid.Width = item.Width;
            drawCanvas.Height = item.Height;
            canvasGrid.Height = item.Height;


        };

        //brushSizeSlider Lamba Expresion 
        brushSIzeSlider.ValueChanged += (sender, e) =>
        {
            drawCanvas.BrushSize = e.NewValue;
        };
        //Export COmmand 
        AddCommand(DesktopCommands.Export, (sender, e) =>
        {
            SaveDialogTask("Export to Png", "PNG Format(.png)|*.png", (s, i) =>
            {
                //Export just the Draw Canvas 
                CreatePng(s.FileName, 96, drawCanvas);
                //Notify the Apploication 
                Pipeline!.Message($"You have exported the {i.Name} into the {i.DirectoryName} directory." , true);
            });
        });

    }

    void SelectType_Click(object sender, RoutedEventArgs e)
    {
        OptionButton? opt = sender as OptionButton;

        switch(opt!.Tag)
        {
            //Draw 
            case "Draw": drawCanvas.DrawMode = DrawMode.Draw; break;
             //Erase 
            case "Erase": drawCanvas.DrawMode = DrawMode.Erase; break;
              //EraseByStroke  
            case "EraseByStroke": drawCanvas.DrawMode = DrawMode.EraseByStroke; break;
             //Select   
            case "Select": drawCanvas.DrawMode = DrawMode.Select; break;
               
        }

  

       


    }


    void Opacity_Click(object sender, RoutedEventArgs e)
    {
        var opt = sender as OptionButton;

        switch (opt!.Tag)
        {
            case "Tag": drawCanvas.BrushOpacity = 75; break;
            case "Marker": drawCanvas.BrushOpacity = 125; break;
            case "Pen": drawCanvas.BrushOpacity = 255; break;
        }
    }
    /// <summary>
    /// Get or set the DrawCanvas 
    /// </summary>
    public DrawCanvas Canvas
    {
        get => drawCanvas;
        set => drawCanvas = value;
    }
    /// <summary>
    /// Get or set the Brush Size 
    /// </summary>
    public double BrushSize
    {
        get => drawCanvas.BrushSize;
        set => drawCanvas.BrushSize = value;
    }
    /// <summary>
    /// Geet or set the Brush Opacity 
    /// </summary>
    public byte BrushOpacity
    {
        get => drawCanvas.BrushOpacity;
        set => drawCanvas.BrushOpacity = value;
    }
    /// <summary>
    /// Get or set the draw Width 
    /// </summary>
    public double DrawWidth
    {
        get => canvasGrid.Width;
        set
        {
            canvasGrid.Width = value;
            drawCanvas.Width = value;
        }
    }

    /// <summary>
    /// Get or set the Draw Height 
    /// </summary>
    public double DrawHeight
    {
        get => canvasGrid.Height;
        set
        {
            canvasGrid.Height = value;
            drawCanvas.Height = value;
        }
    }

}
