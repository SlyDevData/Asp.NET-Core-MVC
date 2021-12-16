using BookStore.Models;
using BookStore.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;
        public BookController()
        {
            _bookRepository = new BookRepository();
        }
      public ViewResult GetAllBooks()
        {
            var data  = _bookRepository.GetAllbooks();

            return View();
        }

        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookbyId(id);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return  _bookRepository.SearchBook(bookName, authorName);   
        }
    }
}
     