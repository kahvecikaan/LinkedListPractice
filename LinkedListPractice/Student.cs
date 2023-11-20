namespace LinkedListPractice;

public class Student
{
    private int _id;
    private string _fullName;
    private double _gpa;

    public Student(int id, string fullName, double gpa)
    {
        _id = id;
        _fullName = fullName;
        _gpa = gpa;
    }
    
    public int GetId()
    {
        return _id;
    }
    
    public int SetId(int id)
    {
        _id = id;
        return _id;
    }
    
    public string GetFullName()
    {
        return _fullName;
    }
    
    public string SetFullName(string fullName)
    {
        _fullName = fullName;
        return _fullName;
    }
    
    public double GetGpa()
    {
        return _gpa;
    }
    
    public double SetGpa(double gpa)
    {
        _gpa = gpa;
        return _gpa;
    }
    
    public override string ToString()
    {
        return $"Student Id: {_id}, Full Name: {_fullName}, GPA: {_gpa}";
    }
}