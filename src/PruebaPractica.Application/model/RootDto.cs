// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
//paso 3 crear modelado dto
public class InfoDto
{
    public int count { get; set; }
    public int pages { get; set; }
    public string next { get; set; }
    public object prev { get; set; }
}

public class LocationDto
{
    public string name { get; set; }
    public string url { get; set; }
}

public class OriginDto
{
    public string name { get; set; }
    public string url { get; set; }
}

public class ResultDto
{
    public int id { get; set; }
    public string name { get; set; }
    public string status { get; set; }
    public string species { get; set; }
    public string type { get; set; }
    public string gender { get; set; }
    public OriginDto origin { get; set; }
    public LocationDto location { get; set; }
    public string image { get; set; }
    public List<string> episode { get; set; }
    public string url { get; set; }
    public DateTime created { get; set; }
}

public class RootDto
{
    public InfoDto info { get; set; }
    public List<ResultDto> results { get; set; }
}
