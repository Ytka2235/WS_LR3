internal class Program
{
    private static void Main(string[] args)
    {
        Student[] student = new Student[7];
        student[0] = new Student("Данила", "Н.Н.", "22ИТ35", new int[] { 1, 2, 3, 4, 5 });
        student[1] = new Student("Кирил", "Е.Р.", "22ИТ35", new int[] { 3, 4, 5, 2, 4 });
        student[2] = new Student("Игорь", "Н.Н.", "22ИТ35", new int[] { 2, 2, 2, 5, 5 });
        student[3] = new Student("Денис", "Т.Н.", "22ИТ35", new int[] { 3, 4, 5, 4, 2 });
        student[4] = new Student("Дмитрий", "В.К", "22ИТ35", new int[] { 4, 3, 3, 4, 3 });
        student[5] = new Student("Генадий", "Н.П", "22ИТ35", new int[] { 3, 4, 5, 4, 4 });
        student[6] = new Student("Владимир", "П.В.", "22ИТ35", new int[] { 3, 2, 3, 1, 1 });

        foreach(Student st in student) Console.WriteLine(st.Grade());
        student = ViborSort(student);
        foreach (Student st in student) Console.WriteLine(st.Grade());
    }
    static Student[] ViborSort(Student[] mas)
    {

        for (int i = 0; i < mas.Length - 1; i++)
        {
            //поиск минимального числа
            int min = i;
            for (int j = i + 1; j < mas.Length; j++)
            {
                if (mas[j].Grade() < mas[min].Grade())
                {
                    min = j;
                }
            }
            //обмен элементов
            Student temp = mas[min];
            mas[min] = mas[i];
            mas[i] = temp;
        }
        return mas;
    }
}
struct Student
{
    public string Name;
    public string IN;
    public string Group;
    public int[] Evaluations;
    public Student(string name, string In, string group, int[] evaluations)
    {
        Name = name;
        IN = In;
        Group = group;
        Evaluations = evaluations;
    }
    public double Grade()
    {
        double res = 0;
        foreach (int eval in Evaluations) { res += eval; }
        res = res / (double)Evaluations.Length;
        return res;
    }
}

