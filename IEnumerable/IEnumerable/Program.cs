using System.Collections;


SingleLinkedList<int> list = new(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

foreach (var elem in list)
{
    Console.WriteLine(elem);
}


public class Node<T> {
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Previous { get; set; }

    public Node(T value)
    {
        Data = value;
        Next = null;
        Previous = null;
    }

    public override string ToString()
    {
        return $"{Data}";
    }
}


 public class SingleLinkedList<T> : IEnumerable<T> {
        public Node<T> node;

        public SingleLinkedList() {}
        public SingleLinkedList(params T[] values)
        {   
            foreach (var item in values)
            {
                PushBack(item);
            }
        }
        public bool IsEmpty()
        {
            return node == null;
        }
        public virtual void PushBack(T value)
        {
            if(IsEmpty())
            {
                node = new(value);
            }
            else
            {
                Node<T> current = node;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = new(value);
            }
        }
        public virtual void PushFront(T value)
        {
            if(IsEmpty())
            {
                node = new(value);
            }
            else
            {
                Node<T> tmp = node;
                node = new(value)
                {
                    Next = tmp
                };
            }
        }
        public virtual void Insert(int index, T value)
        {
            Node<T> current = node;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            Node<T> tmp = current.Next;
            current.Next = new(value);
            current = current.Next;
            current.Next = tmp;
        }
        public void Replace(int index, T value)
        {
            Node<T> current = node;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = value;
        }
        public void Pop()
        {
            node = node.Next;
        }
        public void Pop(int index)
        {
            Node<T> current = node;
            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }
            current.Next = current.Next.Next;
        }
        public bool Contains(T value)
        {
            Node<T> current = node;
            
            while(current != null)
            {
                if (value.Equals(current.Data))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public virtual void Print()
        {
            Node<T> current = node;
            while (current != null)
            {
                System.Console.Write($"{current.Data} ");
                current = current.Next;
            }
            System.Console.WriteLine();
        }
        public Node<T> this[int index]
        {
            get
            {
                Node<T> current = node;
                for (int i = 0; i < index + 1; i++)
                {
                    current = current.Next;
                }
                return current;
            }
            set
            {
                Replace(index, value.Data);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = node;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
 }