using System.Net;
using Curso.ComercioElectronico.Domain;

namespace Curso.ComercioElectronico.Application;

public class RootAppService:IRootRepository
{
    
     public ICollection<Root> MetodoGet()
    {
        var url = "https://rickandmortyapi.com/api/character";
        var request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";
        
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return null;

                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();
                        
                        Console.WriteLine(responseBody);
                    }
                }
            }
        }
      

        return null;
}
}