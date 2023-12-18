//create list Numbers(listNumbers) 

using static System.Runtime.InteropServices.JavaScript.JSType;

List<int> listNumbers = new List<int>();
int Number;
// ask user to introduce the numbers
do
{
    Console.WriteLine("Ingrese un numero");
    string userInput = Console.ReadLine();

    if (int.TryParse(userInput, out int Numbers))
    {
        listNumbers.Add(Numbers);
    }
    else
    {
        Console.WriteLine("Trata de escribir la cifra");
    }
    Console.WriteLine("¿Quieres agregar otro numero? (si/no)");


} while (Console.ReadLine().ToLower() == "si") ;//do while wants to write more numbers.
Console.WriteLine("\t Numbers");
for (int i = 0; i < listNumbers.Count; i++)
{
    Console.WriteLine("\t " + listNumbers[i]);
}

// Create ordered Numbers (orderedProductNames) list
List<string> orderedNumbers = new List<string>();

// show in console the list of written numbers(listNumbers)
//then order the list(listOrderedNumbers)
//show in console the ordered list