

using DoublyLinkedList.Backend;

var list = new DoublyLinkedList<string>();
var option = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Enter value: ");
            list.Adicionar (Console.ReadLine()!);
            break;
       


        default:
            Console.WriteLine("Invalid option.");
            break;
    }
} while (option != "0");

string Menu()
{
   
    Console.WriteLine("1. Adicionar.");
    Console.WriteLine("0. Exit.");
    Console.Write("Enter your option? ");
    return Console.ReadLine()!;
}