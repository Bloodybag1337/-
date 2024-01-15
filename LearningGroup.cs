using System;
namespace Group
{
	public class LearningGroup
	{
		public string Date;
		public string TopicList;
		public string Comment;
		public string LessonType;

		public LearningGroup(string date, string topicList, string comment, string lessonType)
		{
			Date = date;
			TopicList = topicList;
			Comment = comment;
			LessonType = lessonType;
		}

		LearningGroup[] learningGroup = new LearningGroup[]
		{

		};


    }
}

