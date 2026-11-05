namespace DoublyLinkedlist.Backend;

public class DoubleNode<T>
{
    public T Data { get; set; }
    
    public  DoubleNode <T> Next  { get; set; }

    public DoubleNode <T> prev { get; set; }


    public DoubleNode (T Data)
    {
        Data = Data ;
        Next = null;
        prev = null;
    }


}

public class DoublyLinkedList<T>
{
    private DoubleNode<T> _head;

    private DoubleNode<T> _tail;

    public DoublyLinkedList ( )
    {
        _head = null;
        _tail = null;


    }

    public void InsertBeginning(T Data)
    {
        DoubleNode<T> newNode = new DoubleNode<T>(Data);

        if (_head == null)
        {

            _head = newNode;
            _tail = newNode;
        }

        else
        {
            newNode.Next = _head;
            _head.prev = newNode;
            _head = newNode;
        }
    }

    public void InserAtEnd(T Data)
    {
        DoubleNode<T> newNode = new DoubleNode<T>(Data);

        if(_tail == null )
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            newNode.prev = _tail;
            _tail = newNode;

        }




    }
}




