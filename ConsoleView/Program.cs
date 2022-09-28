using BusinessLogic;
using Model;
using System.Collections.Generic;

Logic logic = new();

//тестовый список студентов
logic.students.Add(new Student() { Name = "Иванов", Speciality = "Информатика", Group = "КИ21-21Б" });
logic.students.Add(new Student() { Name = "Петров", Speciality = "Информатика", Group = "КИ21-21Б" });
logic.students.Add(new Student() { Name = "Сидоров", Speciality = "Информатика", Group = "КИ21-21Б" });
logic.students.Add(new Student() { Name = "Лагойда", Speciality = "Информатика", Group = "КИ21-21Б" });
logic.students.Add(new Student() { Name = "Машкова", Speciality = "Биология", Group = "КИ21-01А" });
logic.students.Add(new Student() { Name = "Викторова", Speciality = "Биология", Group = "КИ21-02А" });

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
    Console.WriteLine($"\n\n{"Имя", -30} {"| Специальность", -30} {"| Группа", -20}");
    Console.WriteLine(new string('-', 80));
    List<Student> allStudents = logic.GetAll();
    foreach (Student student in allStudents)
    {
        Console.WriteLine($"{student.Name, -30} {student.Speciality, -30} {student.Group, -20}");
    }
}