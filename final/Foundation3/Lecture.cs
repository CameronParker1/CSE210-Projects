public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string speaker, int capacity)
    
      : base("Intro to Machine Learning Algorithms ","This lecture goes over the basics of machine learning and development of algorithms.","Held on: 12/7/23","@ 1:00 PM","123 A Street","Rexburg","Idaho","United States")
    {
        _speaker = speaker;
        _capacity = capacity;
        SetEventType("Event Type: Lecture");
    }
   
    public string SetSpecifics()
    {
        return $"The speaker today is {_speaker}. \nWe have a capacity of {_capacity} people. \n";
    }
}