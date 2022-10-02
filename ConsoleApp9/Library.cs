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
        public void GetListOfBooks()//Выдать список книг
        {
            foreach (Book book in book)
            {
                Console.WriteLine(book);
            }
        }
        public void DeleteBook()//Удалить книгу
        {

        }
        public void AddBook()//Добавить книгу
        {
         Book boook=new Book();
            boook.SetAuthorBook();
            boook.SetTitleBook();
            boook.SetYearOfRelease();
            for(int i = 0; i < book.Length; i++)
            {
                book[i] = new Book();
            }
        }
    }
}
