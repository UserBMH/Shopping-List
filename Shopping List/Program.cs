using System.Collections;

//Display 8 item names and prices

List<string> custOrder = new List<string>();
string itemChoice = "";




Dictionary<string, decimal> items = new Dictionary<string, decimal>();
items.Add("Allen Wrench", 4.50m);
items.Add("Gerbil Feeder", 9.99m);
items.Add("Toilet Seat", 23.25m);
items.Add("Electric Heater", 66.98m);
items.Add("Trash Compactor", 222.22m);
items.Add("Juice Extractor", 34.21m);
items.Add("Shower Rod", 7.00m);
items.Add("Water Meter", 29.59m);


Console.WriteLine("Welcome to the HARDWARE STORE");
Console.WriteLine();
Console.WriteLine("Heres what we got...");
Console.WriteLine();

bool runExercise = true;
while (runExercise = true)

{
        foreach (KeyValuePair<string, decimal> kvp in items)
    {
        Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
        Console.WriteLine();
    }



    //ask user to enter an item

    Console.WriteLine("What can I get for you?");
    itemChoice = Console.ReadLine();
    

    

    if (items.ContainsKey(itemChoice))
    {
        
            Console.WriteLine("We have that...");
        custOrder.Add(itemChoice + "          ");
        
    }
    else
    {
        Console.WriteLine("I'd have to check the back...");
        Console.WriteLine("Here what I know we have for sure.");
        Console.WriteLine();
        foreach (KeyValuePair<string, decimal> kvp in items)
        {
            Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
            Console.WriteLine();
        }
    }



    Console.WriteLine("Add another item? 'Y' or 'N'?");
    Console.WriteLine();
    string loopChoice = Console.ReadLine();
    if (loopChoice.ToLower() == "n")
    {
        runExercise = false;
        break;
    }
    else
    {
    
    }

}


    Console.WriteLine("Heres your order!");

foreach (string o in custOrder)
{
    Console.WriteLine();
    Console.WriteLine(o + items[itemChoice]);
}



Console.WriteLine("Total Price is... ");
Console.WriteLine("i dont know the cash register is broken. just give me like 5 dollars");

//when done adding items display list ordered with prices in columns




//display sum price of items ordered



/*foreach (KeyValuePair<string, decimal> kvp in items)
{
    Console.WriteLine($"{kvp.Key}: ${kvp.Value}");
    Console.WriteLine();
}
*/
//Console.WriteLine($"{custOrder} + {items<string, decimal>()}");