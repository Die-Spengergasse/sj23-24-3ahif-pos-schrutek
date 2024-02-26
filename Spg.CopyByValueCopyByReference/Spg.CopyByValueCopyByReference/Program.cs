using Spg.CopyByValueCopyByReference;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int i = 3;
Person person = new Person() { Name = "ALT", Age = 12 };
ChangePerson(person, i);

void ChangePerson(Person p, int i)
{
    Console.WriteLine($"{i} | {p.Name} {p.Age}");
    person.Name = "NEU";
    person.Age = 17;
    i = 8;
}

Console.WriteLine($"{i} | {person.Name} {person.Age}");

GCHandle handle1 = GCHandle.Alloc(person.Name, GCHandleType.Pinned);
GCHandle handle2 = GCHandle.Alloc(person, GCHandleType.Pinned);

string someObject = "Somestring";
GCHandle handle = GCHandle.Alloc(someObject, GCHandleType.Pinned);
Console.WriteLine($"Address: 0x{handle.AddrOfPinnedObject():X}");
handle.Free();