using System;
namespace Group
{
	public class WorkGroup
	{
        public string WorkName;
        public string WorkLinks;
        public string WorkDeadline;

        public WorkGroup()
		{
		}

        public virtual void Work()
        {
            Console.WriteLine($"Выполняем {WorkName}. Ссылка на доп. материалы: {WorkLinks}. Дедлайн - до {WorkDeadline}");
        }
    }
}

