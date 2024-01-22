using System;
namespace Group
{
	public class BasedWorkGroup : WorkGroup
	{
        public string BasedWorkName { get; private set; }
        private string BasedWorkDescription;
        private string BasedWorkLinks;
        private string BasedWorkDeadline;

        public BasedWorkGroup(string basedWorkName, string basedWorkDescription, string basedWorkLinks, string basedWorkDeadline)
		{
            BasedWorkName = basedWorkName;
            BasedWorkDescription = basedWorkDescription;
            BasedWorkLinks = basedWorkLinks;
            BasedWorkDeadline = basedWorkDeadline;
        }

        public BasedWorkGroup(string basedWorkName)
        {
            BasedWorkName = basedWorkName;
        }

        public override void Work()
        {
            Console.WriteLine($"Выполняем {BasedWorkName}: {BasedWorkDescription}. Ссылка на доп. материалы: {BasedWorkLinks}. Дедлайн - до {BasedWorkDeadline}");
        }
    }
}

