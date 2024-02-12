// Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 2 Console-variant
using System;
Console.WriteLine("Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 2 Console-variant");

List<Person> persons = new List<Person>();
persons.Add(new Person("Kalle Anka", "4503038990", "Piteå", 173));
persons.Add(new Person("Snobben", "7805055673", "Luleå", 203));
persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 202));

while (true) {
    Console.WriteLine();
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Input person");
    Console.WriteLine("2. Print list");
    Console.WriteLine("3. Exit");
    int choice = int.Parse(Console.ReadLine());
    Console.WriteLine();

    if (choice == 1) {
        Person person = InputPerson();
        persons.Add(person);
    } else if (choice == 2) {
        persons = bucketSortPeople(persons);
        printPeople(persons);
    } else if (choice == 3) {
        Environment.Exit(0);
    }
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

static List<Person> bucketSortPeople(List<Person> persons) {
    List<Person> level0_49 = new List<Person>();
    List<Person> leve50_99 = new List<Person>();
    List<Person> level100_199 = new List<Person>();
    List<Person> level200 = new List<Person>();

    foreach (Person person in persons) {
        int sold = person.Sold;
        if (sold < 50) {
            level0_49.Add(person);
        } else if (sold < 100) {
            leve50_99.Add(person);
        } else if (sold < 200) {
            level100_199.Add(person);
        } else {
            level200.Add(person);
        }
    }

    List<Person> sortedPeople = new List<Person>();
    sortedPeople.AddRange(bubbleSortPeople(level0_49));
    sortedPeople.AddRange(bubbleSortPeople(leve50_99));
    sortedPeople.AddRange(bubbleSortPeople(level100_199));
    sortedPeople.AddRange(bubbleSortPeople(level200));

    return sortedPeople;
}

static List<Person> bubbleSortPeople(List<Person> persons) {

    return persons;
}

static void printPeople(List<Person> persons) {
    Console.WriteLine("{0,15} {1,15} {2,10} {3,10}", "Namn", "Pers.Num", "Distrikt", "Antal sålda");  
    int oldSold = 0;
    int count = 0;
    foreach (Person person in persons) {
        //Console.WriteLine("-------- oldSold: " + oldSold + "currentSold: " + person.Sold);
        if (oldSold < 50 && person.Sold >= 50) {
            printLevel(count, "0-49");
            count = 0;
        } else if (oldSold < 100 && person.Sold >= 100) {
            printLevel(count, "50-99");
            count = 0;
        } else if (oldSold < 200 && person.Sold >= 200) {
            printLevel(count, "100-199");
            count = 0;

        }
        count++;
        Console.WriteLine("{0,15} {1,15} {2,10} {3,10}", person.Name, person.Pnum, person.District, person.Sold);
        oldSold = person.Sold;
    }
    printLevel(count, "200+");
}

static void printLevel(int count, string lvl) {
    if (count != 0) {
        Console.WriteLine(count + " säljare har nått nivå " + lvl + " artiklar\n");
    }
}

public class Person(string name, string pnum, string district, int sold){
    public string Name = name;
    public string Pnum = pnum;
    public string District = district;
    public int Sold = sold;
}

