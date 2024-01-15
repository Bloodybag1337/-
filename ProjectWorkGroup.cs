using System;
namespace Group
{
	public class ProjectWorkGroup : WorkGroup
    {
        public string ProjectWorkName;
        public string ProjectWorkShortDescription;
        public string ProjectWorkSubTask;
        public string ProjectWorkLinks;
        public string ProjectWorkDeadline;

        public ProjectWorkGroup(string projectWorkName, string projectWorkShortDescription, string projectWorkSubTask, string projectWorkLinks, string projectWorkDeadline)
		{
            ProjectWorkName = projectWorkName;
            ProjectWorkShortDescription = projectWorkShortDescription;
            ProjectWorkSubTask = projectWorkSubTask;
            ProjectWorkLinks = projectWorkLinks;
            ProjectWorkDeadline = projectWorkDeadline;
        }

        public override void Work()
        {
            Console.WriteLine($"Выполняем {ProjectWorkName}. Описание работы: {ProjectWorkShortDescription}. Для неё необходимо: {ProjectWorkSubTask}.\nСсылка на доп. материалы: {ProjectWorkLinks}. Дедлайн - до {ProjectWorkDeadline}");
        }
    }
}

