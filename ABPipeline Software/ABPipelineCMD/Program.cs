

namespace ABPipelineCMD;


public class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        //Run Start Method 
        Start();
        
    }
    public static void Start()
    {
        WriteTitle("AB Pipeline CMD 1.0");
        WriteLine("Select a Program");
        WriteLine("File Transfr = ft");
        WriteLine("Test Dialog = td");
        Write("Run Program: ");
        var program = ReadLine();
       
        switch(program)
        {
            case "ft": FileTransfer(); break;
            //case "td": TestDialog(); break;
            default: WriteExit(Start); break;
        }



    }


    static void HtmlTest()
    {
        WriteTitle("Html Test");
        Write("Start Html Test(yes/no)");
        var awnser = ReadLine();
        switch(awnser)
        {
            //no and or or any other awnser Exit or not
            default: WriteExit(Start, HtmlTest); break;
            //For Yes and or y
            case "yes" or "y" or "Yes" or "Y":
                    Write("Title: ");
                    var title = ReadLine();



                break;
        }
    }


    /// <summary>
    /// File Transfer Program 
    /// </summary>
    static void FileTransfer()
    {
        WriteTitle("File Transfer");
        //Field's 
        string? opentitle = "Select Files";
        string? filter = "All Format(.)|*.*";
        string? savetitle = "Transfer Fiels (Type Export for a FileName)";
        string? filter2 = "Json Format(.json)|*.json";
        ModelList<FileInfo> files = new();

        Write("Start File Transfer(y/n): ");

        string? choice = ReadLine();

        switch (choice)
        {
            case "y" or "Y" or "Yes" or "yes":
                //Open Dialog Task 
                OpenDialogTask(opentitle, filter, (o, i) =>
                {
                    //Turn on Multiselect 
                    o.Multiselect = true;
                    foreach (string file in o.FileNames)
                    {
                        FileInfo info = new FileInfo(file);
                        files.Add(info);
                    }

                    foreach (FileInfo info in files)
                    {
                        WriteLine(info.Name);
                    }
                    Write("Transfer these files?(y/n)");
                    string? choice2 = ReadLine();

                    switch (choice2)
                    {
                        case "y":
                            SaveDialogTask(savetitle, filter2, (s, i) =>
                            {
                                string? dir = i.DirectoryName;

                                ModelList<FileRecord> exportFiles = new();

                                files.ForEach((file) =>
                                {
                                    exportFiles.Add(new FileRecord(file.FullName));
                                });

                                WriteToJsonFile(exportFiles, s.FileName);

                                foreach (FileInfo info in files)
                                {
                                    //Copy Transfer
                                    string? newpath = Path.Combine(dir!, info.Name!);
                                    //double count = 0;
                                    if (File.Exists(newpath))
                                    {
                                        WriteLine($"{info!.Name} already Exists in this directory.");
                                    }
                                    else
                                    {
                                        info.CopyTo(newpath);
                                    }



                                }

                            });

                            WriteExit(Start, FileTransfer);

                            break;
                        default:
                            WriteExit(Start, FileTransfer);
                            files.Clear();
                            break;
                    }

                });
                break;
            default:
                WriteExit(Start, FileTransfer);
                break;
        }

    }

    static void TestDialog()
    {
        WriteTitle("Test Dialog");
        Write("Beghin (y/n): ");
        var begin = ReadLine();

        switch(begin)
        {
            case "y" or "yes":
                OpenDialogTask("Test Open", "All Files(.)|*.*", (o, i) =>
                {
                    WriteLine($"You have opened {i.Name} from the {i.DirectoryName}");
                
                });

                WriteExit(Start, TestDialog);
                break;
            default: WriteExit(Start,TestDialog); break;
        }
    }




}