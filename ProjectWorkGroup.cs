using System;
namespace Group
{
	public class ProjectWorkGroup : WorkGroup
    {
        public string ProjectWorkName { get; private set; }
        private string ProjectWorkShortDescription;
        private string ProjectWorkSubTask;
        private string ProjectWorkLinks;
        private string ProjectWorkDeadline;

        public ProjectWorkGroup(string projectWorkName, string projectWorkShortDescription, string projectWorkSubTask, string projectWorkLinks, string projectWorkDeadline)
		{
            ProjectWorkName = projectWorkName;
            ProjectWorkShortDescription = projectWorkShortDescription;
            ProjectWorkSubTask = projectWorkSubTask;
            ProjectWorkLinks = projectWorkLinks;
            ProjectWorkDeadline = projectWorkDeadline;
        }

        public ProjectWorkGroup(string projectWorkName)
        {
            ProjectWorkName = projectWorkName;
        }

        public override void Work()
        {
            Console.WriteLine($"Выполняем {ProjectWorkName}. Описание работы: {ProjectWorkShortDescription}. Для неё необходимо: {ProjectWorkSubTask}.\nСсылка на доп. материалы: {ProjectWorkLinks}. Дедлайн - до {ProjectWorkDeadline}");
        }
    }
}

