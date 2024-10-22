namespace Hotel;

public class Hotel(
    string name,
    string address,
    Reception reception)
{
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;
    public List<Room> Rooms { get; set; } = [];
    public Reception Reception { get; set; } = reception;
    public List<MeetingRoom> MeetingRooms { get; set; } = [];
    
    public Room AddRoom(Room room)
    {
        if (Rooms.Count > 10)
        {
            throw new InvalidOperationException("There can't be more than 10 rooms in a hotel.");
        }
        
        Rooms.Add(room);
        return room;
    }
    
    public MeetingRoom AddMeetingRoom(MeetingRoom meetingRoom)
    {
        if (MeetingRooms.Count > 3)
        {
            throw new InvalidOperationException("There can't be more than 3 meeting rooms in a hotel.");
        }
        
        MeetingRooms.Add(meetingRoom);
        return meetingRoom;
    }
    
    public void Print()
    {
        Console.WriteLine($"Hotel {Name} at {Address}");
        Reception.Print();
        
        foreach (var room in Rooms)
        {
            Console.Write("\t");
            room.Print();
        }
        
        foreach (var meetingRoom in MeetingRooms)
        {
            Console.Write("\t");
            meetingRoom.Print();
        }
    }
}