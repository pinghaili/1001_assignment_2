using System;
namespace Assignment_2_Data_Aggregation
{
	public class BirthDateAndAge
	{
		public BirthDateAndAge(List<string> lastNameList, List<int> studentIdList, List<string> firstNameList, List<string> headers)
		{

            DateTime startDate = new DateTime(1990, 1, 1);
            DateTime endDate = new DateTime(2000, 12, 31);

            int range = (endDate - startDate).Days;

            Random rand = new Random();
            List<DateTime> birthDateList = new List<DateTime>();

            for (int i = 0; i < firstNameList.Count; i++)
            {
                birthDateList.Add((startDate.AddDays(rand.Next(range))));
            }

            headers.Add("Birth Date");
            headers.Add("Age");

            Console.WriteLine($"{headers[0],-15}, {headers[1],-22}, {headers[2],12}, {headers[3],15}, {headers[4]}");

            for (int i = 0; i < firstNameList.Count; i++)
            {
                DateTime today = DateTime.Today;
                int age = today.Year - birthDateList[i].Year;

                Console.WriteLine($"{firstNameList[i],-15}, {lastNameList[i],-22}, {studentIdList[i],12}, {birthDateList[i].ToShortDateString(),15}, {age}");
            }

        }
    }
}

