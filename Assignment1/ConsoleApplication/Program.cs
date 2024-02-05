// Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 1 Console-variant
Console.WriteLine("Tovah Parnes, tovah@parnes.com, L0002B, Uppgift 1 Console-variant");

Console.WriteLine("Ange pris:");
int price = int.Parse(Console.ReadLine());

Console.WriteLine("Ange betalt:");
int paid = int.Parse(Console.ReadLine());

int change = paid - price;
Console.WriteLine("Växel tillbaka: " + change + " kr");

int[] values = { 500, 200, 100, 50, 20, 10, 5, 1 };
string[] valueNames = { "500-lappar", "200-lappar", "100-lappar", "50-lappar", "20-lappar", "10-kronor", "5-kronor", "1-kronor" };

for (int i = 0; i < values.Length; i++) {
    change = calculateChange(change, values[i], valueNames[i]);
}

static int calculateChange(int change, int value, string valueName) {
    int valAmmount = (int)Math.Floor((decimal)change / value);
    if (valAmmount > 0) {
        Console.WriteLine(valueName + ": " + valAmmount);
        change = change % value;
    }
    return change;
}
