using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Library
    {
        private Book[] book = new Book[7];
        public void GetListOfBooks()
        {

        }
        public void DeleteBook()
        {

        }
        public void AddBook()
        {
         Book book=new Book();
            book.SetAuthorBook();
            book.SetTitleBook();
            book.SetYearOfRelease();
        }
    }
}
