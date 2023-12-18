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
// show in console the list of written numbers(listNumbers)
for (int i = 0; i < listNumbers.Count; i++)
{
    Console.WriteLine("\t " + listNumbers[i]);
}

//then create and order the list(listOrderedNumbers)
List<int> listOrderedNumbers = new List<int>();
listNumbers.Sort();
//show in console the ordered list

Console.WriteLine("Lista ordenada:");
    foreach (int Numbers in listNumbers)
    {
        Console.WriteLine(Numbers);
    }