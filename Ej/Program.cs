//create list Numbers(listNumbers) 

using static System.Runtime.InteropServices.JavaScript.JSType;

List<int> listNumbers = new List<int>();
int Number;
// ask user to introduce the numbers
do
{
    Console.WriteLine("Ingrese un numero");
    Number = int.Parse(Console.ReadLine());
    Console.WriteLine("¿Quieres agregar otro numero? (si/no)");

} while (Console.ReadLine().ToLower() == "si") ;//do while wants to write more numbers.

// show in console the list of written numbers(listNumbers)
//then order the list(listOrderedNumbers)
//show in console the ordered list