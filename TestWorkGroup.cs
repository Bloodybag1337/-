using System;
namespace Group
{
	public class TestWorkGroup : WorkGroup
	{
        public string TestWorkName { get; private set; }
        private string TestWorkLinks;
        private string TestWorkDeadline;

        public TestWorkGroup(string testWorkName, string testWorkLinks, string testWorkDeadline)
		{
            TestWorkName = testWorkName;
            TestWorkLinks = testWorkLinks;
            TestWorkDeadline = testWorkDeadline;
        }

        public TestWorkGroup(string testWorkName)
        {
            TestWorkName = testWorkName;
        }

        public override void Work()
        {
            Console.WriteLine($"Выполняем {TestWorkName}. Ссылка на доп. материалы: {TestWorkLinks}. Дедлайн - до {TestWorkDeadline}");
        }
    }
}

