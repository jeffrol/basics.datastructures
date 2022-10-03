namespace Jeffrol.DataStructures;


/// <summary>
/// A Basic Linked List class.  This is a singly linked list class.
/// </summary>
public class JeffLinkedList<T>
{
    public JeffNode<T>? head { get; set; }

    public bool isEmpty(){
        return head == null;
    }

    public void addValueAtEnd(T valueIn){
        JeffNode<T> newNode = new JeffNode<T>(valueIn, null);
        addNodeAtEnd(newNode);
    }

    public void addValueAtHead(T valueIn){
        JeffNode<T> newNode = new JeffNode<T>(valueIn, null);
        addNodeAtHead(newNode);
    }

    public void addNodeAtEnd(JeffNode<T> node){
        if(head == null){
            head = node;
            return;
        }

        var curr = head;
        while(curr.next != null){
            curr = curr.next;
        }

        curr.next = node;
    }

    public void addNodeAtHead(JeffNode<T> node){
        node.next = head;
        head = node;
    }

    public List<T> ToList(){
        var result = new List<T>();

        var curr = head;
        while(curr != null){
            result.Add(curr.value);
            curr = curr.next;
        }

        return result;
    }
}

/// <summary>
/// A basic Node class for a node in a singly linked list
/// </summary>
/// <typeparam name="T"></typeparam>
public class JeffNode<T>
{
    public JeffNode<T>? next { get; set; }
    public T value { get; set; }

    public JeffNode(T valueIn, JeffNode<T>? nextIn)
    {
        value = valueIn;
        next = nextIn;
    }
}