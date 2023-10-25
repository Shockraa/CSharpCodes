using System;

public class Program
{
	public static void Main()
	{
		
	}
}

public class GSM
{
	private string phoneModel;
	private string manufacturer;
	private double price;
	private string owner;
	public string PhoneModel { get => phoneModel; set => phoneModel = value; }

	public string Manufacturer { get => manufacturer; set => manufacturer = value; }

	public double Price { get => price; set => price = value; }

	public string Owner { get => owner; set => owner = value; }

	public GSM()
	{
		this.phoneModel = null;
		this.manufacturer = null;
		this.price = 0;
		this.owner = null;
	}

	public GSM(string phoneModel, string manufacturer, double price, string owner)
	{
		this.phoneModel = phoneModel;
		this.manufacturer = manufacturer;
		this.price = price;
		this.owner = owner;
	}

	public static GSM nokiaN95 = new GSM("Nokia N95", "Nokia", 500, null);
	
	public string GetInfo()
	{
	return $"Phone model: {PhoneModel}\nManufacturer: {Manufacturer}\nPrice: {Price}\nOwner: {Owner}";
	}
}

public class Battery
{
    private BatteryType batteryModel;
    private double idleTime;

    public BatteryType BatteryModel { get => batteryModel; set => batteryModel = value; }
    public double IdleTime { get => idleTime; set => idleTime = value; }

    public Battery()
    {
        this.batteryModel = BatteryType.LiIon;
        this.idleTime = 0;
    }

    public Battery(BatteryType batteryModel, double idleTime)
    {
        this.batteryModel = batteryModel;
        this.idleTime = idleTime;
    }
}

public class Display
{
	private double size;
	private string color;
	public double Size { get => size; set => size = value; }

	public string Color { get => color; set => color = value; }

	public Display()
	{
		this.size = 0;
		this.color = null;
	}

	public Display(double size, string color)
	{
		this.size = size;
		this.color = color;
	}
}

public class GSMTest
{
    private GSM[] gsmObjects;

    public GSMTest()
    {
        this.gsmObjects = new GSM[]
        {
            new GSM("Nokia N95", "Nokia", 500, "John Doe"),
            new GSM("Samsung Galaxy S22", "Samsung", 800, "Jane Doe"),
            new GSM("Google Pixel 6", "Google", 600, "Peter Parker")
        };
    }

    public void DisplayGSMObjectsInfo()
    {
        Console.WriteLine("Information about the created GSM objects:");
        foreach (GSM gsmObject in this.gsmObjects)
        {
            Console.WriteLine(gsmObject.GetInfo());
        }
    }

    public void DisplayNokiaN95Info()
    {
        GSM nokiaN95 = GSM.nokiaN95;
        Console.WriteLine("Information about the static field nokiaN95:");
        Console.WriteLine(nokiaN95.GetInfo());
    }
}

public class Call
{
    private DateTime date;
    private TimeSpan startTime;
    private TimeSpan duration;

    public Call(DateTime date, TimeSpan startTime, TimeSpan duration)
    {
        this.date = date;
        this.startTime = startTime;
        this.duration = duration;
    }

    public DateTime Date => date;
    public TimeSpan StartTime => startTime;
    public TimeSpan Duration => duration;

    public override string ToString()
    {
        return $"Date: {date}\nStart time: {startTime}\nDuration: {duration}";
    }
}

public enum BatteryType
{
	LiIon,
	NiMH,
	NiCd
}
