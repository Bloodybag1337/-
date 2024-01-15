using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using Group;

namespace Group
{
	public class StudentGroup
	{
		public string StudentName;
		public string Telephone;
		public string Email;

		public StudentGroup(string studentName, string telephone, string eMail)
		{
			StudentName = studentName;
            Telephone = telephone;
            Email = eMail;
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"{StudentName}. Телефон: {Telephone}. Электронная почта: {Email}");
        }
    }
}
