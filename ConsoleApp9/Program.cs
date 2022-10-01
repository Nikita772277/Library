using ConsoleApp9;

Library library=new Library();
Book book=new Book();
void GetMenu()
{
    Console.WriteLine($"1) Добавить книгу");
    Console.WriteLine($"2) Удалить книгу");
    Console.WriteLine($"3) Посмотреть информацию о книгах в библиотеке");
    Console.WriteLine($"4) Получить информацию");
}
void UseMenu()
{
  string a=Console.ReadLine();
    int AddBook=int.Parse(a);
    if (AddBook == 1)
    {
        library.AddBook();
    }
    else if (AddBook == 2)
    {
        library.DeleteBook();
    }
    else if (AddBook == 3)
    {
       
    }
    else if (AddBook == 4)
    {
        book.GetInformation();
    }
}