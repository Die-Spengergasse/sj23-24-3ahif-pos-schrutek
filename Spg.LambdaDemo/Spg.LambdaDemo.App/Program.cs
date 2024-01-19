using Spg.LambdaDemo.App.Model;

StudentList students = new()
{
    new Student(){ Id = 1, FirstName = "Anna", LastName = "Theke" },
    new Student(){ Id = 2, FirstName = "Max", LastName = "Reinsch" },
    new Student(){ Id = 3, FirstName = "Axel", LastName = "Schweiß" },
    new Student(){ Id = 4, FirstName = "Rainer", LastName = "Zufall" },
    new Student(){ Id = 5, FirstName = "Ben", LastName = "Dover" },
    new Student(){ Id = 6, FirstName = "Phil", LastName = "Harmonica" },
};

//IEnumerable<Student> result = students.Where(s => s.FirstName.Contains("x"));

IEnumerable<Student> result = students.Filter(s => s.FirstName.ToLower().Contains("x"));

foreach (Student student in result)
{
    Console.WriteLine($"{student.Id} - {student.FirstName} {student.LastName}");
}

bool FirstNameContainsPart(Student s)
{
    return s.FirstName.ToLower().Contains("x");
}

bool LastNameContainsPart(Student s)
{
    return s.FirstName.ToLower().Contains("z");
}
bool IdGTE3(Student s)
{
    return s.Id >= 3 && s.LastName.ToLower().Contains("z");
}

bool IdLTE4(Student s)
{
    return s.Id <= 4;
}
