using Model;
namespace BusinessLogic;

public class Logic
{
    public List<Student> students { get; set; } = new List<Student>();

    /// <summary>
    /// Добавить нового студента.
    /// </summary>
    public void AddStudent(string name, string speciality, string group)
    {
        bool flag = false;
        foreach (Student student in students)
        {
            if (student.Name == name && student.Speciality == speciality && student.Group == group)
            {
                Console.WriteLine($"{name} {speciality} {group} уже есть!");
                flag = true;
                break;
            }
        }
        if (!flag)
        {
            students.Add(new Student { Name = name, Speciality = speciality, Group = group });
            Console.WriteLine("Студент добавлен.");
        }
    }

    /// <summary>
    /// Удалить студента по данным.
    /// </summary>
    public void DeleteStudent(string name, string speciality, string group)
    {
        if (students.Count == 0)
            Console.WriteLine("Студентов всё равно нет.");
        foreach (Student student in students)
        {
            if (student.Name == name && student.Speciality == speciality && student.Group == group)
            {
                students.Remove(student);
                Console.WriteLine("Студент удален.");
                break;
            }
        }
    }

    /// <summary>
    /// Удалить студента по индексу.
    /// </summary>
    public void DeleteStudent(int index)
    {
        if (students.Count == 0)
            Console.WriteLine("Студентов всё равно нет.");
        if (students.Count > index)
        {
            Console.WriteLine("Студент удален.");
            students.RemoveAt(index);
        }
        else
            Console.WriteLine($"Нет студентов с индексом {index}, введите число от 0 до {students.Count - 1}!");
    }

    /// <summary>
    /// Вывести весь список студентов в таблицу
    /// </summary>
    public void ShowTable()
    {
        Console.WriteLine("\nВывод списка студентов");
        Console.WriteLine("----------------------");
        if (students.Count != 0)
        {
            foreach (var isStudent in students)
            {
                Console.WriteLine(isStudent.Name + " " + isStudent.Speciality + " " + isStudent.Group);
            }
        }
        else
            Console.WriteLine("Список пуст...");
        Console.WriteLine();
    }

    /// <summary>
    /// Вывести гистограмму: распределение студентов по специальностям.
    /// </summary>
    public void ShowBarChart()
    {

    }
}