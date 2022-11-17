namespace PruebaPractica.Application.model;

public class RootDto
{
    public InfoDto info { get; set; }
    public List<ResultDto> results { get; set; }
}

public class ResultDto
{
    public int id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public Origin origin { get; set; }
    public Location location { get; set; }
    public string image { get; set; }
    public List<string> episode { get; set; }
    public string url { get; set; }
    public DateTime created { get; set; }
}

public class InfoDto
{
    public int count { get; set; }
    public int pages { get; set; }
    public string next { get; set; }
    public object prev { get; set; }
}