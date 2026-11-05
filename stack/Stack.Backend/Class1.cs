namespace Stack.Backend;

public class Stackusingarray<T>
{

    //fields
    private T[] elements;
    private int top;

    //constructors
    public Stackusingarray(int capacity)
    {
        elements = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == elements.Length - 1)

            throw new InvalidOperationException("Stack is full.");

        elements[++top] = item;
    }

    public T Pop()
    {
        if (top < 0)
            throw new InvalidOperationException("Stck is empty");

        return elements[top--];
    }

    public T Peek()
    {
        if (top  < 0)
        {
            throw new InvalidOperationException("Stak is empty");
        }
        return elements[top];
    }

}