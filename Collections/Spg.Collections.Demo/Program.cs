using Spg.Collections.Demo;

//Person p3 = new Person(3, "Vorname 03", "Nachname 03");

List<Person> persons = new()
{
    new Person(1, "Vorname 01", "Nachname 01"),
    new Person(2, "Vorname 02", "Nachname 02"),
    new Person(3, "Vorname 03", "Nachname 03"),
    new Person(4, "Vorname 04", "Nachname 04"),
    new Person(5, "Vorname 05", "Nachname 05"),
};

persons.Add(new Person(6, "Vorname 06", "Nachname 06"));

persons.Remove(new Person(5, "Vorname 05", "Nachname 05"));





// Ausgabe
foreach (Person item in persons)
{
    Console.WriteLine(item.ToString());
}