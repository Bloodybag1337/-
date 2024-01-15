using Group;

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
Console.WriteLine();
Console.WriteLine("Хотите добавить в список ещё одного студента?");
string userInput = Console.ReadLine().ToLower();
if (userInput == "да")
{
    Array.Resize(ref studentGroup, studentGroup.Length + 1);
    Console.WriteLine("\nПоочерёдно укажите его имя и фамилию, номер телефона и электронную почту");
    studentGroup[studentGroup.Length - 1] = new StudentGroup (Console.ReadLine(), Console.ReadLine(), Console.ReadLine());   
}
Console.WriteLine("\nНовый студент добавлен!\n");
for (int i = 0; i < studentGroup.Length; i++)
{
    studentGroup[i].ShowInfo();
}
Console.WriteLine();
Console.ReadKey();


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
Console.WriteLine("\nХотите удалить какое-то занятие из списка?");
string userInputTwo = Console.ReadLine().ToLower();
if (userInputTwo == "да")
{
    Console.WriteLine("Выберите порядковый номер от 1 до 3:");
    int indexToRemove = Convert.ToInt32(Console.ReadLine())-1;
    LearnGroup[] newLearnGroup = new LearnGroup[learnGroup.Length - 1];

    Array.Copy(learnGroup, 0, newLearnGroup, 0, indexToRemove);

    Array.Copy(learnGroup, indexToRemove + 1, newLearnGroup, indexToRemove, learnGroup.Length - indexToRemove - 1);
    learnGroup = newLearnGroup;
}
Console.WriteLine("\nЗанятие удалено!\n");

for (int i = 0; i < learnGroup.Length; i++)
{
    learnGroup[i].Learn();
}
Console.WriteLine();
Console.ReadKey();

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

Console.ReadKey();