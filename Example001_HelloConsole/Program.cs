//Console.WriteLine(" 2 Hello, World! ");
/*
String path = "C:Users,user,Desktop,C#,Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
*/

void CatalogInfo(string path, string indent ="")
{
DirectoryInfo catalog = new DirectoryInfo(path);

DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
}
string path = @"PS C:\Users\user\Desktop\C#\Example001_HelloConsole>"; 
CatalogInfo(path);
