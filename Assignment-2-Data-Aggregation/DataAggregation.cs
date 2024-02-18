using System;
namespace Assignment_2
{
	public class DataAggregation
	{
		public DataAggregation(List<string> lastNameList, List<int> studentIdList)
		{

            Console.WriteLine($"Count of students: {lastNameList.Count}");
            Console.WriteLine($"Min of students Id: {studentIdList.Min()}");
            Console.WriteLine($"Max of students Id: {studentIdList.Max()}");
            Console.WriteLine($"Average of students Id: {studentIdList.Average()}");

            var pList = lastNameList.Where(lastName => lastName.StartsWith('P'));
            Console.WriteLine($"Students' lastName starts with P: {string.Join(',', pList)}");

            var oList = lastNameList.Where(lastName => lastName.Contains('o') || lastName.Contains('O'));
            Console.WriteLine($"Students' lastName contains O: {string.Join(',', oList)}");


        }
    }
}

