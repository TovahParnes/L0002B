using System;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 2 Console-variant");

            List<Person> persons = new List<Person>();

            while (true)
            {
                validPnum("0006089460");
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Input person");
                Console.WriteLine("2. Print list");
                Console.WriteLine("3. Add list of people (for easier testing)");
                Console.WriteLine("4. Exit");
                int choice = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (choice == 1)
                {
                    Person person = InputPerson();
                    persons.Add(person);
                }
                else if (choice == 2)
                {
                    persons = bucketSortPeople(persons);
                    printPeople(persons);
                }
                else if (choice == 3)
                {
                    persons.Add(new Person("Kalle Anka", "4503038990", "Piteå", 173));
                    persons.Add(new Person("Snobben", "7805055673", "Luleå", 203));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 202));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 2));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 222));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 302));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 22));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 72));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 82));
                    persons.Add(new Person("Musse Pigg", "3502038964", "Boden", 50));
                }
                else if (choice == 4)
                {
                    Environment.Exit(0);
                } else {
                    Console.WriteLine("Please input a valid number 1-4");
                }
            }

        }
        static Person InputPerson()
        {
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

        static List<Person> bucketSortPeople(List<Person> persons)
        {
            List<Person> level0_49 = new List<Person>();
            List<Person> leve50_99 = new List<Person>();
            List<Person> level100_199 = new List<Person>();
            List<Person> level200 = new List<Person>();

            foreach (Person person in persons)
            {
                int sold = person.Sold;
                if (sold < 50)
                {
                    level0_49.Add(person);
                }
                else if (sold < 100)
                {
                    leve50_99.Add(person);
                }
                else if (sold < 200)
                {
                    level100_199.Add(person);
                }
                else
                {
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

        //Bubblesorts all of the people of a given list, only one bucket is sorted at a time
        static List<Person> bubbleSortPeople(List<Person> persons)
        {
            var n = persons.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (persons[j].Sold > persons[j + 1].Sold)
                    {
                        var tempVar = persons[j];
                        persons[j] = persons[j + 1];
                        persons[j + 1] = tempVar;
                    }
            return persons;
        }

        //Prints all the lines to a file and the console
        static void printPeople(List<Person> persons)
        {
            string fileName = "L0002B_Assignment2_output.txt";
            List<string> toPrint = stringToPrintPeople(persons);
            using (StreamWriter writer = new StreamWriter(fileName))
            foreach (String line in toPrint)
            {
                Console.WriteLine(line);
                writer.WriteLine(line);
            }
        }

        //Creates a list of all lines to be printed
        static List<string> stringToPrintPeople(List<Person> persons)
        {
            int oldSold = 0;
            int count = 0;
            List<string> toPrint = new List<string>();
            toPrint.Add("Namn           Pers.Num        Distrikt    Antal sålda");
            foreach (Person person in persons)
            {
                if (oldSold < 50 && person.Sold >= 50)
                {
                    toPrint.Add(strLevel(count, "0-49"));
                    count = 0;
                }
                else if (oldSold < 100 && person.Sold >= 100)
                {
                    toPrint.Add(strLevel(count, "50-99"));
                    count = 0;
                }
                else if (oldSold < 200 && person.Sold >= 200)
                {
                    toPrint.Add(strLevel(count, "100-199"));
                    count = 0;

                }
                count++;
                toPrint.Add(person.Name + "     " + person.Pnum + "     " + person.District + "     " + person.Sold.ToString());
                oldSold = person.Sold;
            }
            toPrint.Add(strLevel(count, "200+"));
            return toPrint;
        }


        static string strLevel(int count, string lvl)
        {
            if (count != 0)
            {
                return (count + " säljare har nått nivå " + lvl + " artiklar\n");
            }
            return "";
        }

        static bool validPnum(string pNum)
        {
            if (pNum.Length != 10)
            {
                return false;
            }

            bool multiply = true;
            int sum = 0;
            foreach (char i in pNum)
            {
                int num = i - '0';
                if (multiply && num >= 5)
                {
                        sum += num % 10 + 1;
                }
                else
                {
                    sum += num;
                }
                multiply = !multiply;
            }
            Console.WriteLine(sum);

            if (sum == 20)
            {
                return true;
            }
            return false;
        }



    }

    internal class Person
    {
        public string Name;
        public string Pnum;
        public string District;
        public int Sold;

        public Person(string Name, string Pnum, string District, int Sold)
        {
            this.Name = Name;
            this.Pnum = Pnum;
            this.District = District;
            this.Sold = Sold;
        }
    }
}