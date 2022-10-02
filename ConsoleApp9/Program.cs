using ConsoleApp9;

Library library=new Library();
Book book=new Book();
int AddBook;
void GetMenu()
{
    Console.WriteLine($"1) Добавить книгу.");
    Console.WriteLine($"2) Удалить книгу.");
    Console.WriteLine($"3) Посмотреть информацию о книгах в библиотеке.");
    Console.WriteLine($"4) Получить информацию.");
    Console.WriteLine($"5) Завершить работу меню.");
    Console.WriteLine("\t");
}
void UseMenu()
{
  string a=Console.ReadLine();
    Console.WriteLine($"\t");
     AddBook=int.Parse(a);
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
       library.GetListOfBooks();
    }
    else if (AddBook == 4)
    {
        book.GetInformation();
    }
    else if (AddBook == 5)
    {

    }
    else
    {
        Console.WriteLine($"Ошибка выбурети пункт из меню.");
    }
}
void Menu()
{
    for (int i = 0; ;)
    {
        GetMenu();
        UseMenu();
        Console.WriteLine("\t");
        if (AddBook == 5)
        {
            Console.WriteLine($"До новых встреч.");
            break;
        }
    }
}
Menu();