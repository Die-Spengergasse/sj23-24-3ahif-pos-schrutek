// See https://aka.ms/new-console-template for more information


using ConsoleApp_Start;

Console.WriteLine("Hello, World!");
Console.WriteLine("Hallo, Welt!");

Student student = new Student(new DateTime(2000, 9, 22), "Max Muster");
Console.WriteLine(student);

Person person = new Person() 
{ 
    EMail = "asddasd@asdads.at", 
    Age = 12, 
    Id = 1, 
    MyProperty1 = 4711 
};
person.Age = 10;
person.EMail = "asdadsds@asdasd.at";
//person.MyProperty1 = 4712;
//person.MyProperty = 123;

Student? student2 = null; // new Student(DateTime.Now, "Anna Theke");

int? i = null;

static int DoSomething(int? a, int? b, int? c)
{
    return a ?? b ?? c ?? 4711;
}

string myString = default!;


int length = myString?.Length ?? 0;

Console.WriteLine($"Länge: {length}");

string firstName = "Anna";
string lastName = "Theke";

string fullname = $"{firstName} {lastName}";

string s = @$"ydfs {firstName} dfdsfdfdf asdadasd- / \ <> $
asdasdas
asda
sd
adsasd
";

