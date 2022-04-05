using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace ConsumeAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            //send http request to fetch the value

           // CreateRequest().Wait();
            UpdateRequest().Wait();
        }

        private static async Task CreateRequest()
        {
            
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44315/api/Book/Create");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                // HTTP POST
                var datatobeSent = new Catalogue()
                {
                    Book_ID = 10,
                    Book_Name = "New Book Name",
                    Book_Author = "New Book Author",
                    Book_Registration = DateTime.Now,
                    Book_Category = "New Category",
                    Book_Description = "New Book Description"
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("Create", datatobeSent);

                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    Uri url = response.Headers.Location;
                }
            }

        }

        private static async Task UpdateRequest()
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44315/api/Book/Update");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                // HTTP POST
                var datatobeSent = new Catalogue()
                {
                    Book_ID = 10,
                    Book_Name = "Updated Name",
                    Book_Author = "UpdatedAuthor",
                    Book_Registration = DateTime.Now,
                    Book_Category = "Updated Category",
                    Book_Description = "Updated Book Description"
                };

                HttpResponseMessage response = await client.PutAsJsonAsync("Update", datatobeSent);

                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.
                    Uri url = response.Headers.Location;
                }
            }

        }
    }
}
