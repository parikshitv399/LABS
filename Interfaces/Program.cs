using Interfaces;
Console.WriteLine("#### KPMG Global Services ####\nPurchasing software licenses of type IDbms");
List<IDbms> dbmsLicenses = new List<IDbms>();
dbmsLicenses.Add(new SqlServer() { DbInstance = "Express", SqlLanguage = "MS SQL" });
dbmsLicenses.Add(new SqlServer() { DbInstance = "Developer", SqlLanguage = "MS SQL + Reporting" });
dbmsLicenses.Add(new MongoDb() { DbInstance = "Enterprise", SqlLanguage = "JSON" });
dbmsLicenses.Add(new MongoDb() { DbInstance = "Ultimate", SqlLanguage = "JSON + XML" });
foreach (var item in dbmsLicenses)
{
    Console.WriteLine($"License = {item.LicenseKey} | SQL Language : {item.SqlLanguage}");
}
