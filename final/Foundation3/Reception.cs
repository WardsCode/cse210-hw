using System;
public class Reception: Event

{
    private string _emailRsvp;

    public Reception (string title, string description, string date, string time, string address, string emailRsvp) : base (title, description, date, time, address)
    {
        _emailRsvp = emailRsvp;
    }

    public string GetEmail()
    {
        return _emailRsvp;
    }

}