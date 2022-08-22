using EmpContract;

Console.WriteLine("-----Contract Portal-----");
List<IEmpContract> empContracts = new List<IEmpContract>();
empContracts.Add(new SoftwareEngg() { EmpName = "Ramesh", EmpDes = "Quality Assurance Analyst", EmpID = 121984 });
empContracts.Add(new SoftwareEngg() { EmpName = "Suresh", EmpDes = "Tax Tech Analyst", EmpID = 121985 });
empContracts.Add(new Manager() { EmpName = "Suraj", EmpDes = "Quality Assurance Manager", EmpID = 111984 });
empContracts.Add(new Manager() { EmpName = "Vijay", EmpDes = "Tax Tech Manager", EmpID = 111985 });
foreach (var item in empContracts)
{
    item.WorkHours();
    item.NoProjectDisclosure();
    item.WearIDTag();
}