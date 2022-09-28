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
    /// Вывести весь список студентов.
    /// </summary>
    public List<Student> GetAll()
    {
        List<Student> allstudents = new();

        foreach (Student student in students)
        {
            allstudents.Add(student);
        }
        return allstudents;
    }

    public Dictionary<string, int> DistributionOfSpecialties()
    {
        Dictionary<string, int> specialtiesDistribution = new();

        foreach (Student student in students)
        {
            if (specialtiesDistribution.ContainsKey(student.Speciality))
                specialtiesDistribution[student.Speciality] += 1;

            else
                specialtiesDistribution[student.Speciality] = 1;
        }
        return specialtiesDistribution;
    }
}