using LinkedListPractice;

public class Program
{
    public static void Main()
    {
        var linkedList = new MyLinkedList();
        
        var student1 = new Student(1, "John Doe", 3.5);
        var student2 = new Student(2, "Jane Doe", 3.8);
        var student3 = new Student(3, "Jack Doe", 3.2);
        var student4 = new Student(4, "Jill Doe", 3.9);
        
        linkedList.AddStudent(student1);
        linkedList.AddStudent(student2);
        linkedList.AddStudent(student3);
        linkedList.AddStudent(student4);

        Console.WriteLine("All students:");
        linkedList.PrintData();

        Console.WriteLine("students with GPA > 3.5:");
        linkedList.SearchGpa(3.5);
    }
}

