using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

public class Reception : Event 
{
    private string _emailAddress;

    public Reception(string emailAddress)

      : base("Ben and Sally's Wedding Reception","This will be a celebration of Ben and Sally's marriage.","Held on 12/19/23","@ 7:00 PM","4321 Happy Street","San Diego","California","United States")
    {
        _emailAddress = emailAddress;
        SetEventType("Event Type: Reception");
    }
    public string DisplayRsvpMessage()
    {
        return $"Please send your RSVP to: {_emailAddress} \n";
    }
}