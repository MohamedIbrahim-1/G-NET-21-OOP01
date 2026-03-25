namespace assignment_oop_01;
public class Ticket
{
    /*
    
    // Properties
    public string MovieName { get; set; }
    public string Type { get; set; }
    public Seat Seat { get; set; }
    private double Price;

    // Constructors
    public Ticket(string movieName, string type, Seat seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
    }

    public Ticket(string movieName) // Default values
    {
        MovieName = movieName;
        Type = TicketTypes.Standard;
        Seat = new Seat('A', 1);
        Price = 50;
    }

    // Methods
    public double CalcTotal(double taxPercent)
    {
        return Price + (Price * taxPercent / 100);
    }

    public void ApplyDiscount(ref double discountAmount)
    {
        if (discountAmount > 0 && discountAmount <= Price)
        {
            Price -= discountAmount;
            discountAmount = 0; // consumed
        }
    }

    public void PrintTicket(double taxPercent)
    {
        Console.WriteLine("===== Ticket Info =====");
        Console.WriteLine($"Movie : {MovieName}");
        Console.WriteLine($"Type  : {Type}");
        Console.WriteLine($"Seat  : {Seat}");
        Console.WriteLine($"Price : {Price:0.00}");
        Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent):0.00}");
        Console.WriteLine();
    }
    
    */
}
