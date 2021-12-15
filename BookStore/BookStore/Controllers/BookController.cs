using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
      public string GetAllBooks()
        {
            return "All Books";
        }

        public string GetBook(int id)
        {
            return $"Book with id = {id}";
        }

        public string SearchBook(string bookName, string authorName)
        {
            return  $"Book with name = {bookName} & Author = {authorName}";
        }
    }
}
    