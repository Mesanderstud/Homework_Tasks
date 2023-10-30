using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static string[] DomainsList()
    {
        string[] domainsWiki = new string[784];

        int indexDomain = 0;
        for (var c1 = 'a'; c1 <= 'z'; c1++)
        {
            for (var c2 = 'a'; c2 <= 'z'; c2++)
            {
                domainsWiki[indexDomain] = $".{c1}{c2}";
                indexDomain++;
            }
        }
        return domainsWiki;
    }
    
    static async Task Main()
    {
        string[] domains = DomainsList();
        using HttpClient client = new HttpClient();

        foreach (string domain in domains)
        {
            string url = $"https://en.wikipedia.org/api/rest_v1/page/html/{domain}";

            HttpResponseMessage response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                string article = await response.Content.ReadAsStringAsync();
                SaveArticle(domain, article);
            }
            else
            {
                Console.WriteLine($"Домен {domain} не найден");
            }
        }
    }

    

    static void SaveArticle(string domain, string article)
    {
        string fileName = $"{domain}.html";
        File.WriteAllText(fileName, article);
        Console.WriteLine($"Домен {domain} сохранен");
    }
}