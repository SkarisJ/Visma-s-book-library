using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Book_library.Services
{
    public class BookLibrary
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public DateTime PublicationDate { get; set; }
        public string ISBN { get; set; }

        public void addBook(string name, string author, string category, string language, DateTime publicationDate, string isbn)
        {
            var data = new List<BookLibrary>
            {
                new BookLibrary()
                {
                    Name = name,
                    Author = author,
                    Category = category,
                    Language = language,
                    PublicationDate = publicationDate,
                    ISBN = isbn
                }
            };

            string jsonWrite = System.Text.Json.JsonSerializer.Serialize(data);
            if (!File.Exists("./library.json"))
            {
                File.WriteAllText(@"./library.json", jsonWrite);
            }
            else
            {
                File.AppendAllText(@"./library.json", jsonWrite);
            }
        }
        public List<BookLibrary> LoadJson()
        {
            using (StreamReader r = new StreamReader("./library.json"))
            {
                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<BookLibrary>>(json);

                return items;
            }

        }
    }
}
