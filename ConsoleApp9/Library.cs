using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Library
    {
        private Book[] _books=new Book[0];
        public void GetListOfBooks()//Выдать список книг
        {
            foreach (Book book in _books)
            {
                book.GetInformation();
            }
        }
        public void DeleteBook()//Удалить книгу
        {

        }
        public void AddBook(Book book)//Добавить книгу
        {
            book.SetAuthorBook();
            book.SetTitleBook();
            book.SetYearOfRelease();

            if (_books.Length == 0)
            {
                _books = new Book[] {book };
                return;
            }
           
           else if (_books.Length > 0)
            {
                Book[] books2=new Book[_books.Length+1];
                for(int i = 0; i < _books.Length; i++)
                {
                    books2[i] = _books[i];
                }
                books2[books2.Length] = book;
                _books=books2;
                return;
            }
            
           
        }
    }
}
