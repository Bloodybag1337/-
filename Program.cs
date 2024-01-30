using Group;
using System.Linq;

StudentGroup[] studentGroup = new StudentGroup[]
{
    new StudentGroup("Олег Кузнецов","+79118763425","kuznetsov_oleg@mail.ru"),
    new StudentGroup("Михаил Семёнов","+79815543287","miha08042002@yandex.ru"),
    new StudentGroup("Николай Никитин","+79210053428","nn_rus@gmail.com")
};

Console.WriteLine("Список студентов:");
for (int i = 0; i < studentGroup.Length; i++)
{
    studentGroup[i].ShowInfo();
}

void AddStudent()
{
    Array.Resize(ref studentGroup, studentGroup.Length + 1);
    Console.WriteLine("\nПоочерёдно укажите его имя и фамилию, номер телефона и электронную почту");
    studentGroup[studentGroup.Length - 1] = new StudentGroup(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
    Console.WriteLine("\nНовый студент добавлен!\n");
    for (int i = 0; i < studentGroup.Length; i++)
    {
        studentGroup[i].ShowInfo();
    }
}
Console.WriteLine("\nХотите добавить в список ещё одного студента?");
string userInput = Console.ReadLine().ToLower();
if (userInput == "да")
{
    AddStudent();
}
Console.WriteLine();

LearnGroup[] learnGroup = new LearnGroup[]
{
    new LearnGroup ("16.01.2024","Тема №1","комментарий №1","лекция"),
    new LearnGroup ("20.01.2024","Тема №2","комментарий №2","консультация"),
    new LearnGroup ("24.01.2024","Тема №3","комментарий №3","другое")
};

for (int i = 0; i < learnGroup.Length; i++)
{
    learnGroup[i].Learn();
}

void DeleteLessonFromList()
{
    Console.WriteLine("Выберите порядковый номер от 1 до 3:");
    int indexToRemove = Convert.ToInt32(Console.ReadLine()) - 1;
    LearnGroup[] newLearnGroup = new LearnGroup[learnGroup.Length - 1];

    Array.Copy(learnGroup, 0, newLearnGroup, 0, indexToRemove);

    Array.Copy(learnGroup, indexToRemove + 1, newLearnGroup, indexToRemove, learnGroup.Length - indexToRemove - 1);
    learnGroup = newLearnGroup;
    Console.WriteLine("\nЗанятие удалено!\n");

    for (int i = 0; i < learnGroup.Length; i++)
    {
        learnGroup[i].Learn();
    }
}
Console.WriteLine("\nХотите удалить какое-то занятие из списка?");
string userInputTwo = Console.ReadLine().ToLower();
if (userInputTwo == "да")
{
    DeleteLessonFromList();
}
Console.WriteLine();

WorkGroup[] workGroup = new WorkGroup[3]
{
    new BasedWorkGroup("обычное задание","*формулировка*","https://drive.google.com/basedwork","23.02.2024"),
    new TestWorkGroup("тестовое задание","https://drive.google.com/testwork","08.03.2024"),
    new ProjectWorkGroup("проектное задание","*типа описание работы*","*набор подзадач*","https://drive.google.com/projectwork","09.05.2024")
};

for (int i = 0; i < workGroup.Length; i++)
{
    workGroup[i].Work();
}
Console.WriteLine();

void NoteStudentsAssignment()
{
    StudentGroup[] students = new StudentGroup[]
        {
        new ("Олег Кузнецов"),
        new ("Михаил Семёнов"),
        new ("Николай Никитин")
        };

    WorkGroup[] works = new WorkGroup[3];
    works[0] = new BasedWorkGroup("обычное задание");
    works[1] = new TestWorkGroup("тестовое задание");
    works[2] = new ProjectWorkGroup("проектное задание");

    Dictionary<string, List<int>> studentTasks = new Dictionary<string, List<int>>();

    foreach (var student in students)
    {
        Console.WriteLine($"Поставьте '+', если {student.StudentName} выполнил задание:");
        List<int> tasks = new List<int>();

        for (int i = 0; i < works.Length; i++)
        {
            if (works[i] is BasedWorkGroup)
            {
                BasedWorkGroup basedWorkGroup = (BasedWorkGroup)works[i];
                Console.Write($"{basedWorkGroup.BasedWorkName}: ");
            }

            if (works[i] is TestWorkGroup)
            {
                TestWorkGroup testWorkGroup = (TestWorkGroup)works[i];
                Console.Write($"{testWorkGroup.TestWorkName}: ");
            }

            if (works[i] is ProjectWorkGroup)
            {
                ProjectWorkGroup projectWorkGroup = (ProjectWorkGroup)works[i];
                Console.Write($"{projectWorkGroup.ProjectWorkName}: ");
            }

            string input = Console.ReadLine();
            string isTaskCompleted = "+";
            if (input == isTaskCompleted)
                tasks.Add(i + 1);
        }

        studentTasks.Add(student.StudentName, tasks);
        Console.WriteLine();
    }
    Console.WriteLine("\nСписок заданий, выполненных каждым студентом: ");
    foreach (var entry in studentTasks)
    {
        string student = entry.Key;
        List<int> tasks = entry.Value;

        Console.Write($"{student}: ");
        if (tasks.Count > 0)
            Console.WriteLine(string.Join(", ", tasks));
        else
            Console.WriteLine("Нет выполненных заданий");
    }

    Console.WriteLine("\nСписок студентов, выполнивших конкретное задание: ");
    for (int i = 0; i < works.Length; i++)
    {
        if (works[i] is BasedWorkGroup)
        {
            BasedWorkGroup basedWorkGroup = (BasedWorkGroup)works[i];
            Console.Write($"{basedWorkGroup.BasedWorkName}: ");
        }

        if (works[i] is TestWorkGroup)
        {
            TestWorkGroup testWorkGroup = (TestWorkGroup)works[i];
            Console.Write($"{testWorkGroup.TestWorkName}: ");
        }

        if (works[i] is ProjectWorkGroup)
        {
            ProjectWorkGroup projectWorkGroup = (ProjectWorkGroup)works[i];
            Console.Write($"{projectWorkGroup.ProjectWorkName}: ");
        }
        List<string> studentsWithTask = new List<string>();

        foreach (var entry in studentTasks)
        {
            string student = entry.Key;
            List<int> tasks = entry.Value;

            if (tasks.Contains(i + 1))
                studentsWithTask.Add(student);
        }

        if (studentsWithTask.Count > 0)
            Console.WriteLine(string.Join(", ", studentsWithTask));
        else
            Console.WriteLine("Ни один студент не выполнил это задание");
    }
}
NoteStudentsAssignment();
Console.ReadKey();