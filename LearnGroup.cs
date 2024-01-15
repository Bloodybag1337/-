using System;
namespace Group
{
	public class LearnGroup
	{
        public string Date;
        public string TopicList;
        public string Comment;
		public string LessonType;

        public LearnGroup(string date, string topicList, string comment, string lessonType)
		{
            Date = date;
            TopicList = topicList;
            Comment = comment;
            LessonType = lessonType;
        }

        public void Learn()
        {
            Console.WriteLine($"{Date} будет {LessonType}. {TopicList}, {Comment}");
        }
    }
}

