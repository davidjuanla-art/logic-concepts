

namespace DoublyLinkedList.Backend;

public class DoublyLinkedList<T>
{
    private DoubleNode<T>? _head;
    private DoubleNode<T>? _tail;

    public DoubleNode<T>? Head => _head;

    public DoublyLinkedList()
    {
        _head = null;
        _tail = null;
    }

    public override string ToString()
    {
        var output = string.Empty;
        var current = _head;

        while (current != null)
        {
            output += $"{current.Data} <-> ";
            current = current.Next;
        }

        return $"{output}null";
    }
    public string ToStringReverse()
    {
        var output = string.Empty;
        var current = _tail;
        while (current != null)
        {
            output += $"{current.Data} <-> ";
            current = current.Prev;
        }
        return $"{output} null";
    }


    public void AddUpward(T data, IComparer<T> comparer)
    {
        var newNode = new DoubleNode<T>(data);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
            return;
        }

        var current = _head;

        while (current != null && comparer.Compare(current.Data!, data) <= 0)
        {
            current = current.Next;
        }

        if (current == null)
        {
            _tail!.Next = newNode;
            newNode.Prev = _tail;
            _tail = newNode;
        }
        else if (current.Prev == null)
        {
            newNode.Next = current;
            current.Prev = newNode;
            _head = newNode;
        }
        else
        {
            newNode.Prev = current.Prev;
            newNode.Next = current;
            current.Prev.Next = newNode;
            current.Prev = newNode;
        }
    }

    public void SortDescending()
    {
        if (_head == null)
        {
            return;
        }

        var current = _head;

        while (current != null)
        {
            var temp = current.Next;
            current.Next = current.Prev;
            current.Prev = temp;

            current = temp;
        }

        var aux = _head;
        _head = _tail;
        _tail = aux;
    }


    public DoublyLinkedList<T> Mode()
    {
        var modes = new DoublyLinkedList<T>();

        if (_head == null)
        {
            return modes;
        }

        int maxFrequency = 0;
        int currentFrequency = 1;

        var current = _head;

        while (current.Next != null)
        {
            if (current.Data!.Equals(current.Next.Data))
            {
                currentFrequency++;
            }
            else
            {
                if (currentFrequency > maxFrequency)
                {
                    maxFrequency = currentFrequency;

                    modes._head = null;
                    modes._tail = null;

                    var newNode = new DoubleNode<T>(current.Data);
                    modes._head = newNode;
                    modes._tail = newNode;
                }
                else if (currentFrequency == maxFrequency)
                {
                    var newNode = new DoubleNode<T>(current.Data);

                    newNode.Prev = modes._tail;
                    modes._tail!.Next = newNode;
                    modes._tail = newNode;
                }

                currentFrequency = 1;
            }

            current = current.Next;
        }

        if (currentFrequency > maxFrequency)
        {
            modes._head = null;
            modes._tail = null;

            var newNode = new DoubleNode<T>(current.Data);
            modes._head = newNode;
            modes._tail = newNode;
        }
        else if (currentFrequency == maxFrequency)
        {
            var newNode = new DoubleNode<T>(current.Data);

            newNode.Prev = modes._tail;
            modes._tail!.Next = newNode;
            modes._tail = newNode;
        }

        return modes;
    }

    public string ShowGraph()
    {
        if (_head == null)
        {
            return string.Empty;
        }

        var output = string.Empty;
        int currentFrequency = 1;

        var current = _head;

        while (current.Next != null)
        {
            if (current.Data!.Equals(current.Next.Data))
            {
                currentFrequency++;
            }
            else
            {
                output += $"{current.Data} {new string('*', currentFrequency)}\n";

                currentFrequency = 1;
            }

            current = current.Next;
        }

        output += $"{current.Data} {new string('*', currentFrequency)}";

        return output;
    }

    public bool Exist(T data)
    {
        var current = _head;

        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                return true;
            }

            current = current.Next;
        }

        return false;
    }

    public void Remove(T data)
    {
        var current = _head;

        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                if (current.Prev == null && current.Next == null)
                {
                    _head = null;
                    _tail = null;
                    return;
                }

                if (current.Prev == null)
                {
                    current.Next!.Prev = null;
                    _head = current.Next;
                    return;
                }

                if (current.Next == null)
                {
                    current.Prev.Next = null;
                    _tail = current.Prev;
                    return;
                }

                current.Prev.Next = current.Next;
                current.Next.Prev = current.Prev;
                return;
            }

            current = current.Next;
        }
    }

    public void RemoveAll(T data)
    {
        var current = _head;

        while (current != null)
        {
            var next = current.Next;

            if (current.Data!.Equals(data))
            {
                if (current.Prev == null && current.Next == null)
                {
                    _head = null;
                    _tail = null;
                }
                else if (current.Prev == null)
                {
                    _head = current.Next;
                    _head!.Prev = null;
                }
                else if (current.Next == null)
                {
                    _tail = current.Prev;
                    _tail!.Next = null;
                }
                else
                {
                    current.Prev.Next = current.Next;
                    current.Next.Prev = current.Prev;
                }
            }

            current = next;
        }
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
    }
}


   