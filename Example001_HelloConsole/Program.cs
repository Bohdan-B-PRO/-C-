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
/*

void CatalogInfo(string path, string indent ="")
{
DirectoryInfo catalog = new DirectoryInfo(path);

DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }
    FileInfo[] files = catalog.GetFiles(); 
    
        for (int i = 0; i < files.Length; i++)
        {
            Console.WriteLine($"{indent}{catalogs[i].Name}");
        }
    
}
string path = @"PS C:\Users\user\Desktop\C#\Example001_HelloConsole>"; 
CatalogInfo(path);
*/
/*
void Towers(string with ="1", string on = "3", string some = "2", int count = 5 )
{
    if (count > 1) Towers(with, some, on, count -1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}


Towers();
*/
/*
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                  0   1    2     3    4    5    6    7    8    9    10    11
void InOrderTraversal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int  right = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        Console.WriteLine(tree[pos]);
        if(right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();
*/


decimal fRec = 0;
decimal fIte = 0;

decimal FiconacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FiconacciRecursion(n - 1) + FiconacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++; 
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for(int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}

//# 1 2 3 4 5 6
//V 1 1 2 3 5 8

Console.ReadLine();
DateTime dt = DateTime.Now;
for(int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} FIte = {fIte.ToString("### ### ###")}, -15");
    fIte = 0;
}
System.Console.WriteLine(+(DateTime.Now - dt).TotalMilliseconds);


Console.WriteLine();
Console.ReadLine();
dt = DateTime.Now;
for(int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} FRec = {fRec.ToString("### ### ###")}, -15");
    fRec = 0;
}
System.Console.WriteLine(+(DateTime.Now - dt).TotalMilliseconds);

Console.ReadLine();



