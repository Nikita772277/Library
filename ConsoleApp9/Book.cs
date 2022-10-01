using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Book
    {
        private string _authorbook;//Автор книги
        private int _numberofpages;//количество страниц
        private string _title;//название
        private int _yearofrelease;//Год выпуска
        public Book()
        {
            Random ran = new Random();
            _numberofpages = ran.Next(30,3604);
        }
        public void SetTitleBook()//добавить название книги
        {
            Console.WriteLine($"Введите название книги");
            string title= Console.ReadLine();
            _title = title;
        }
        public void SetAuthorBook()//добавить автора
        {
            Console.WriteLine($"Введите автора книги");
            string author = Console.ReadLine();
            _authorbook = author;
        }
        public void SetYearOfRelease()// добавить год выпуска
        {
            Console.WriteLine($"Введите год выпуска книги");
            string title = Console.ReadLine();
            int yearofrelease=int.Parse(title);
            _yearofrelease = yearofrelease;
        }
        public void GetTitleBook()
        {
            Console.WriteLine($"Название книги: {_title}");
        }
        public void GetAuthorBook()
        {
            Console.WriteLine($"Автор книги: {_authorbook}");
        }
        public void GetYearOfRelease()
        {
            Console.WriteLine($"Год выпуска: {_yearofrelease}");
        }
        public void GetInformation()
        {
            Console.WriteLine($"Название книги: {_title}");
            Console.WriteLine($"Автор книги: {_authorbook}");
            Console.WriteLine($"Год выпуска: {_yearofrelease}");
        }
    }
}
