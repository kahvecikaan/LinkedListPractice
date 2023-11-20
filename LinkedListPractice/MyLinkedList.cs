namespace LinkedListPractice;

public class MyLinkedList
{
    private MyNode? _root;
    private int _size;

    public MyLinkedList()
    {
        _root = null;
        _size = 0;
    }

    public void AddStudent(Student student)
    {
        var newNode = new MyNode(student);
        if (_root == null)
        {
            _root = newNode;
        }
        else
        {
            var current = _root;
            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }

            current.SetNext(newNode);
            _size++;
        }
    }
    
    public void SearchGpa(double gpa)
    {
        var current = _root;
        while (current != null)
        {
            if (current.GetStudent().GetGpa() > gpa)
            {
                Console.WriteLine(current.GetStudent().ToString());
            }
            current = current.GetNext();
        }
    }

    public void PrintData()
    {
        var current = _root;
        while (current != null)
        {
            Console.WriteLine(current.GetStudent().ToString());
            current = current.GetNext();
        }
    }
}