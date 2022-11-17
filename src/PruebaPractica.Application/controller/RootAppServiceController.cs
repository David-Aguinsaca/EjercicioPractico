using System.Net;
using PruebaPractica.Domain.repository;

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
                        //Mostrar api
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

}
