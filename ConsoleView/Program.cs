using BusinessLogic;
using System.Collections.Generic;

Logic logic = new();

static void Commands()
{
    Console.WriteLine("Список команд:");
    Console.WriteLine(" 1  - добавить студента,");
    Console.WriteLine(" 2  - удалить студента по индексу,");
    Console.WriteLine(" 3  - вывести список студентов,");
    Console.WriteLine("Esc - выйти.");
}

bool x = true;
while (x)
{
    Commands();
    ConsoleKeyInfo key = Console.ReadKey();

    switch (key.Key)
    {
        case ConsoleKey.D1:
            AddStudentCommand();
            break;
        case ConsoleKey.D2:
            DeleteStudentCommand();
            break;
        case ConsoleKey.D3:
            ShowStudentsCommand();
            break;
        case ConsoleKey.Escape:
            x = false;
            break;
    }
    Console.WriteLine();
}

void AddStudentCommand()
{
    Console.WriteLine("\nВведите Имя Специальность Группу студента через пробел:");
    string[] NewStudent = Console.ReadLine().Split();
    logic.AddStudent(NewStudent[0], NewStudent[1], NewStudent[2]);
}

void DeleteStudentCommand()
{
    Console.WriteLine("\nВведите индекс студента:");
    if (Int32.TryParse(Console.ReadLine(), out int result))
        logic.DeleteStudent(result);
    else
        Console.WriteLine("Индекс введен неправильно.");
}

void ShowStudentsCommand()
{
    List<string> list = logic.AllStudents();
    foreach (string s in list)
    {
        Console.WriteLine(s);
    }
}