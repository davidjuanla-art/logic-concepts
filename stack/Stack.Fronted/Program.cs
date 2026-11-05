using System;
using Stack.Backend;

public class UsingStack
{
    public static void Main(string[] args)
    {
        var stack = new Stackusingarray<int>(5);

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(45);

        Console.WriteLine(stack.Peek()); // 30 (pero no lo elimina)
        Console.WriteLine(stack.Pop());  // 30 (ahora sí lo elimina)
        Console.WriteLine(stack.Pop());  // 20
        Console.WriteLine(stack.Pop());  // 10
        Console.WriteLine(stack.Peek()); // 30 (pero no lo elimina)
        Console.WriteLine(stack.Pop());
    }
}
