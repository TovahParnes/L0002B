// Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 2 Console-variant
Console.WriteLine("Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 2 Console-variant");

public class Person(string name, string pnum, string district, int sold){
    public string Name = name;
    public string Pnum = pnum;
    public string District = district;
    public int Sold = sold;
}

List<Person> persons = new List<Person>();

Console.WriteLine("Menu:");
Console.WriteLine("1. Input person");
Console.WriteLine("2. Print list");
Console.WriteLine("3. Exit");
int choice = int.Parse(Console.ReadLine());

if (choice == 1) {
    Person person = InputPerson();
    persons.Add(person);
} else if (choice == 2) {
    foreach (Person person in persons) {
        Console.WriteLine(person.Name + " " + person.Pnum + " " + person.District + " " + person.Sold);
    }
} else if (choice == 3) {
    break;
}

static Person InputPerson() {
    Console.WriteLine("Namn:");
    string name = Console.ReadLine();

    Console.WriteLine("Personnummer:");
    string pnum = Console.ReadLine();

    Console.WriteLine("Distrikt:");
    string district = Console.ReadLine();

    Console.WriteLine("Antal sålda artiklar:");
    int sold = int.Parse(Console.ReadLine());

    return new Person(name, pnum, district, sold);
}

