using System.Net;
using PruebaPractica.Domain.repository;
using System.Text.Json;

namespace PruebaPractica.Application.controller;

public class RootAppServiceController : IRootRepository
{
    public ICollection<Root> MetodoGet()
    {
         /*  var client = new RestClient("https://rickandmortyapi.com/api/character");
         client.Timeout = -1;
         var request = new RestRequest(Method.GET);
         IRestResponse response = client.Execute(request);
         Console.WriteLine(response.Content); */

        var url = "https://rickandmortyapi.com/api/character";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        try
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return null;

                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        
                        //return responseBody;
                        Console.WriteLine(responseBody);
                    }
                }
            }
        }
        catch (WebException ex)
        {
            // Handle error
        }

        return null;
    }

    public async Task<Root>ObtenerApiTask(){


        var url = "https://rickandmortyapi.com/api/character";

        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(url);
        var content = await response.Content.ReadAsByteArrayAsync();
        var res = JsonSerializer.Deserialize<Root>(content);
        return res;

    }

}
