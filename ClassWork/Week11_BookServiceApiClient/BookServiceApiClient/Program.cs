using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace BookServiceApiClient
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            RunAsync().GetAwaiter().GetResult();
        }
  
        
        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("your api url");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                string json;
                BookChapter chapter;
                HttpContent content;
                HttpResponseMessage response;

                ////get all chapters
                //response = await client.GetAsync("/api/BookChapters/allchapters");

                //if (response.IsSuccessStatusCode)
                //{
                //    json = await response.Content.ReadAsStringAsync();

                //    // Console.WriteLine(json);

                //    IEnumerable<BookChapter> chapters =
                //        JsonConvert.DeserializeObject<IEnumerable<BookChapter>>(json);
                //    foreach (BookChapter c in chapters)
                //    {
                //        Console.WriteLine(c);
                //    }
                //}
                //else
                //    Console.WriteLine("Internal Server error");

                //// get the specified chapter
                //string id = "bce79e8d-6e29-4594-8764-c8e2a0583032";

                //response = await client.GetAsync("/api/BookChapters/" + id);

                //if (response.IsSuccessStatusCode)
                //{
                //    chapter = await response.Content.ReadAsAsync<BookChapter>();
                //    //json = await response.Content.ReadAsStringAsync();
                //    //Console.WriteLine(json);
                //    //chapter = JsonConvert.DeserializeObject<BookChapter>(json);

                //    Console.WriteLine("The return chapter details: " + chapter);
                //}

                //else Console.WriteLine("Internal Server error");


                //add a new chapter
               // chapter = new BookChapter { Title = "Test chapter2", Number = 54, Pages = 19 };
                //json = JsonConvert.SerializeObject(chapter);
                //content = new StringContent(json, Encoding.UTF8, "application/json");
                //response = await client.PostAsync("/api/BookChapters", content);

                //response = await client.PostAsJsonAsync("/api/BookChapters", chapter);

                //Console.WriteLine($"status from POST {response.StatusCode}");
                //response.EnsureSuccessStatusCode();
                //Console.WriteLine($"added resource at {response.Headers.Location}");
                //json = await response.Content.ReadAsStringAsync();

                //Console.WriteLine("The chapter has been inserted " + json);


                //update the existing
                chapter = new BookChapter
               {
                   Id = new Guid("582db183-f34d-4acb-8767-65ccb09eeb8d"),
                   Title = "updated Test chapter2",
                   Number = 54,
                   Pages = 19
               };
                //json = JsonConvert.SerializeObject(chapter);
                //content = new StringContent(json, Encoding.UTF8, "application/json");
                //response = await client.PutAsync("/api/BookChapters/17ff3f97-9a12-4d0f-b98d-37b14a25d264", content);

                //response =
                //await client.PutAsJsonAsync("/api/BookChapters/582db183-f34d-4acb-8767-65ccb09eeb8d", chapter);
                //Console.WriteLine($"status from PUT {response.StatusCode}");
                //response.EnsureSuccessStatusCode();

                //delete the specified chapter
             
                response = await client.DeleteAsync("/api/BookChapters/582db183-f34d-4acb-8767-65ccb09eeb8d");
                Console.WriteLine($"status from DELETE {response.StatusCode}");
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

    }
}
