using System;

public class Reference
{
    private string _reference;
    private string _scripture;

    public void setReference(string reference)
    {
        _reference = reference;
    }

    public string getReference()
    {
        return _reference;
    }

    public void setScripture(string scripture)
    {
        _scripture = scripture;
    }

    public string getScripture()
    {
        return _scripture;
    }
}