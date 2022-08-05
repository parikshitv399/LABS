using System.Collections;
using Encapsulation;
string[] strArr = new string[3];
ArrayList arrList = new ArrayList();
arrList.Add("Meena");
arrList.Add(1000);
arrList.Add(true);
arrList.Remove("Meena");
arrList.Add("Teena");
///foreach (var arrItem in arrList)
///{
///    Console.WriteLine($"{arrItem}");
///}
List<string> strList = new List<string>();
strList.Add("Meena");
strList.AddRange(new List<string> { "Hema", "Rekha", "Jaya", "Sushma" });
///foreach (var item in strList)
///{
///    Console.WriteLine($"Vale of strList is : {item}");
///}
ICollection<Employee> kpmgEmployees = new List<Employee>();
kpmgEmployees.Add(new Employee() { Id = 1, Name = "Shruti"});
kpmgEmployees.Add(new Employee() { Id = 2, Name = "Pritam" });
kpmgEmployees.Add(new Employee() { Id = 3, Name = "Parth" });
kpmgEmployees.Add(new Employee() { Id = 4, Name = "Murali" });
kpmgEmployees.Add(new Employee() { Id = 5, Name = "Parikshit" });
kpmgEmployees.Add(new Employee() { Id = 6, Name = "Janani" });
kpmgEmployees.Add(new Employee() { Id = 7, Name = "Srushty" });

foreach (var emp in kpmgEmployees)
{
    Console.WriteLine($"ID: {emp.Id} | Name: {emp.Name}");
}

