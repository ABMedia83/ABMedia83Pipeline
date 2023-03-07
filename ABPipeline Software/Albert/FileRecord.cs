



namespace Albert;

/// <summary>
/// Record stores a File Path and Directory location 
/// </summary>
public record FileRecord
{
    public FileRecord()
    {
        //Do Nothing 
    } 
    public FileRecord(string _file)
    {
       FileInfo Info = new FileInfo(_file);

        Name = Info.Name;
        FullName = Info.FullName;
        DirectoryName = Info.DirectoryName;
        Extension = Info.Extension;

        
    }

    

    public string? Name { get; init; }
    public required string? FullName { get; init; }
    public string? DirectoryName { get; init; }
    public string? Extension { get; init; }

    public override string ToString()
    {
        return $"Name: {Name}\nDirectory: {DirectoryName}\nExtension: {Extension}";
    }

}
