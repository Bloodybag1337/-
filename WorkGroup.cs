using System;
namespace Group
{
	public class WorkGroup
	{
        public string WorkName { get; private set; }
        private string WorkLinks;
        private string WorkDeadline;

        public WorkGroup()
		{
		}

        public virtual void Work()
        {
            Console.WriteLine($"Выполняем {WorkName}. Ссылка на доп. материалы: {WorkLinks}. Дедлайн - до {WorkDeadline}");
        }
    }
}

