

namespace DoublyLinkedList.Backend;

    public class DoublyLinkedList<T>
    {
        private DoubleNode<T>? _head;
        private DoubleNode<T>? _tail;

        public DoublyLinkedList()
        {
            _head = null; 
            _tail = null; 
        }

    public void Adicionar(T data, IComparer<T> comparer)
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
}
