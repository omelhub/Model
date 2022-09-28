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
         students.Add(new Student { Name = name, Speciality = speciality, Group = group });
    }

    /// <summary>
    /// Удалить студента по индексу.
    /// </summary>
    public void DeleteStudent(int index)
    {
        if (students.Count > index)
        {
            students.RemoveAt(index);
        }
    }

    /// <summary>
    /// Вывести весь список студентов в таблицу
    /// </summary>
    public List<string> AllStudents()
    {
        var studentsRepresentations = new List<string>();

        foreach (var student in students)
        {
            studentsRepresentations.Add(student.ToString());
        }

        return studentsRepresentations;
    }
    public Dictionary<string, int> DistributionOfSpecialties()
    {
        var specialtiesDistribution = new Dictionary<string, int>();

        foreach (var student in students)
        {
            if (specialtiesDistribution.ContainsKey(student.Speciality))
                specialtiesDistribution[student.Speciality] += 1;

            else
                specialtiesDistribution[student.Speciality] = 1;
        }

        return specialtiesDistribution;
    }

    //public string[] GetInfo()
    //{
    //    int count = students.Count;

    //    string[] info = new string[3];
    //    if (students.Count != 0)
    //    {
    //        foreach (var isStudent in students)
    //        {
    //            info += studensts.Name;
    //            Console.WriteLine(isStudent.Name + " " + isStudent.Speciality + " " + isStudent.Group);
    //        }
    //    }
    //    else
    //        Console.WriteLine("Список пуст...");
    //    Console.WriteLine();
    //}
}