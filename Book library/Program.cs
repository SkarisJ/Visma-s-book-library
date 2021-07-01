using Book_library.Services;
using System;

namespace Book_library
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookLibrary = new BookLibrary();

            bookLibrary.addBook("Jis", "Justas", "Science", "Lithuanian", DateTime.Now, "1254636");
        }
    }
}
