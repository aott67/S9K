public class EventService
{


    //To-Do: Event creation logic implementation
    //To-Do: Determine where event addition to calendar is performed
    //To-Do: Event invite sending (when applicable) on event creation

    public Event CreateEvent(ref Calendar userCal)
    {
        return null;
    }

    //To-do: Event time generation algorithm algorithm
    //To-do: consideration of preferred times
    public (DateTime, TimeBlock) GenerateEventTime(ref Availability userAv, ref Calendar userCal, int numMin)
    {
        return (DateTime.Now, new TimeBlock(TimeOnly.MaxValue, TimeOnly.MinValue));
    }

    //To-do: finish Calendar implementation to test editing of events
    //To-do: ICS event update, although this is on the back-burner
    public void EditEvent(ref Event eventTBE, string? name, DateTime? date, TimeBlock? time, string? type)
    {
        if (name != null)
            eventTBE.EventName = name;

        if (date.HasValue)
            eventTBE.EventDate = date.Value;

        if (time != null)
            eventTBE.EventTimeBlock = time.Value;

        if (type != null)
            eventTBE.EventType = type;

        
    }

    //To-Do: search for user logic()
    public bool SearchForUser(String userName)
    {
        return false;
    }

    public void AddUserToGroup(ref Event curEvent, string userName)
    {
        curEvent.EventGroup.Add(userName);
    }

    public void RemoveUserFromGroup(ref Event curEvent, string user)
    {
        //Assumption made is that we know the user is in the group, so we don't need to check the list first
        curEvent.EventGroup.Remove(user);
    }
}