using System;

// создаем структуру "Студент"
struct Student
{
    public string name; // фамилия и инициалы
    public int group; // номер группы
    public int[] grades; // успеваемость
    public double avg; // средний балл

    public double GetAverageGrade()
    {
        double sum = 0;
        for (int i = 0; i < grades.Length; i++)
        {
            sum += grades[i];
        }
        return sum / grades.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // создаем массив из семи объектов типа "Студент"
        Student[] students = new Student[7];

        // заполняем массив объектами "Студент"
        students[0] = new Student { name = "Иванов И.И.", group = 1, grades = new int[] { 5, 5, 5, 5, 5 }, };
        students[1] = new Student { name = "Петров П.П.", group = 2, grades = new int[] { 3, 3, 4, 5, 4 }, };
        students[2] = new Student { name = "Сидоров С.С.", group = 1, grades = new int[] { 5, 5, 5, 5, 5 }, };
        students[3] = new Student { name = "Кузнецов К.К.", group = 3, grades = new int[] { 4, 4, 3, 4, 5 }};
        students[4] = new Student { name = "Новиков Н.Н.", group = 2, grades = new int[] { 4, 4, 4, 4, 4 }, };
        students[5] = new Student { name = "Морозов М.М.", group = 3, grades = new int[] { 5, 4, 5, 4, 5 }, };
        students[6] = new Student { name = "Волков В.В.", group = 1, grades = new int[] { 3, 3, 3, 3, 3 }, };

        // сортируем массив по возрастанию среднего балла
        Array.Sort(students, (a, b) => a.GetAverageGrade().CompareTo(b.GetAverageGrade()));

        // выводим отсортированный массив на экран
        foreach (Student student in students)
        {
            Console.WriteLine($"{student.name}, Group: {student.group}, Average grade: {student.GetAverageGrade()}");
        }
    }
}