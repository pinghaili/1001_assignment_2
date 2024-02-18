

using System;
using System.Linq;
using Assignment_2;
using Assignment_2_Data_Aggregation;

Console.WriteLine("\n==================== User List =====================\n");

// Task 1 Read CsvData

string csvData = File.ReadAllText(@"../../../users.csv");
Console.Write(csvData);

string[] csvList = csvData.Split('\n');

List<string> headers = new List<string>(csvList[0].Trim().Split(',')); // trim to remove \n
List<string> lastNameList = new List<string>();
List<string> firstNameList = new List<string>();
List<int> studentIdList = new List<int>();

for (int i = 1; i < csvList.Length; i++) {
    string[] student = csvList[i].Trim().Split(',');
    firstNameList.Add(student[0]);
    lastNameList.Add(student[1]);
    studentIdList.Add(int.Parse(student[2]));
}

// Task 2 Aggregate Functions
Console.Write("\n");
Console.WriteLine("\n==================== Aggregate Functions =====================\n");

DataAggregation dataAggregation =  new DataAggregation(lastNameList, studentIdList);

//  Task 3 Add Birth Date and Display Age
Console.Write("\n");
Console.WriteLine("\n==================== Add Birth Date and Display Age =====================\n");

BirthDateAndAge birthDateAndAge = new BirthDateAndAge(lastNameList, studentIdList, firstNameList, headers);

Console.Read();