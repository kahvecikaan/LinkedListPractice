namespace LinkedListPractice;

public class MyNode
{
    private readonly Student _student; 
    private MyNode? _next;
    
    public MyNode(Student student)
    {
        this._student = student;
        _next = null;
    }

    public Student GetStudent()
    {
        return _student;
    }

    public MyNode? GetNext()
    {
        return _next;
    }
    
    public void SetNext(MyNode next)
    {
        _next = next;
    }
}