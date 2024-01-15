using System;
namespace Group
{
	public class BasedWorkGroup : WorkGroup
	{
        public string BasedWorkName;
        public string BasedWorkDescription;
        public string BasedWorkLinks;
        public string BasedWorkDeadline;

        public BasedWorkGroup(string basedWorkName, string basedWorkDescription, string basedWorkLinks, string basedWorkDeadline)
		{
            BasedWorkName = basedWorkName;
            BasedWorkDescription = basedWorkDescription;
            BasedWorkLinks = basedWorkLinks;
            BasedWorkDeadline = basedWorkDeadline;
        }

        public override void Work()
        {
            Console.WriteLine($"Выполняем {BasedWorkName}: {BasedWorkDescription}. Ссылка на доп. материалы: {BasedWorkLinks}. Дедлайн - до {BasedWorkDeadline}");
        }
    }
}

