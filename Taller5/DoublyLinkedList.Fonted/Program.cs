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
            string? input = Console.ReadLine();

            if (input != null)
            {
                list.AddUpward(input, StringComparer.OrdinalIgnoreCase);
            }

            break;

        case "2":

            Console.WriteLine("List from head to tail:");
            Console.WriteLine(list);

            break;

        case "3":

            Console.WriteLine("List from tail to head:");
            Console.WriteLine(list.ToStringReverse());

            break;

        case "4":

            list.SortDescending();

            Console.WriteLine("List sorted descending.");
            Console.WriteLine(list);

            break;

        case "5":

            var modes = list.Mode();

            Console.WriteLine($"Modes of the list: {modes}");

            break;

        case "6":

            Console.WriteLine(list.ShowGraph());

            break;

        case "7":

            Console.Write("Enter value to search: ");
            var search = Console.ReadLine();

            if (search != null)
            {
                if (list.Exist(search))
                {
                    Console.WriteLine($"{search} exists in the list.");
                }
                else
                {
                    Console.WriteLine($"{search} does not exist in the list.");
                }
            }

            break;

        case "8":

            Console.Write("Enter value to remove: ");
            var remove = Console.ReadLine();

            if (remove != null)
            {
                list.Remove(remove);
            }

            break;

        case "9":

            Console.Write("Enter value to remove: ");
            var removeAll = Console.ReadLine();

            if (removeAll != null)
            {
                list.RemoveAll(removeAll);
            }

            break;
        case "10":

            list.Clear();

            Console.WriteLine("List cleared successfully.");

            break;

        case "0":

            Console.WriteLine("Goodbye.");

            break;

        default:

            Console.WriteLine("Invalid option.");

            break;

    }

} while (option != "0");


string Menu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add element");
    Console.WriteLine("2. List from head to tail");
    Console.WriteLine("3. List from tail to head");
    Console.WriteLine("4. Sort descending");
    Console.WriteLine("5. Show mode");
    Console.WriteLine("6. Show graph");
    Console.WriteLine("7. Exists");
    Console.WriteLine("8. Remove an occurrence");
    Console.WriteLine("9. Remove all occurrences");
    Console.WriteLine("10. Clear list");
    Console.WriteLine("0. Exit");

    Console.Write("Enter your option? ");

    return Console.ReadLine()!;
}