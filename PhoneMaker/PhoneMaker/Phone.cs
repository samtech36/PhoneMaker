namespace PhoneMaker;

public class Phone
{
    public Phone()
    {
        PhoneFactory.numberofphones++;
    }
    
    
    public string Brand  { get; set; }
    public string Make { get; set; }
    
    public string Model { get; set; }
    
    public bool ISFast { get; set; }
    
    
    
    //methods for the phone maker

    public void Type()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine($"The Phone I have is {Brand} {Make} {Model}");
        
    }

    public void MakePhone()
    {
        Console.WriteLine($"It is {ISFast} that the Phone is Fast and Efficient");
    }
    
}