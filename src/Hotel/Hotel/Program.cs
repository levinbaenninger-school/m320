namespace Hotel;

internal abstract class Program
{
    private static void Main()
    {
        var hotel = new Hotel("Alpenrose", "Alpenweg 2", new Reception("123456789", "info@alpenrose.ch"));
        
        var room1 = hotel.AddRoom(new Room());
        room1.AddBed(new Bed(90));
        room1.AddBed(new Bed(120));

        var room2 = hotel.AddRoom(new Room());

        var meetingRoom1 = hotel.AddMeetingRoom(new MeetingRoom(20));
        meetingRoom1.AddBeamer(new Beamer("Seiko", 1024));
        meetingRoom1.AddBeamer(new Beamer("Samsung", 1024));

        var meetingRoom2 = hotel.AddMeetingRoom(new MeetingRoom(5)); 
        meetingRoom2.AddBeamer(new Beamer("Toshiba", 1024));
        
        hotel.Print();
    }
}
