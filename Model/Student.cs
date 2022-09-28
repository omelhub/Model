namespace Model;

public class Student
{
    public string Name { get; set; } = string.Empty;
    public string Speciality { get; set; } = string.Empty;
    public string Group { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"Имя студента: {Name}, специализация студента: {Speciality}, группа студента {Group}";
    }
}